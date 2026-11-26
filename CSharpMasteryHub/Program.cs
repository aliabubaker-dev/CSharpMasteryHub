using CSharpMasteryHub.Services;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseSetting("hostBuilder:reloadConfigOnChange", "false");

if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}

builder.Services.AddRazorPages();
builder.Services.AddScoped<SeoService>();
builder.Services.AddScoped<QuizService>();
builder.Services.AddScoped<ChallengeService>();
builder.Services.AddScoped<DiscussionService>();
builder.Services.AddScoped<NewsletterService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

// ===== NEWSLETTER API ENDPOINT =====
app.MapPost("/api/newsletter/subscribe", async (HttpContext http, NewsletterService newsletter, ILogger<Program> logger) =>
{
    try
    {
        using var reader = new StreamReader(http.Request.Body);
        var body = await reader.ReadToEndAsync();

        if (string.IsNullOrWhiteSpace(body))
            return Results.BadRequest(new { success = false, message = "Request body is empty." });

        var payload = System.Text.Json.JsonSerializer.Deserialize<SubscribePayload>(
            body,
            new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        var email = payload?.Email?.Trim();

        if (string.IsNullOrWhiteSpace(email))
            return Results.BadRequest(new { success = false, message = "Email is required." });

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            return Results.BadRequest(new { success = false, message = "Invalid email format." });

        var ok = await newsletter.SubscribeAsync(email);

        if (!ok)
            return Results.Json(new { success = false, message = "Could not save subscription." }, statusCode: 500);

        logger.LogInformation("Newsletter subscription succeeded for {Email}", email);
        return Results.Ok(new { success = true, message = "Subscribed successfully!" });
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Newsletter endpoint failed");
        return Results.Json(new { success = false, message = "Server error." }, statusCode: 500);
    }
});

app.Run();

// Payload record
public record SubscribePayload(string Email);