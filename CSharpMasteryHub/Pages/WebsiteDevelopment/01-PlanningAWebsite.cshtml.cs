using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.WebsiteDevelopment;

public class PlanningAWebsiteModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = [];

    public void OnGet()
    {
        SidebarNav =
        [
            new() { Title = "Planning A Website", Url = "/WebsiteDevelopment/01-PlanningAWebsite", IsActive = true },
            new() { Title = "Project Structure Best Practices", Url = "/WebsiteDevelopment/02-ProjectStructureBestPractices", IsActive = false },
            new() { Title = "Responsive Design with Bootstrap", Url = "/WebsiteDevelopment/03-ResponsiveDesignBootstrap", IsActive = false },
            new() { Title = "Git Workflow", Url = "/WebsiteDevelopment/04-GitWorkflow", IsActive = false }
        ];
    }
}