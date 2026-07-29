using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.GettingStarted;

public class InstallingGitModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Installing Visual Studio", Url = "/GettingStarted/01-InstallingVisualStudio", IsActive = false },
            new() { Title = "Choosing the Right Workloads", Url = "/GettingStarted/02-WorkloadsToSelect", IsActive = false },
            new() { Title = "Installing SQL Server Express & SSMS", Url = "/GettingStarted/03-InstallingSqlExpressSsms", IsActive = false },
            new() { Title = "Installing Git", Url = "/GettingStarted/04-InstallingGit", IsActive = true }
        };
    }
}