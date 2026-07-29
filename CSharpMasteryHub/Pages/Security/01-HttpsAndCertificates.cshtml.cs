using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.Security;

public class HttpsAndCertificatesModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "HTTPS and Certificates", Url = "/Security/01-HttpsAndCertificates", IsActive = true },
            new() { Title = "Authentication & Identity", Url = "/Security/02-AuthenticationIdentity", IsActive = false },
            new() { Title = "SQL Injection Prevention", Url = "/Security/03-SqlInjectionPrevention", IsActive = false },
            new() { Title = "XSS & CSRF Protection", Url = "/Security/04-XssCsrfProtection", IsActive = false },
            new() { Title = "Security Headers", Url = "/Security/05-SecurityHeaders", IsActive = false },
            new() { Title = "Secrets Management", Url = "/Security/06-SecretsManagement", IsActive = false }
        };
    }
}