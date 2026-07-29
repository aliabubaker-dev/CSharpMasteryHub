using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.WindowsForms;

public class EventHandlingModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Creating a WinForms Project", Url = "/WindowsForms/01-CreatingWinFormsProject", IsActive = false },
            new() { Title = "Controls Basics", Url = "/WindowsForms/02-ControlsBasics", IsActive = false },
            new() { Title = "Event Handling", Url = "/WindowsForms/03-EventHandling", IsActive = true },
            new() { Title = "Menus & Dialogs", Url = "/WindowsForms/04-MenusAndDialogs", IsActive = false },
            new() { Title = "Data Binding", Url = "/WindowsForms/05-DataBinding", IsActive = false },
            new() { Title = "Multi-Form Applications", Url = "/WindowsForms/06-MultiFormApps", IsActive = false },
            new() { Title = "Full CRUD Project Walkthrough", Url = "/WindowsForms/07-CrudProjectWalkthrough", IsActive = false }
        };
    }
}