using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpMasteryHub.Pages.DevOps;

public class RealClientScenarioModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Real Client Scenario";
    }
}