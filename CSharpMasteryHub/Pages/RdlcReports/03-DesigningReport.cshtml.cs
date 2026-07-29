using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.RdlcReports;

public class DesigningReportModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "What Is RDLC", Url = "/RdlcReports/01-WhatIsRdlc", IsActive = false },
            new() { Title = "Creating Dataset", Url = "/RdlcReports/02-CreatingDataset", IsActive = false },
            new() { Title = "Designing Report", Url = "/RdlcReports/03-DesigningReport", IsActive = true },
            new() { Title = "Binding Report to Form", Url = "/RdlcReports/04-BindingReportToForm", IsActive = false },
            new() { Title = "Full Report Project with SQL", Url = "/RdlcReports/05-FullReportProjectWithSql", IsActive = false }
        };
    }
}