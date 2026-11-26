namespace CSharpMasteryHub.Services;

public class NewsletterService
{
    private readonly string _filePath;
    private readonly ILogger<NewsletterService> _logger;
    private static readonly SemaphoreSlim _lock = new(1, 1);

    public NewsletterService(IWebHostEnvironment env, ILogger<NewsletterService> logger)
    {
        _logger = logger;
        var dataDir = Path.Combine(env.ContentRootPath, "App_Data");
        Directory.CreateDirectory(dataDir);
        _filePath = Path.Combine(dataDir, "subscribers.txt");
    }

    public async Task<bool> SubscribeAsync(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        await _lock.WaitAsync();
        try
        {
            // Check if already subscribed
            if (File.Exists(_filePath))
            {
                var lines = await File.ReadAllLinesAsync(_filePath);
                if (lines.Any(l => l.Split('|')[0].Equals(email, StringComparison.OrdinalIgnoreCase)))
                {
                    _logger.LogInformation("Email already subscribed: {Email}", email);
                    return true; // Already exists — treat as success
                }
            }

            var entry = $"{email}|{DateTime.UtcNow:O}{Environment.NewLine}";
            await File.AppendAllTextAsync(_filePath, entry);
            _logger.LogInformation("New subscriber: {Email}", email);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to save subscriber {Email}", email);
            return false;
        }
        finally
        {
            _lock.Release();
        }
    }

    public async Task<List<string>> GetAllSubscribersAsync()
    {
        if (!File.Exists(_filePath))
            return new List<string>();

        var lines = await File.ReadAllLinesAsync(_filePath);
        return lines
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .Select(l => l.Split('|')[0])
            .ToList();
    }
}