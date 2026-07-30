namespace CSharpMasteryHub.Models;

public class QuizQuestion
{
    public int Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Question { get; set; } = string.Empty;
    public List<string> Options { get; set; } = new();
    public int CorrectAnswer { get; set; } // Index of correct answer (0-based)
    public string Explanation { get; set; } = string.Empty;
}

public class QuizResult
{
    public int TotalQuestions { get; set; }
    public int CorrectAnswers { get; set; }
    public int Score { get; set; } // Percentage
    public string Grade { get; set; } = string.Empty;
    public List<QuizAnswerResult> AnswerDetails { get; set; } = new();
}

public class QuizAnswerResult
{
    public int QuestionId { get; set; }
    public string Question { get; set; } = string.Empty;
    public int UserAnswer { get; set; }
    public int CorrectAnswer { get; set; }
    public bool IsCorrect { get; set; }
    public string Explanation { get; set; } = string.Empty;
}