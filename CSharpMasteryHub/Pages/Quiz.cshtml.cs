using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;
using CSharpMasteryHub.Services;
using Microsoft.Extensions.Logging;

namespace CSharpMasteryHub.Pages;

public class QuizModel : PageModel
{
    private readonly QuizService _quizService;
    private readonly ILogger<QuizModel> _logger;

    public QuizModel(QuizService quizService, ILogger<QuizModel> logger)
    {
        _quizService = quizService;
        _logger = logger;
    }

    [BindProperty(SupportsGet = true)]
    public string Topic { get; set; } = string.Empty;

    public List<QuizQuestion> Questions { get; set; } = new();

    [BindProperty]
    public List<int> Answers { get; set; } = new();

    public QuizResult Result { get; set; } = new();

    public bool IsSubmitted { get; set; }

    public void OnGet()
    {
        try
        {
            _logger.LogInformation($"Quiz OnGet called with Topic: {Topic}");

            // If no topic is provided, default to CSharpFundamentals
            if (string.IsNullOrEmpty(Topic))
            {
                Topic = "CSharpFundamentals";
                _logger.LogInformation($"No topic provided, defaulting to: {Topic}");
            }

            // Load questions from the service
            Questions = _quizService.GetQuizQuestions(Topic);

            // Initialize answers array with default values (-1 means not answered)
            Answers = new List<int>(new int[Questions.Count]);

            _logger.LogInformation($"Loaded {Questions.Count} questions for topic: {Topic}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error loading quiz for topic: {Topic}");
            // Set fallback data so the page doesn't crash
            Questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Id = 1,
                    Topic = Topic,
                    Question = "Unable to load quiz questions. Please try again.",
                    Options = new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" },
                    CorrectAnswer = 0,
                    Explanation = "There was an error loading the quiz. Please refresh the page or try again later."
                }
            };
            Answers = new List<int>(new int[Questions.Count]);
        }
    }

    public IActionResult OnPost()
    {
        try
        {
            _logger.LogInformation($"Quiz OnPost called with Topic: {Topic}");

            // Ensure we have a topic
            if (string.IsNullOrEmpty(Topic))
            {
                Topic = "CSharpFundamentals";
                _logger.LogInformation($"No topic provided in POST, defaulting to: {Topic}");
            }

            // Get questions for the topic
            Questions = _quizService.GetQuizQuestions(Topic);

            // Ensure answers match question count
            while (Answers.Count < Questions.Count)
            {
                Answers.Add(-1);
            }

            // Trim extra answers if there are too many
            if (Answers.Count > Questions.Count)
            {
                Answers = Answers.Take(Questions.Count).ToList();
            }

            // Evaluate the quiz
            Result = _quizService.EvaluateQuiz(Questions, Answers);
            IsSubmitted = true;

            _logger.LogInformation($"Quiz completed. Score: {Result.Score}%, Correct: {Result.CorrectAnswers}/{Result.TotalQuestions}");

            return Page();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error evaluating quiz for topic: {Topic}");

            // Set fallback data so the page doesn't crash
            Questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Id = 1,
                    Topic = Topic,
                    Question = "Error evaluating quiz. Please try again.",
                    Options = new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" },
                    CorrectAnswer = 0,
                    Explanation = "There was an error evaluating your answers. Please try again."
                }
            };
            Answers = new List<int>(new int[Questions.Count]);
            Result = new QuizResult
            {
                TotalQuestions = 1,
                CorrectAnswers = 0,
                Score = 0,
                Grade = "Error - Please try again",
                AnswerDetails = new List<QuizAnswerResult>()
            };
            IsSubmitted = true;

            return Page();
        }
    }
}