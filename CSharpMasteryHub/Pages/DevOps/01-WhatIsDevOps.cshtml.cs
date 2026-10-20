using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpMasteryHub.Pages.DevOps;

public class WhatIsDevOpsModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "What is DevOps?";
    }
}