using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;

namespace CSharpMasteryHub.Pages;

public class ContactModel : PageModel
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<ContactModel> _logger;

    public ContactModel(IConfiguration configuration, ILogger<ContactModel> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    [BindProperty]
    public ContactForm Contact { get; set; } = new();

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            bool emailSent = await SendEmailAsync(
                Contact.Name,
                Contact.Email,
                Contact.Subject,
                Contact.Message
            );

            if (emailSent)
            {
                TempData["SuccessMessage"] = "✅ Thank you for your message! We'll get back to you soon.";
                return RedirectToPage();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Failed to send message. Please try again later.");
                return Page();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending contact form email");
            ModelState.AddModelError(string.Empty, "An error occurred. Please try again later.");
            return Page();
        }
    }

    private async Task<bool> SendEmailAsync(string name, string email, string subject, string message)
    {
        try
        {
            // Get email settings from user secrets / environment variables
            var smtpServer = _configuration["EmailSettings:SmtpServer"] ?? "smtp.gmail.com";
            var smtpPort = int.Parse(_configuration["EmailSettings:SmtpPort"] ?? "587");
            var senderEmail = _configuration["EmailSettings:SenderEmail"] ?? "aliabdulsameea69@gmail.com";
            var senderPassword = _configuration["EmailSettings:SenderPassword"];

            if (string.IsNullOrEmpty(senderPassword))
            {
                _logger.LogError("Email password not configured. Set EmailSettings:SenderPassword in user secrets or environment variables.");
                return false;
            }

            using var client = new SmtpClient(smtpServer, smtpPort);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(senderEmail, senderPassword);

            var mailMessage = new MailMessage
            {
                From = new MailAddress(senderEmail, "C# Mastery Hub"),
                Subject = $"[C# Mastery Hub] {subject}",
                Body = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2 style='color: #512BD4;'>New Contact Form Submission</h2>
                        <hr style='border: 1px solid #eee;' />
                        <p><strong>Name:</strong> {WebUtility.HtmlEncode(name)}</p>
                        <p><strong>Email:</strong> {WebUtility.HtmlEncode(email)}</p>
                        <p><strong>Subject:</strong> {WebUtility.HtmlEncode(subject)}</p>
                        <hr style='border: 1px solid #eee;' />
                        <p><strong>Message:</strong></p>
                        <p style='background: #f5f7fa; padding: 15px; border-radius: 8px;'>
                            {WebUtility.HtmlEncode(message).Replace("\n", "<br />")}
                        </p>
                        <hr style='border: 1px solid #eee;' />
                        <p style='color: #999; font-size: 12px;'>
                            Sent from C# Mastery Hub Contact Form
                        </p>
                    </body>
                    </html>
                ",
                IsBodyHtml = true
            };

            mailMessage.To.Add("aliabdulsameea69@gmail.com");

            await client.SendMailAsync(mailMessage);
            _logger.LogInformation($"Email sent from {email} with subject: {subject}");
            return true;
        }
        catch (SmtpException smtpEx)
        {
            _logger.LogError(smtpEx, "SMTP error sending email: {0}", smtpEx.Message);
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "General error sending email: {0}", ex.Message);
            return false;
        }
    }
}

public class ContactForm
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Subject is required")]
    [StringLength(200, ErrorMessage = "Subject cannot exceed 200 characters")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Message is required")]
    [StringLength(5000, ErrorMessage = "Message cannot exceed 5000 characters")]
    public string Message { get; set; } = string.Empty;
}