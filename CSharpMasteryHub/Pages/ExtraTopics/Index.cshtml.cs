using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.ExtraTopics;

public class IndexModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Git & GitHub", Url = "/ExtraTopics/01-GitAndGitHub", IsActive = false },
            new() { Title = "Unit Testing with xUnit", Url = "/ExtraTopics/02-UnitTestingXunit", IsActive = false },
            new() { Title = "Design Patterns", Url = "/ExtraTopics/03-DesignPatterns", IsActive = false },
            new() { Title = "Async/Await Deep Dive", Url = "/ExtraTopics/04-AsyncAwaitDeepDive", IsActive = false },
            new() { Title = "REST APIs with Web API", Url = "/ExtraTopics/05-RestApisWebApi", IsActive = false },
            new() { Title = "NuGet Packages", Url = "/ExtraTopics/06-NugetPackages", IsActive = false }
        };
    }
}