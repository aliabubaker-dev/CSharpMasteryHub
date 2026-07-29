using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.ClassesAndOOP;

public class PolymorphismModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "What Is A Class", Url = "/ClassesAndOOP/01-WhatIsAClass", IsActive = false },
            new() { Title = "Fields and Properties", Url = "/ClassesAndOOP/02-FieldsAndProperties", IsActive = false },
            new() { Title = "Methods Deep Dive", Url = "/ClassesAndOOP/03-MethodsDeepDive", IsActive = false },
            new() { Title = "Constructors", Url = "/ClassesAndOOP/04-Constructors", IsActive = false },
            new() { Title = "Encapsulation", Url = "/ClassesAndOOP/05-Encapsulation", IsActive = false },
            new() { Title = "Inheritance", Url = "/ClassesAndOOP/06-Inheritance", IsActive = false },
            new() { Title = "Polymorphism", Url = "/ClassesAndOOP/07-Polymorphism", IsActive = true },
            new() { Title = "Abstraction & Interfaces", Url = "/ClassesAndOOP/08-AbstractionInterfaces", IsActive = false },
            new() { Title = "Static vs Instance", Url = "/ClassesAndOOP/09-StaticVsInstance", IsActive = false },
            new() { Title = "Generics", Url = "/ClassesAndOOP/10-Generics", IsActive = false },
            new() { Title = "SOLID Principles", Url = "/ClassesAndOOP/11-SolidPrinciples", IsActive = false }
        };
    }
}