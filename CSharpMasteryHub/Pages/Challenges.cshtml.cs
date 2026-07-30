using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;
using CSharpMasteryHub.Services;

namespace CSharpMasteryHub.Pages;

public class ChallengesModel : PageModel
{
    private readonly ChallengeService _challengeService;

    public ChallengesModel(ChallengeService challengeService)
    {
        _challengeService = challengeService;
    }

    [BindProperty(SupportsGet = true)]
    public string? Topic { get; set; }

    [BindProperty(SupportsGet = true)]
    public int? Id { get; set; }

    public List<CodeChallenge> AllChallenges { get; set; } = new();
    public List<CodeChallenge> FilteredChallenges { get; set; } = new();
    public CodeChallenge? CurrentChallenge { get; set; }
    public List<string> AllTopics { get; set; } = new();
    public string? SelectedTopic { get; set; }

    [BindProperty]
    public string UserCode { get; set; } = string.Empty;

    public bool IsSubmitted { get; set; }
    public bool IsCorrect { get; set; }
    public string ResultMessage { get; set; } = string.Empty;

    public void OnGet()
    {
        // Load all data
        AllTopics = _challengeService.GetAllTopics();
        AllChallenges = _challengeService.GetAllChallenges();

        // If ID is provided, show single challenge
        if (Id.HasValue)
        {
            CurrentChallenge = _challengeService.GetChallengeById(Id.Value);
            if (CurrentChallenge != null)
            {
                UserCode = CurrentChallenge.CodeSnippet;
                SelectedTopic = CurrentChallenge.Topic;
            }
            return;
        }

        // Filter by topic or show all
        if (!string.IsNullOrEmpty(Topic))
        {
            SelectedTopic = Topic;
            FilteredChallenges = _challengeService.GetChallengesForTopic(Topic);
        }
        else
        {
            FilteredChallenges = AllChallenges;
        }
    }

    public IActionResult OnPost()
    {
        if (!Id.HasValue)
        {
            return RedirectToPage("/Challenges");
        }

        CurrentChallenge = _challengeService.GetChallengeById(Id.Value);
        if (CurrentChallenge == null)
        {
            return NotFound();
        }

        IsSubmitted = true;
        IsCorrect = _challengeService.CheckSolution(CurrentChallenge, UserCode);

        ResultMessage = IsCorrect
            ? "✅ Excellent work! Your solution is correct!"
            : "❌ Not quite right. Review your code and try again!";

        return Page();
    }
}