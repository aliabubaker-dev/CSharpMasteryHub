using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Services;

public class SeoService
{
    private readonly Dictionary<string, SeoMetadata> _pageSeo = new();

    public SeoService()
    {
        // Home page
        _pageSeo["/"] = new SeoMetadata
        {
            Title = "C# Mastery Hub - Complete Free C# Learning Guide",
            Description = "Learn C# from beginner to master with our complete free guide.",
            Keywords = "C#, .NET Core, ASP.NET Core, learning C#"
        };

        // C# Fundamentals
        _pageSeo["/CSharpFundamentals"] = new SeoMetadata
        {
            Title = "C# Fundamentals - Learn C# from Scratch",
            Description = "Start your C# journey with fundamentals.",
            Keywords = "C# basics, C# fundamentals"
        };

        // Console App
        _pageSeo["/ConsoleApp"] = new SeoMetadata
        {
            Title = "Console Applications in C# - Complete Guide",
            Description = "Learn to build console applications.",
            Keywords = "C# console app"
        };

        // Classes and OOP
        _pageSeo["/ClassesAndOOP"] = new SeoMetadata
        {
            Title = "Object-Oriented Programming in C#",
            Description = "Master OOP in C# with classes, methods, inheritance.",
            Keywords = "C# OOP, classes in C#"
        };

        // Windows Forms
        _pageSeo["/WindowsForms"] = new SeoMetadata
        {
            Title = "Windows Forms Application Development in C#",
            Description = "Build desktop applications with Windows Forms.",
            Keywords = "C# Windows Forms"
        };

        // ASP.NET Core
        _pageSeo["/RazorPages"] = new SeoMetadata
        {
            Title = "ASP.NET Core Razor Pages - Web Application Development",
            Description = "Learn to build web applications with ASP.NET Core.",
            Keywords = "ASP.NET Core, Razor Pages"
        };

        // SQL Server
        _pageSeo["/SqlServer"] = new SeoMetadata
        {
            Title = "SQL Server Management - Complete Database Guide",
            Description = "Master SQL Server from installation to complex queries.",
            Keywords = "SQL Server, SSMS, database management"
        };

        // VS SQL Connection
        _pageSeo["/VsSqlConnection"] = new SeoMetadata
        {
            Title = "Connect SQL Server to Visual Studio - Complete Guide",
            Description = "Learn to connect SQL Server to Visual Studio projects.",
            Keywords = "SQL Server Visual Studio, ADO.NET"
        };

        // RDLC Reports
        _pageSeo["/RdlcReports"] = new SeoMetadata
        {
            Title = "RDLC Reports in Windows Forms - Complete Tutorial",
            Description = "Create professional reports with RDLC.",
            Keywords = "RDLC reports, Windows Forms reporting"
        };

        // MAUI
        _pageSeo["/DotNetMaui"] = new SeoMetadata
        {
            Title = ".NET MAUI - Cross-Platform App Development",
            Description = "Build cross-platform apps with .NET MAUI.",
            Keywords = ".NET MAUI, cross-platform development"
        };

        // Getting Started
        _pageSeo["/GettingStarted"] = new SeoMetadata
        {
            Title = "Getting Started with C# Development",
            Description = "Complete guide to installing Visual Studio, SQL Server, Git.",
            Keywords = "install Visual Studio, C# setup"
        };

        // Security
        _pageSeo["/Security"] = new SeoMetadata
        {
            Title = "Web Application Security in ASP.NET Core",
            Description = "Secure your web applications with HTTPS.",
            Keywords = "ASP.NET Core security, web application security"
        };

        // Deployment
        _pageSeo["/Deployment"] = new SeoMetadata
        {
            Title = "Deploy Your C# Projects for Free",
            Description = "Learn to deploy your ASP.NET Core applications for free.",
            Keywords = "free deployment, Azure deployment"
        };
    }

    public SeoMetadata GetSeoForPage(string path)
    {
        if (_pageSeo.TryGetValue(path, out var seo))
        {
            return seo;
        }

        // Dynamic pages - extract from URL
        var segments = path.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToList();
        if (segments.Count > 0)
        {
            var lastSegment = segments.Last();
            var title = lastSegment.Replace("-", " ");

            return new SeoMetadata
            {
                Title = $"{title} - C# Mastery Hub",
                Description = $"Learn about {title} in C#.",
                Keywords = $"C#, {title}, tutorial"
            };
        }

        return new SeoMetadata();
    }
}