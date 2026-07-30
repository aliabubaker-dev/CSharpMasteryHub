namespace CSharpMasteryHub.Models;

public class CodeChallenge
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Difficulty { get; set; } = string.Empty; // Beginner, Intermediate, Advanced
    public string Topic { get; set; } = string.Empty; // CSharpFundamentals, ClassesAndOOP, etc.
    public string CodeSnippet { get; set; } = string.Empty; // The starting code
    public string Solution { get; set; } = string.Empty; // The correct solution
    public string Explanation { get; set; } = string.Empty;
    public int Order { get; set; }
}

public class ChallengeAttempt
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public int ChallengeId { get; set; }
    public string UserCode { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }
    public DateTime AttemptDate { get; set; }
}