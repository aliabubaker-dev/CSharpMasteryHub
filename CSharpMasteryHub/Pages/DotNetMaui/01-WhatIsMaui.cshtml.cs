using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.DotNetMaui;

public class WhatIsMauiModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "What Is MAUI", Url = "/DotNetMaui/01-WhatIsMaui", IsActive = true },
            new() { Title = "Environment Setup", Url = "/DotNetMaui/02-EnvironmentSetup", IsActive = false },
            new() { Title = "XAML Basics", Url = "/DotNetMaui/03-XamlBasics", IsActive = false },
            new() { Title = "Layouts and Controls", Url = "/DotNetMaui/04-LayoutsAndControls", IsActive = false },
            new() { Title = "Shell Navigation", Url = "/DotNetMaui/05-ShellNavigation", IsActive = false },
            new() { Title = "MVVM Pattern", Url = "/DotNetMaui/06-MvvmPattern", IsActive = false },
            new() { Title = "Connecting to API or DB", Url = "/DotNetMaui/07-ConnectingToApiOrDb", IsActive = false },
            new() { Title = "Publishing MAUI App", Url = "/DotNetMaui/08-PublishingMauiApp", IsActive = false }
        };
    }
}