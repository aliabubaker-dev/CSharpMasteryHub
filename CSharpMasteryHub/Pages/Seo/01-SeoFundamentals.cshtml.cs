using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Pages.Seo;

public class SeoFundamentalsModel : PageModel
{
    public List<LessonNavItem> SidebarNav { get; set; } = new();

    public void OnGet()
    {
        SidebarNav = new List<LessonNavItem>
        {
            new() { Title = "SEO Fundamentals", Url = "/Seo/01-SeoFundamentals", IsActive = true },
            new() { Title = "Meta Tags, Title & Description", Url = "/Seo/02-MetaTagsTitleDescription", IsActive = false },
            new() { Title = "Sitemap and Robots.txt", Url = "/Seo/03-SitemapAndRobotsTxt", IsActive = false },
            new() { Title = "Semantic HTML & Headings", Url = "/Seo/04-SemanticHtmlHeadings", IsActive = false },
            new() { Title = "Page Speed & Core Web Vitals", Url = "/Seo/05-PageSpeedCoreWebVitals", IsActive = false },
            new() { Title = "Google Search Console", Url = "/Seo/06-GoogleSearchConsole", IsActive = false }
        };
    }
}