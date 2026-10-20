using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpMasteryHub.Pages.DevOps;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "DevOps Learning Hub";
    }
}