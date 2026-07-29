using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.Deployment;

public class FreeHostingOptionsModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Preparing for Deployment", Url = "/Deployment/01-PreparingForDeployment", IsActive = false },
            new() { Title = "Free Hosting Options", Url = "/Deployment/02-FreeHostingOptions", IsActive = true },
            new() { Title = "Deploying to Azure Free", Url = "/Deployment/03-DeployingToAzureFree", IsActive = false },
            new() { Title = "Free Custom Domain Options", Url = "/Deployment/04-FreeCustomDomainOptions", IsActive = false },
            new() { Title = "CI/CD with GitHub Actions", Url = "/Deployment/05-CiCdGithubActions", IsActive = false }
        };
    }
}