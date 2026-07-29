using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.SqlServer;

public class IndexesPerformanceModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "SSMS Interface Tour", Url = "/SqlServer/01-InstallingSqlServerSsms", IsActive = false },
            new() { Title = "Databases and Tables", Url = "/SqlServer/02-DatabasesAndTables", IsActive = false },
            new() { Title = "Data Types & Constraints", Url = "/SqlServer/03-DataTypesConstraints", IsActive = false },
            new() { Title = "SELECT, WHERE, ORDER BY", Url = "/SqlServer/04-SelectWhereOrderBy", IsActive = false },
            new() { Title = "Joins", Url = "/SqlServer/05-Joins", IsActive = false },
            new() { Title = "INSERT, UPDATE, DELETE", Url = "/SqlServer/06-InsertUpdateDelete", IsActive = false },
            new() { Title = "Stored Procedures", Url = "/SqlServer/07-StoredProcedures", IsActive = false },
            new() { Title = "Functions & Views", Url = "/SqlServer/08-FunctionsAndViews", IsActive = false },
            new() { Title = "Indexes & Performance", Url = "/SqlServer/09-IndexesPerformance", IsActive = true },
            new() { Title = "Transactions", Url = "/SqlServer/10-Transactions", IsActive = false }
        };
    }
}