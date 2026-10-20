using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpMasteryHub.Pages.DevOps;

public class DockerBasicsModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Docker Basics";
    }
}