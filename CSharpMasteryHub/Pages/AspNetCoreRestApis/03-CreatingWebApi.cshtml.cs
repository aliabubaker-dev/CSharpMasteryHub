using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.AspNetCoreRestApis;

public class CreatingWebApiModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();
    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "1. What is an API?", Url = "/AspNetCoreRestApis/01-WhatIsApi", IsActive = false },
            new() { Title = "2. What is REST?", Url = "/AspNetCoreRestApis/02-WhatIsRest", IsActive = false },
            new() { Title = "3. Creating a Web API", Url = "/AspNetCoreRestApis/03-CreatingWebApi", IsActive = true },
            new() { Title = "4. HTTP Methods", Url = "/AspNetCoreRestApis/04-HttpMethods", IsActive = false },
            new() { Title = "5. Consuming an API", Url = "/AspNetCoreRestApis/05-ConsumingApi", IsActive = false },
            new() { Title = "6. JSON & Serialization", Url = "/AspNetCoreRestApis/06-JsonAndSerialization", IsActive = false }
        };
    }
}