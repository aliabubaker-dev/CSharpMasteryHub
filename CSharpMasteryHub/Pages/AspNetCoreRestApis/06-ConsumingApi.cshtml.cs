using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.AspNetCoreRestApis;

public class ConsumingApiModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();
    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "1. What is an API?", Url = "/AspNetCoreRestApis/01-WhatIsApi", IsActive = false },
            new() { Title = "2. What is REST?", Url = "/AspNetCoreRestApis/02-WhatIsRest", IsActive = false },
            new() { Title = "3. Creating a Web API", Url = "/AspNetCoreRestApis/03-CreatingWebApi", IsActive = false },
            new() { Title = "4. HTTP Methods", Url = "/AspNetCoreRestApis/04-HttpMethods", IsActive = false },
            new() { Title = "5. JSON & Serialization", Url = "/AspNetCoreRestApis/05-JsonAndSerialization", IsActive = false },
            new() { Title = "6. Consuming an API", Url = "/AspNetCoreRestApis/06-ConsumingApi", IsActive = true },
            new() { Title = "7. Routing & Parameters", Url = "/AspNetCoreRestApis/07-RoutingAndParameters", IsActive = false },
            new() { Title = "8. Status Codes", Url = "/AspNetCoreRestApis/08-StatusCodes", IsActive = false },
            new() { Title = "9. Dependency Injection", Url = "/AspNetCoreRestApis/09-DependencyInjection", IsActive = false },
            new() { Title = "10. Securing APIs", Url = "/AspNetCoreRestApis/10-SecuringApis", IsActive = false }
        };
    }
}