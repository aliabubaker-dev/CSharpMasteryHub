using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;
using CSharpMasteryHub.Services;

namespace CSharpMasteryHub.Pages.WindowsForms.ToolboxMastery;

public class QuizModel : PageModel
{
    private readonly QuizService _quizService;

    public QuizModel(QuizService quizService)
    {
        _quizService = quizService;
    }

    [BindProperty]
    public string Topic { get; set; } = "WindowsForms_ToolboxMastery";

    [BindProperty]
    public List<int> Answers { get; set; } = new();

    public List<QuizQuestion> Questions { get; set; } = new();
    public QuizResult Result { get; set; } = new();
    public bool IsSubmitted { get; set; }

    public void OnGet()
    {
        Questions = _quizService.GetQuizQuestions(Topic);
        if (Questions.Count == 0)
        {
            Questions = GetDefaultQuestions();
        }
        IsSubmitted = false;
    }

    public IActionResult OnPost()
    {
        IsSubmitted = true;
        Questions = _quizService.GetQuizQuestions(Topic);
        if (Questions.Count == 0)
        {
            Questions = GetDefaultQuestions();
        }
        Result = _quizService.EvaluateQuiz(Questions, Answers);
        return Page();
    }

    private List<QuizQuestion> GetDefaultQuestions()
    {
        // Fallback questions if QuizService doesn't have them
        return new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = Topic,
                Question = "Which control is used to display static text?",
                Options = new List<string> { "TextBox", "Label", "Button", "Panel" },
                CorrectAnswer = 1,
                Explanation = "Label is used to display static text that the user cannot edit."
            },
            // ... more questions will be added in QuizService
        };
    }
}