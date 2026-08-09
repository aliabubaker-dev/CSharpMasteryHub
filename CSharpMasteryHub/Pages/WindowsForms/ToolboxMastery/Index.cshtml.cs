using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.WindowsForms.ToolboxMastery;

public class IndexModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Toolbox Mastery Home", Url = "/WindowsForms/ToolboxMastery", IsActive = true },
            new() { Title = "Basic Controls", Url = "/WindowsForms/ToolboxMastery#basic", IsActive = false },
            new() { Title = "Data & Container Controls", Url = "/WindowsForms/ToolboxMastery#data", IsActive = false },
            new() { Title = "Specialized Controls", Url = "/WindowsForms/ToolboxMastery#special", IsActive = false },
            new() { Title = "Menus & Dialogs", Url = "/WindowsForms/ToolboxMastery#menus", IsActive = false },
            new() { Title = "Toolbox Quiz", Url = "/WindowsForms/ToolboxMastery/Quiz", IsActive = false }
        };
    }
}