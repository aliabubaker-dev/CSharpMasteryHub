using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Services;

public class DiscussionService
{
    private static List<Discussion> _discussions = new();
    private static int _discussionIdCounter = 1;
    private static int _replyIdCounter = 1;

    public DiscussionService()
    {
        // Seed with sample discussions
        if (!_discussions.Any())
        {
            SeedDiscussions();
        }
    }

    private void SeedDiscussions()
    {


        // ===== ADDITIONAL DISCUSSIONS =====

        // ===== DEPLOYMENT DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "Deployment",
            Lesson = "Preparing for Deployment",
            Title = "What's the best free hosting for ASP.NET Core?",
            Content = "I want to deploy my first ASP.NET Core app for free. Which platform would you recommend between Azure Free Tier, Heroku, and Render?",
            AuthorName = "Michael Chen",
            CreatedDate = DateTime.Now.AddDays(-4),
            ViewCount = 67,
            ReplyCount = 2,
            IsPinned = false,
            Replies = new List<DiscussionReply>
    {
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 12,
            AuthorName = "Sarah Ahmed",
            Content = "Azure Free Tier is great if you're already in the Microsoft ecosystem. Render is simpler for beginners. Heroku is also good but the app sleeps after inactivity.",
            CreatedDate = DateTime.Now.AddDays(-3)
        },
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 12,
            AuthorName = "Ali Abubaker (Author)",
            Content = "I recommend Azure Free Tier because it's what we cover in the Deployment module. Plus you get 12 months of free services!",
            CreatedDate = DateTime.Now.AddDays(-2)
        }
    }
        });

        // ===== EXTRA TOPICS - GIT DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ExtraTopics",
            Lesson = "Git & GitHub",
            Title = "Merge conflicts are scaring me! Any tips?",
            Content = "I'm terrified of merge conflicts. What's the best way to handle them and avoid them in the first place?",
            AuthorName = "Emma Wilson",
            CreatedDate = DateTime.Now.AddDays(-5),
            ViewCount = 34,
            ReplyCount = 1,
            IsPinned = false,
            Replies = new List<DiscussionReply>
    {
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 13,
            AuthorName = "John Doe",
            Content = "Don't be scared! Pull changes frequently, keep branches short-lived, and use git status to see what's happening. Conflicts are normal!",
            CreatedDate = DateTime.Now.AddDays(-4)
        }
    }
        });

        // ===== EXTRA TOPICS - DESIGN PATTERNS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ExtraTopics",
            Lesson = "Design Patterns",
            Title = "I'm confused about the Repository pattern",
            Content = "I keep hearing about the Repository pattern but I'm not sure I understand it. When should I use it and when is it overkill?",
            AuthorName = "David Park",
            CreatedDate = DateTime.Now.AddDays(-3),
            ViewCount = 22,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== PROJECT WORKFLOW DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ProjectWorkflow",
            Lesson = "Understanding Requirements",
            Title = "How do you handle scope creep from clients?",
            Content = "My clients keep adding features after we start development. How do you manage scope creep without damaging the relationship?",
            AuthorName = "Lisa Thompson",
            CreatedDate = DateTime.Now.AddDays(-6),
            ViewCount = 41,
            ReplyCount = 3,
            IsPinned = true,
            Replies = new List<DiscussionReply>
    {
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 15,
            AuthorName = "Mike Johnson",
            Content = "The key is to have a clear contract and change request process. Always document what's in scope and what's out of scope.",
            CreatedDate = DateTime.Now.AddDays(-5)
        },
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 15,
            AuthorName = "Sarah Ahmed",
            Content = "I agree with Mike. Also, be open to changes but make sure to communicate the impact on timeline and budget.",
            CreatedDate = DateTime.Now.AddDays(-4)
        },
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 15,
            AuthorName = "Ali Abubaker (Author)",
            Content = "Great advice! Also, use agile methodology - it's designed to handle changing requirements. Just make sure changes go through the backlog.",
            CreatedDate = DateTime.Now.AddDays(-3)
        }
    }
        });

        // ===== PROJECT WORKFLOW - GIT BRANCHING =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ProjectWorkflow",
            Lesson = "Git Branching Strategy",
            Title = "Git Flow vs GitHub Flow - which one should I use?",
            Content = "I'm starting a new project and I'm not sure which branching strategy to adopt. What do you recommend?",
            AuthorName = "Alex Rivera",
            CreatedDate = DateTime.Now.AddDays(-2),
            ViewCount = 19,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== GETTING STARTED DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "GettingStarted",
            Lesson = "Installing Visual Studio",
            Title = "Visual Studio is taking too much disk space!",
            Content = "Visual Studio is eating up my SSD space. What components can I safely remove without breaking my development environment?",
            AuthorName = "Tom Davis",
            CreatedDate = DateTime.Now.AddDays(-3),
            ViewCount = 28,
            ReplyCount = 1,
            IsPinned = false,
            Replies = new List<DiscussionReply>
    {
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 17,
            AuthorName = "Ali Abubaker (Author)",
            Content = "You can uninstall workloads you don't use! Keep ASP.NET and web development, .NET desktop development, and .NET MAUI. Remove others like Azure, Python, etc.",
            CreatedDate = DateTime.Now.AddDays(-2)
        }
    }
        });

        // ===== RDLC REPORTS DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "RdlcReports",
            Lesson = "What Is RDLC",
            Title = "RDLC vs Crystal Reports - which one is better?",
            Content = "I've used Crystal Reports before. How does RDLC compare? Should I learn RDLC?",
            AuthorName = "James Wilson",
            CreatedDate = DateTime.Now.AddDays(-4),
            ViewCount = 15,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== SEO DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "Seo",
            Lesson = "SEO Fundamentals",
            Title = "My site is not showing on Google. Help!",
            Content = "I launched my website 2 weeks ago but it's not showing up on Google. What am I doing wrong?",
            AuthorName = "Maria Santos",
            CreatedDate = DateTime.Now.AddDays(-5),
            ViewCount = 33,
            ReplyCount = 2,
            IsPinned = false,
            Replies = new List<DiscussionReply>
    {
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 19,
            AuthorName = "Sarah Ahmed",
            Content = "Have you submitted your sitemap to Google Search Console? That's usually the first step.",
            CreatedDate = DateTime.Now.AddDays(-4)
        },
        new DiscussionReply
        {
            Id = _replyIdCounter++,
            DiscussionId = 19,
            AuthorName = "Ali Abubaker (Author)",
            Content = "Don't worry! It can take 4-6 weeks for Google to index new sites. In the meantime, make sure you have good content, meta tags, and a sitemap.",
            CreatedDate = DateTime.Now.AddDays(-3)
        }
    }
        });

        // ===== SECURITY - SECRETS MANAGEMENT =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "Security",
            Lesson = "Secrets Management",
            Title = "I accidentally pushed my connection string to GitHub! 😱",
            Content = "I made a mistake and pushed my connection string with password to GitHub. What should I do now?",
            AuthorName = "Rachel Lee",
            CreatedDate = DateTime.Now.AddDays(-1),
            ViewCount = 12,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== VS SQL CONNECTION DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "VsSqlConnection",
            Lesson = "ADO.NET Basics",
            Title = "SqlDataReader vs SqlDataAdapter - when to use what?",
            Content = "I'm confused about when to use SqlDataReader and when to use SqlDataAdapter. Can someone explain the difference with examples?",
            AuthorName = "Mark Johnson",
            CreatedDate = DateTime.Now.AddDays(-3),
            ViewCount = 18,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });
        // ===== CLASSES & OOP DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ClassesAndOOP",
            Lesson = "What Is A Class",
            Title = "Understanding Classes vs Objects",
            Content = "I'm still confused about the difference between a class and an object. Can someone explain with a simple example?",
            AuthorName = "John Doe",
            CreatedDate = DateTime.Now.AddDays(-5),
            ViewCount = 45,
            ReplyCount = 3,
            IsPinned = true,
            Replies = new List<DiscussionReply>
            {
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 1,
                    AuthorName = "Ali Abubaker (Author)",
                    Content = "Great question! Think of a class as a blueprint and an object as the actual house built from that blueprint. The class defines what properties and methods exist, and the object is the concrete instance with actual values.",
                    CreatedDate = DateTime.Now.AddDays(-4)
                },
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 1,
                    AuthorName = "Jane Smith",
                    Content = "That's a great analogy! So the 'new' keyword is like building the house?",
                    CreatedDate = DateTime.Now.AddDays(-3)
                },
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 1,
                    AuthorName = "Ali Abubaker (Author)",
                    Content = "Exactly! 'new Person()' creates a new instance of the Person class - it's like building a new house from the blueprint.",
                    CreatedDate = DateTime.Now.AddDays(-2)
                }
            }
        });

        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ClassesAndOOP",
            Lesson = "Fields and Properties",
            Title = "When to use public fields vs properties?",
            Content = "I see some code uses public fields and others use properties. What's the difference and when should I use each?",
            AuthorName = "Mike Johnson",
            CreatedDate = DateTime.Now.AddDays(-3),
            ViewCount = 28,
            ReplyCount = 2,
            IsPinned = false,
            Replies = new List<DiscussionReply>
            {
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 2,
                    AuthorName = "Sarah Ahmed",
                    Content = "Properties are preferred because they allow you to add validation later without breaking existing code. Public fields don't give you that flexibility.",
                    CreatedDate = DateTime.Now.AddDays(-2)
                },
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 2,
                    AuthorName = "Ali Abubaker (Author)",
                    Content = "Sarah is right! Always use properties for public data. They also support features like data binding in WPF and WinForms.",
                    CreatedDate = DateTime.Now.AddDays(-1)
                }
            }
        });

        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ClassesAndOOP",
            Lesson = "Inheritance",
            Title = "Multiple inheritance in C# - why not?",
            Content = "Why doesn't C# support multiple inheritance like C++? I want to inherit from two classes at once.",
            AuthorName = "Alex Chen",
            CreatedDate = DateTime.Now.AddDays(-1),
            ViewCount = 15,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== C# FUNDAMENTALS DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "CSharpFundamentals",
            Lesson = "Variables and Data Types",
            Title = "When to use 'var' vs explicit types?",
            Content = "I see people using 'var' everywhere. When should I use 'var' and when should I use explicit types?",
            AuthorName = "Sarah Ahmed",
            CreatedDate = DateTime.Now.AddDays(-2),
            ViewCount = 32,
            ReplyCount = 2,
            IsPinned = false,
            Replies = new List<DiscussionReply>
            {
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 4,
                    AuthorName = "John Doe",
                    Content = "Use 'var' when the type is obvious from the right side (like 'var x = 5'). Use explicit types when it's not clear or for public APIs.",
                    CreatedDate = DateTime.Now.AddDays(-1)
                },
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 4,
                    AuthorName = "Ali Abubaker (Author)",
                    Content = "Good answer! I also use explicit types for fields and return types to make the code self-documenting.",
                    CreatedDate = DateTime.Now.AddDays(-1)
                }
            }
        });

        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "CSharpFundamentals",
            Lesson = "Loops",
            Title = "Which loop is fastest? For vs Foreach",
            Content = "I heard that 'for' loops are faster than 'foreach' loops. Is that true and should I care?",
            AuthorName = "David Wilson",
            CreatedDate = DateTime.Now.AddDays(-4),
            ViewCount = 18,
            ReplyCount = 1,
            IsPinned = false,
            Replies = new List<DiscussionReply>
            {
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 5,
                    AuthorName = "Mike Johnson",
                    Content = "In most cases the difference is negligible. Use foreach for readability unless you're dealing with performance-critical code.",
                    CreatedDate = DateTime.Now.AddDays(-3)
                }
            }
        });

        // ===== CONSOLE APP DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "ConsoleApp",
            Lesson = "Input and Output",
            Title = "How to read passwords without showing characters?",
            Content = "Is there a way to read user input without showing the characters on screen? Like for password input?",
            AuthorName = "Emily Brown",
            CreatedDate = DateTime.Now.AddDays(-6),
            ViewCount = 22,
            ReplyCount = 1,
            IsPinned = false,
            Replies = new List<DiscussionReply>
            {
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 6,
                    AuthorName = "Ali Abubaker (Author)",
                    Content = "Yes! Use Console.ReadKey(true) where true hides the character. You'll need to manually build the password string.",
                    CreatedDate = DateTime.Now.AddDays(-5)
                }
            }
        });

        // ===== WINDOWS FORMS DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "WindowsForms",
            Lesson = "Controls Basics",
            Title = "Best practices for form design?",
            Content = "What are some best practices for designing user-friendly Windows Forms? I want my app to look professional.",
            AuthorName = "Lisa Park",
            CreatedDate = DateTime.Now.AddDays(-3),
            ViewCount = 14,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== SQL SERVER DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "SqlServer",
            Lesson = "SELECT, WHERE, ORDER BY",
            Title = "How to handle NULL values in SQL?",
            Content = "I'm getting unexpected results when working with NULL values. How should I handle them properly?",
            AuthorName = "Robert Kim",
            CreatedDate = DateTime.Now.AddDays(-2),
            ViewCount = 9,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== ASP.NET CORE DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "RazorPages",
            Lesson = "MVC vs Razor Pages",
            Title = "Should I learn MVC or Razor Pages first?",
            Content = "I'm new to ASP.NET Core. Should I start with MVC or Razor Pages? What's the difference?",
            AuthorName = "Tom Anderson",
            CreatedDate = DateTime.Now.AddDays(-7),
            ViewCount = 56,
            ReplyCount = 3,
            IsPinned = true,
            Replies = new List<DiscussionReply>
            {
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 9,
                    AuthorName = "Sarah Ahmed",
                    Content = "I recommend starting with Razor Pages. It's simpler and more intuitive for beginners.",
                    CreatedDate = DateTime.Now.AddDays(-6)
                },
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 9,
                    AuthorName = "John Doe",
                    Content = "Learn both! They use the same concepts but organized differently. Start with Razor Pages then move to MVC.",
                    CreatedDate = DateTime.Now.AddDays(-5)
                },
                new DiscussionReply
                {
                    Id = _replyIdCounter++,
                    DiscussionId = 9,
                    AuthorName = "Ali Abubaker (Author)",
                    Content = "Great question! Razor Pages is great for page-focused apps. MVC is better for complex apps with lots of controllers. Start with Razor Pages!",
                    CreatedDate = DateTime.Now.AddDays(-4)
                }
            }
        });

        // ===== .NET MAUI DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "DotNetMaui",
            Lesson = "What Is MAUI",
            Title = "Xamarin.Forms vs .NET MAUI - should I migrate?",
            Content = "I have a Xamarin.Forms app. Should I migrate to .NET MAUI? What are the benefits?",
            AuthorName = "Carlos Garcia",
            CreatedDate = DateTime.Now.AddDays(-1),
            ViewCount = 7,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });

        // ===== SECURITY DISCUSSIONS =====
        _discussions.Add(new Discussion
        {
            Id = _discussionIdCounter++,
            Topic = "Security",
            Lesson = "SQL Injection Prevention",
            Title = "Is EF Core 100% safe from SQL injection?",
            Content = "I use Entity Framework Core. Does it fully protect me from SQL injection attacks?",
            AuthorName = "Anna Martinez",
            CreatedDate = DateTime.Now.AddDays(-2),
            ViewCount = 11,
            ReplyCount = 0,
            IsPinned = false,
            Replies = new List<DiscussionReply>()
        });
    }

    public List<Discussion> GetDiscussionsForTopic(string topic)
    {
        return _discussions
            .Where(d => d.Topic == topic)
            .OrderByDescending(d => d.IsPinned)
            .ThenByDescending(d => d.CreatedDate)
            .ToList();
    }

    public Discussion? GetDiscussionById(int id)
    {
        var discussion = _discussions.FirstOrDefault(d => d.Id == id);
        if (discussion != null)
        {
            discussion.ViewCount++;
        }
        return discussion;
    }

    public void AddDiscussion(Discussion discussion)
    {
        discussion.Id = _discussionIdCounter++;
        discussion.CreatedDate = DateTime.Now;
        discussion.ReplyCount = 0;
        discussion.ViewCount = 0;
        discussion.Replies = new List<DiscussionReply>();
        _discussions.Add(discussion);
    }

    public void AddReply(int discussionId, DiscussionReply reply)
    {
        var discussion = _discussions.FirstOrDefault(d => d.Id == discussionId);
        if (discussion != null)
        {
            reply.Id = _replyIdCounter++;
            reply.DiscussionId = discussionId;
            reply.CreatedDate = DateTime.Now;
            discussion.Replies.Add(reply);
            discussion.ReplyCount = discussion.Replies.Count;
        }
    }
}