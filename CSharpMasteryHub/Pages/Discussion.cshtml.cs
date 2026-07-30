using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;
using CSharpMasteryHub.Services;

namespace CSharpMasteryHub.Pages;

public class DiscussionModel : PageModel
{
    private readonly DiscussionService _discussionService;

    public DiscussionModel(DiscussionService discussionService)
    {
        _discussionService = discussionService;
    }

    [BindProperty(SupportsGet = true)]
    public string Topic { get; set; } = string.Empty;

    [BindProperty(SupportsGet = true)]
    public int? Id { get; set; }

    public List<Discussion> Discussions { get; set; } = new();
    public Discussion? CurrentDiscussion { get; set; }

    [BindProperty]
    public Discussion NewDiscussion { get; set; } = new();

    [BindProperty]
    public DiscussionReply NewReply { get; set; } = new();

    public bool IsNewDiscussion { get; set; }

    public void OnGet()
    {
        if (Id.HasValue)
        {
            // Show specific discussion
            CurrentDiscussion = _discussionService.GetDiscussionById(Id.Value);
        }
        else if (!string.IsNullOrEmpty(Topic))
        {
            // Show all discussions for topic
            Discussions = _discussionService.GetDiscussionsForTopic(Topic);
        }
    }

    public IActionResult OnPostNewDiscussion()
    {
        if (!string.IsNullOrEmpty(Topic))
        {
            NewDiscussion.Topic = Topic;
            _discussionService.AddDiscussion(NewDiscussion);
            return RedirectToPage("/Discussion", new { Topic });
        }
        return Page();
    }

    public IActionResult OnPostReply()
    {
        if (Id.HasValue && !string.IsNullOrEmpty(NewReply.Content))
        {
            _discussionService.AddReply(Id.Value, NewReply);
            return RedirectToPage("/Discussion", new { Id });
        }
        return Page();
    }
}