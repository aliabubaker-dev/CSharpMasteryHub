using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.CSharpFundamentals;

public class OperatorsAndExpressionsModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Introduction to C#", Url = "/CSharpFundamentals/01-Introduction", IsActive = false },
            new() { Title = "Setting Up Environment", Url = "/CSharpFundamentals/02-SettingUpEnvironment", IsActive = false },
            new() { Title = "Variables and Data Types", Url = "/CSharpFundamentals/03-VariablesAndDataTypes", IsActive = false },
            new() { Title = "Operators and Expressions", Url = "/CSharpFundamentals/04-OperatorsAndExpressions", IsActive = true },
            new() { Title = "Control Flow", Url = "/CSharpFundamentals/05-ControlFlow", IsActive = false },
            new() { Title = "Loops", Url = "/CSharpFundamentals/06-Loops", IsActive = false },
            new() { Title = "Arrays and Collections", Url = "/CSharpFundamentals/07-ArraysAndCollections", IsActive = false },
            new() { Title = "Strings", Url = "/CSharpFundamentals/08-Strings", IsActive = false },
            new() { Title = "Exception Handling", Url = "/CSharpFundamentals/09-ExceptionHandling", IsActive = false },
            new() { Title = "Methods Basics", Url = "/CSharpFundamentals/10-MethodsBasics", IsActive = false },
            new() { Title = "Pattern Matching & Nullables", Url = "/CSharpFundamentals/11-PatternMatchingAndNullables", IsActive = false },
            new() { Title = "LINQ Introduction", Url = "/CSharpFundamentals/12-LinqIntroduction", IsActive = false },
            new() { Title = "Delegates, Events & Async", Url = "/CSharpFundamentals/13-DelegatesEventsAsync", IsActive = false }
        };
    }
}