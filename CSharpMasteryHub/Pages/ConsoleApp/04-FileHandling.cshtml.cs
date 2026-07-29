using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.ConsoleApp;

public class FileHandlingModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Creating Console App", Url = "/ConsoleApp/01-CreatingConsoleApp", IsActive = false },
            new() { Title = "Input and Output", Url = "/ConsoleApp/02-InputOutput", IsActive = false },
            new() { Title = "Calculator Project", Url = "/ConsoleApp/03-CalculatorProject", IsActive = false },
            new() { Title = "File Handling", Url = "/ConsoleApp/04-FileHandling", IsActive = true }
        };
    }
}