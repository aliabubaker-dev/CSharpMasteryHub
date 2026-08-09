using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.WindowsForms.ToolboxMastery.Controls;

public class ButtonModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Button", Url = "/WindowsForms/ToolboxMastery/Controls/Button", IsActive = true },
            new() { Title = "CheckBox", Url = "/WindowsForms/ToolboxMastery/Controls/CheckBox", IsActive = false },
            new() { Title = "ComboBox", Url = "/WindowsForms/ToolboxMastery/Controls/ComboBox", IsActive = false },
            new() { Title = "DataGridView", Url = "/WindowsForms/ToolboxMastery/Controls/DataGridView", IsActive = false },
            new() { Title = "TextBox", Url = "/WindowsForms/ToolboxMastery/Controls/TextBox", IsActive = false },
            new() { Title = "Timer", Url = "/WindowsForms/ToolboxMastery/Controls/Timer", IsActive = false },
        };
    }
}