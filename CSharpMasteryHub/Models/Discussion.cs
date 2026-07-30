namespace CSharpMasteryHub.Models;

public class Discussion
{
    public int Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Lesson { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public int ViewCount { get; set; }
    public int ReplyCount { get; set; }
    public bool IsPinned { get; set; }
    public List<DiscussionReply> Replies { get; set; } = new();
}

public class DiscussionReply
{
    public int Id { get; set; }
    public int DiscussionId { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
}