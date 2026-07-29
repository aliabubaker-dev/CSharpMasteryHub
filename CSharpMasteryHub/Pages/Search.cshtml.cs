using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CSharpMasteryHub.Pages;

public class SearchModel : PageModel
{
    public string Query { get; set; } = string.Empty;
    public List<SearchResult> Results { get; set; } = new();

    public void OnGet(string q)
    {
        Query = q ?? string.Empty;

        if (!string.IsNullOrWhiteSpace(Query))
        {
            Results = GetSearchResults(Query);
        }
    }

    private List<SearchResult> GetSearchResults(string query)
    {
        var results = new List<SearchResult>();

        // Define all pages with their search keywords
        var pages = new List<SearchResult>
        {
            // C# Fundamentals
            new() { Title = "Introduction to C#", Url = "/CSharpFundamentals/01-Introduction", Description = "Learn what C# is and why it's popular", Category = "C# Fundamentals" },
            new() { Title = "Setting Up Environment", Url = "/CSharpFundamentals/02-SettingUpEnvironment", Description = "Install Visual Studio and .NET SDK", Category = "C# Fundamentals" },
            new() { Title = "Variables and Data Types", Url = "/CSharpFundamentals/03-VariablesAndDataTypes", Description = "Learn about variables, int, string, bool, and more", Category = "C# Fundamentals" },
            new() { Title = "Operators and Expressions", Url = "/CSharpFundamentals/04-OperatorsAndExpressions", Description = "Arithmetic, comparison, and logical operators", Category = "C# Fundamentals" },
            new() { Title = "Control Flow", Url = "/CSharpFundamentals/05-ControlFlow", Description = "If statements, switch cases, and conditional logic", Category = "C# Fundamentals" },
            new() { Title = "Loops", Url = "/CSharpFundamentals/06-Loops", Description = "For, while, do-while, and foreach loops", Category = "C# Fundamentals" },
            new() { Title = "Arrays and Collections", Url = "/CSharpFundamentals/07-ArraysAndCollections", Description = "Arrays, lists, dictionaries, and collections", Category = "C# Fundamentals" },
            new() { Title = "Strings", Url = "/CSharpFundamentals/08-Strings", Description = "String manipulation and formatting", Category = "C# Fundamentals" },
            new() { Title = "Exception Handling", Url = "/CSharpFundamentals/09-ExceptionHandling", Description = "Try-catch-finally and error handling", Category = "C# Fundamentals" },
            new() { Title = "Methods Basics", Url = "/CSharpFundamentals/10-MethodsBasics", Description = "Create and use methods in C#", Category = "C# Fundamentals" },
            new() { Title = "Pattern Matching & Nullables", Url = "/CSharpFundamentals/11-PatternMatchingAndNullables", Description = "Pattern matching and nullable types", Category = "C# Fundamentals" },
            new() { Title = "LINQ Introduction", Url = "/CSharpFundamentals/12-LinqIntroduction", Description = "Language Integrated Query for data manipulation", Category = "C# Fundamentals" },
            new() { Title = "Delegates, Events & Async", Url = "/CSharpFundamentals/13-DelegatesEventsAsync", Description = "Delegates, events, and async/await", Category = "C# Fundamentals" },

            // Console Applications
            new() { Title = "Creating Console App", Url = "/ConsoleApp/01-CreatingConsoleApp", Description = "Create your first console application", Category = "Console Applications" },
            new() { Title = "Input and Output", Url = "/ConsoleApp/02-InputOutput", Description = "Console input/output operations", Category = "Console Applications" },
            new() { Title = "Calculator Project", Url = "/ConsoleApp/03-CalculatorProject", Description = "Build a calculator application", Category = "Console Applications" },
            new() { Title = "File Handling", Url = "/ConsoleApp/04-FileHandling", Description = "Read and write files in C#", Category = "Console Applications" },

            // Classes & OOP
            new() { Title = "What Is A Class", Url = "/ClassesAndOOP/01-WhatIsAClass", Description = "Understanding classes and objects", Category = "Classes & OOP" },
            new() { Title = "Fields and Properties", Url = "/ClassesAndOOP/02-FieldsAndProperties", Description = "Fields, properties, and encapsulation", Category = "Classes & OOP" },
            new() { Title = "Methods Deep Dive", Url = "/ClassesAndOOP/03-MethodsDeepDive", Description = "Methods, parameters, and overloading", Category = "Classes & OOP" },
            new() { Title = "Constructors", Url = "/ClassesAndOOP/04-Constructors", Description = "Constructors and object initialization", Category = "Classes & OOP" },
            new() { Title = "Encapsulation", Url = "/ClassesAndOOP/05-Encapsulation", Description = "Encapsulation and access modifiers", Category = "Classes & OOP" },
            new() { Title = "Inheritance", Url = "/ClassesAndOOP/06-Inheritance", Description = "Inheritance and derived classes", Category = "Classes & OOP" },
            new() { Title = "Polymorphism", Url = "/ClassesAndOOP/07-Polymorphism", Description = "Polymorphism and virtual methods", Category = "Classes & OOP" },
            new() { Title = "Abstraction & Interfaces", Url = "/ClassesAndOOP/08-AbstractionInterfaces", Description = "Abstract classes and interfaces", Category = "Classes & OOP" },
            new() { Title = "Static vs Instance", Url = "/ClassesAndOOP/09-StaticVsInstance", Description = "Static vs instance members", Category = "Classes & OOP" },
            new() { Title = "Generics", Url = "/ClassesAndOOP/10-Generics", Description = "Generics and type parameters", Category = "Classes & OOP" },
            new() { Title = "SOLID Principles", Url = "/ClassesAndOOP/11-SolidPrinciples", Description = "SOLID design principles", Category = "Classes & OOP" },

            // Getting Started
            new() { Title = "Installing Visual Studio", Url = "/GettingStarted/01-InstallingVisualStudio", Description = "Download and install Visual Studio", Category = "Getting Started" },
            new() { Title = "Choosing the Right Workloads", Url = "/GettingStarted/02-WorkloadsToSelect", Description = "Select the right Visual Studio workloads", Category = "Getting Started" },
            new() { Title = "Installing SQL Server Express & SSMS", Url = "/GettingStarted/03-InstallingSqlExpressSsms", Description = "Install SQL Server and SSMS", Category = "Getting Started" },
            new() { Title = "Installing Git", Url = "/GettingStarted/04-InstallingGit", Description = "Install and configure Git", Category = "Getting Started" },

            // Security
            new() { Title = "HTTPS and Certificates", Url = "/Security/01-HttpsAndCertificates", Description = "HTTPS and SSL certificates", Category = "Security" },
            new() { Title = "Authentication & Identity", Url = "/Security/02-AuthenticationIdentity", Description = "ASP.NET Core Identity", Category = "Security" },
            new() { Title = "SQL Injection Prevention", Url = "/Security/03-SqlInjectionPrevention", Description = "Prevent SQL injection attacks", Category = "Security" },
            new() { Title = "XSS & CSRF Protection", Url = "/Security/04-XssCsrfProtection", Description = "XSS and CSRF protection", Category = "Security" },
            new() { Title = "Security Headers", Url = "/Security/05-SecurityHeaders", Description = "Security headers and best practices", Category = "Security" },
            new() { Title = "Secrets Management", Url = "/Security/06-SecretsManagement", Description = "Manage secrets and sensitive data", Category = "Security" },

            // Windows Forms
            new() { Title = "Creating WinForms Project", Url = "/WindowsForms/01-CreatingWinFormsProject", Description = "Create your first Windows Forms project", Category = "Windows Forms" },
            new() { Title = "Controls Basics", Url = "/WindowsForms/02-ControlsBasics", Description = "WinForms controls basics", Category = "Windows Forms" },
            new() { Title = "Event Handling", Url = "/WindowsForms/03-EventHandling", Description = "Event handling in WinForms", Category = "Windows Forms" },
            new() { Title = "Menus & Dialogs", Url = "/WindowsForms/04-MenusAndDialogs", Description = "Menus and dialogs in WinForms", Category = "Windows Forms" },
            new() { Title = "Data Binding", Url = "/WindowsForms/05-DataBinding", Description = "Data binding in WinForms", Category = "Windows Forms" },
            new() { Title = "Multi-Form Applications", Url = "/WindowsForms/06-MultiFormApps", Description = "Multi-form applications", Category = "Windows Forms" },
            new() { Title = "Full CRUD Project Walkthrough", Url = "/WindowsForms/07-CrudProjectWalkthrough", Description = "Complete CRUD project", Category = "Windows Forms" }
        };

        // Search in titles and descriptions
        var searchTerm = query.ToLowerInvariant();
        results = pages
            .Where(p => p.Title.ToLowerInvariant().Contains(searchTerm) ||
                        p.Description.ToLowerInvariant().Contains(searchTerm) ||
                        p.Category.ToLowerInvariant().Contains(searchTerm))
            .ToList();

        return results;
    }
}

public class SearchResult
{
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}