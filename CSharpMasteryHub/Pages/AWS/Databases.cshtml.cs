using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.AWS;

public class DatabasesModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Getting Started", Url = "/AWS/GettingStarted", IsActive = false },
            new() { Title = "EC2 Virtual Servers", Url = "/AWS/EC2", IsActive = false },
            new() { Title = "S3 Storage", Url = "/AWS/S3", IsActive = false },
            new() { Title = "Lambda Serverless", Url = "/AWS/Lambda", IsActive = false },
            new() { Title = "Networking", Url = "/AWS/Networking", IsActive = false },
            new() { Title = "Databases", Url = "/AWS/Databases", IsActive = true },
            new() { Title = "Security & IAM", Url = "/AWS/Security", IsActive = false },
            new() { Title = "Deployment", Url = "/AWS/Deployment", IsActive = false },
            new() { Title = "Quiz", Url = "/AWS/Quiz", IsActive = false }
        };
    }
}