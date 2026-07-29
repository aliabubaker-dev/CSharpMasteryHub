using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.VsSqlConnection;

public class EntityFrameworkCoreIntroModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "Connection Strings", Url = "/VsSqlConnection/01-ConnectionStrings", IsActive = false },
            new() { Title = "ADO.NET Basics", Url = "/VsSqlConnection/02-AdoNetBasics", IsActive = false },
            new() { Title = "Insert / Delete / Update — Full Example", Url = "/VsSqlConnection/03-InsertDeleteUpdateExample", IsActive = false },
            new() { Title = "DataReader vs DataAdapter", Url = "/VsSqlConnection/04-DataReaderVsDataAdapter", IsActive = false },
            new() { Title = "Entity Framework Core (Intro)", Url = "/VsSqlConnection/05-EntityFrameworkCoreIntro", IsActive = true }
        };
    }
}