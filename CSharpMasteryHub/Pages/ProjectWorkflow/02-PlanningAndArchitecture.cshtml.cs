using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.ProjectWorkflow;

public class PlanningAndArchitectureModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Understanding Requirements", Url = "/ProjectWorkflow/01-UnderstandingRequirements", IsActive = false },
            new() { Title = "Planning and Architecture", Url = "/ProjectWorkflow/02-PlanningAndArchitecture", IsActive = true },
            new() { Title = "Git Branching Strategy", Url = "/ProjectWorkflow/03-GitBranchingStrategy", IsActive = false },
            new() { Title = "Coding Standards", Url = "/ProjectWorkflow/04-CodingStandards", IsActive = false },
            new() { Title = "Testing and Delivering", Url = "/ProjectWorkflow/05-TestingAndDelivering", IsActive = false }
        };
    }
}