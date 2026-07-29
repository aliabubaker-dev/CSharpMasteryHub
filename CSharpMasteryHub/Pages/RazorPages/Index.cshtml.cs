using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.RazorPages;

public class RazorPagesIndexModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "MVC vs Razor Pages", Url = "/RazorPages/01-MvcVsRazorPages", IsActive = false },
            new() { Title = "PageModel and Routing", Url = "/RazorPages/02-PageModelAndRouting", IsActive = false },
            new() { Title = "Tag Helpers", Url = "/RazorPages/03-TagHelpers", IsActive = false },
            new() { Title = "Forms and Model Binding", Url = "/RazorPages/04-FormsAndModelBinding", IsActive = false },
            new() { Title = "Validation & Data Annotations", Url = "/RazorPages/05-ValidationDataAnnotations", IsActive = false },
            new() { Title = "Partials and Layouts", Url = "/RazorPages/06-PartialsAndLayouts", IsActive = false },
            new() { Title = "Dependency Injection", Url = "/RazorPages/07-DependencyInjection", IsActive = false },
            new() { Title = "Full CRUD Project", Url = "/RazorPages/08-FullCrudProject", IsActive = false }
        };
    }
}