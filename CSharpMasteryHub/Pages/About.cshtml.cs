using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpMasteryHub.Pages;

public class AboutModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "About C# Mastery Hub";
    }
}