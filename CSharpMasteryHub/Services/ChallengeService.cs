using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Services;

public class ChallengeService
{
    private readonly Dictionary<string, List<CodeChallenge>> _challenges = new();

    public ChallengeService()
    {
        InitializeChallenges();
    }

    private void InitializeChallenges()
    {
        // ============================================================
        // C# FUNDAMENTALS CHALLENGES
        // ============================================================
        _challenges["CSharpFundamentals"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 1,
                Title = "Hello World",
                Description = "Write a program that prints 'Hello, C# Mastery Hub!' to the console.",
                Difficulty = "Beginner",
                Topic = "CSharpFundamentals",
                CodeSnippet = "// Write your code below\n\n// Hint: Use Console.WriteLine()",
                Solution = "Console.WriteLine(\"Hello, C# Mastery Hub!\");",
                Explanation = "Console.WriteLine() is used to print text to the console.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 2,
                Title = "Add Two Numbers",
                Description = "Write a program that adds two numbers (5 and 3) and prints the result.",
                Difficulty = "Beginner",
                Topic = "CSharpFundamentals",
                CodeSnippet = "// Write your code below\n\n// Hint: int sum = 5 + 3;",
                Solution = "int sum = 5 + 3;\nConsole.WriteLine(sum);",
                Explanation = "You can use the + operator to add numbers and Console.WriteLine() to display the result.",
                Order = 2
            },
            new CodeChallenge
            {
                Id = 3,
                Title = "Check Even or Odd",
                Description = "Write a program that checks if a number (e.g., 7) is even or odd.",
                Difficulty = "Beginner",
                Topic = "CSharpFundamentals",
                CodeSnippet = "// Write your code below\n\n// Hint: Use the % (modulus) operator",
                Solution = "int number = 7;\nif (number % 2 == 0)\n{\n    Console.WriteLine(\"Even\");\n}\nelse\n{\n    Console.WriteLine(\"Odd\");\n}",
                Explanation = "The % operator gives the remainder. If number % 2 == 0, the number is even.",
                Order = 3
            },
            new CodeChallenge
            {
                Id = 4,
                Title = "Fix the Bug",
                Description = "The code below has a bug. Find and fix it so it prints 'Hello World!'",
                Difficulty = "Intermediate",
                Topic = "CSharpFundamentals",
                CodeSnippet = "// 🐛 Find the bug and fix it!\nstring message = \"Hello World\"\nConsole.WriteLine(message);",
                Solution = "string message = \"Hello World\";\nConsole.WriteLine(message);",
                Explanation = "The bug was a missing semicolon at the end of the line.",
                Order = 4
            },
            new CodeChallenge
            {
                Id = 12,
                Title = "Calculate Average",
                Description = "Write a program that calculates the average of three numbers: 10, 20, and 30.",
                Difficulty = "Beginner",
                Topic = "CSharpFundamentals",
                CodeSnippet = "// Write your code below\n\n// Hint: (a + b + c) / 3",
                Solution = "int a = 10, b = 20, c = 30;\ndouble average = (a + b + c) / 3.0;\nConsole.WriteLine(average);",
                Explanation = "Use 3.0 (not 3) to get a decimal result. The average is (10 + 20 + 30) / 3 = 20.",
                Order = 5
            },
            new CodeChallenge
            {
                Id = 13,
                Title = "Find the Largest Number",
                Description = "Write a program that finds the largest of three numbers: 15, 8, and 22.",
                Difficulty = "Intermediate",
                Topic = "CSharpFundamentals",
                CodeSnippet = "// Write your code below\n\n// Hint: Use if statements",
                Solution = "int a = 15, b = 8, c = 22;\nint largest = a;\nif (b > largest) largest = b;\nif (c > largest) largest = c;\nConsole.WriteLine(largest);",
                Explanation = "Start with the first number as largest, then compare with the others using if statements.",
                Order = 6
            }
        };

        // ============================================================
        // CLASSES & OOP CHALLENGES
        // ============================================================
        _challenges["ClassesAndOOP"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 5,
                Title = "Create a Class",
                Description = "Create a simple 'Person' class with a 'Name' property and an 'Introduce()' method.",
                Difficulty = "Intermediate",
                Topic = "ClassesAndOOP",
                CodeSnippet = "// Create the Person class below\n\n// Hint: Use public class Person",
                Solution = "public class Person\n{\n    public string Name { get; set; }\n    \n    public void Introduce()\n    {\n        Console.WriteLine($\"Hello, my name is {Name}\");\n    }\n}",
                Explanation = "Classes are blueprints for objects. Properties hold data, methods define behavior.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 14,
                Title = "Create an Object",
                Description = "Create an object of the Person class, set the Name to 'John', and call the Introduce() method.",
                Difficulty = "Intermediate",
                Topic = "ClassesAndOOP",
                CodeSnippet = "// Create the Person class first (from previous challenge)\n// Then create an object below\n\n// Hint: Person person = new Person();",
                Solution = "Person person = new Person();\nperson.Name = \"John\";\nperson.Introduce();",
                Explanation = "Use the 'new' keyword to create an object, then set properties and call methods.",
                Order = 2
            },
            new CodeChallenge
            {
                Id = 15,
                Title = "Add a Constructor",
                Description = "Add a constructor to the Person class that takes a name parameter and sets the Name property.",
                Difficulty = "Intermediate",
                Topic = "ClassesAndOOP",
                CodeSnippet = "// Add a constructor to the Person class\n\n// Hint: public Person(string name)",
                Solution = "public class Person\n{\n    public string Name { get; set; }\n    \n    public Person(string name)\n    {\n        Name = name;\n    }\n    \n    public void Introduce()\n    {\n        Console.WriteLine($\"Hello, my name is {Name}\");\n    }\n}",
                Explanation = "Constructors are called when an object is created. They initialize the object's state.",
                Order = 3
            }
        };

        // ============================================================
        // CONSOLE APP CHALLENGES
        // ============================================================
        _challenges["ConsoleApp"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 11,
                Title = "Read User Input",
                Description = "Write a program that asks the user for their name and greets them.",
                Difficulty = "Beginner",
                Topic = "ConsoleApp",
                CodeSnippet = "// Write your code below\n\n// Hint: Use Console.ReadLine()",
                Solution = "Console.Write(\"Enter your name: \");\nstring name = Console.ReadLine();\nConsole.WriteLine($\"Hello, {name}!\");",
                Explanation = "Console.ReadLine() reads user input, and string interpolation ($) inserts the name into the output.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 16,
                Title = "Simple Calculator",
                Description = "Write a program that asks for two numbers and prints their sum.",
                Difficulty = "Beginner",
                Topic = "ConsoleApp",
                CodeSnippet = "// Write your code below\n\n// Hint: Use int.Parse() to convert string to int",
                Solution = "Console.Write(\"Enter first number: \");\nint num1 = int.Parse(Console.ReadLine());\nConsole.Write(\"Enter second number: \");\nint num2 = int.Parse(Console.ReadLine());\nint sum = num1 + num2;\nConsole.WriteLine($\"Sum: {sum}\");",
                Explanation = "Use int.Parse() to convert user input (string) to numbers, then add them.",
                Order = 2
            },
            new CodeChallenge
            {
                Id = 17,
                Title = "Guessing Game",
                Description = "Write a program that generates a random number and asks the user to guess it.",
                Difficulty = "Intermediate",
                Topic = "ConsoleApp",
                CodeSnippet = "// Write your code below\n\n// Hint: Use Random class",
                Solution = "Random random = new Random();\nint secret = random.Next(1, 101);\nConsole.Write(\"Guess a number (1-100): \");\nint guess = int.Parse(Console.ReadLine());\nif (guess == secret)\n    Console.WriteLine(\"Correct!\");\nelse\n    Console.WriteLine($\"Wrong! The number was {secret}\");",
                Explanation = "Use Random.Next(min, max) to generate a random number between 1 and 100.",
                Order = 3
            }
        };

        // ============================================================
        // WINDOWS FORMS CHALLENGES
        // ============================================================
        _challenges["WindowsForms"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 10,
                Title = "Create a Simple Form",
                Description = "Create a Windows Forms app with a button that shows a message box when clicked.",
                Difficulty = "Intermediate",
                Topic = "WindowsForms",
                CodeSnippet = "// Create a new Windows Forms application\n// Add a Button control\n// Handle the Click event\n\n// Hint: Use MessageBox.Show()",
                Solution = "private void btnClick_Click(object sender, EventArgs e)\n{\n    MessageBox.Show(\"Hello from Windows Forms!\");\n}",
                Explanation = "The Click event handler is triggered when the button is clicked. MessageBox.Show() displays a popup.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 18,
                Title = "Add a Label",
                Description = "Add a Label control to your form and update its text when a button is clicked.",
                Difficulty = "Intermediate",
                Topic = "WindowsForms",
                CodeSnippet = "// Add a Label control (lblMessage)\n// Handle the button click event\n\n// Hint: lblMessage.Text = \"New Text\";",
                Solution = "private void btnUpdate_Click(object sender, EventArgs e)\n{\n    lblMessage.Text = \"Button was clicked!\";\n}",
                Explanation = "Use the Text property to change what a label displays. Events handle user interactions.",
                Order = 2
            }
        };

        // ============================================================
        // ASP.NET CORE (RAZOR PAGES) CHALLENGES
        // ============================================================
        _challenges["RazorPages"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 19,
                Title = "Create a Razor Page",
                Description = "Create a Razor Page that displays a welcome message.",
                Difficulty = "Intermediate",
                Topic = "RazorPages",
                CodeSnippet = "// Create a new Razor Page\n// Add a welcome message\n\n// Hint: Use @page directive",
                Solution = "@page\n@{\n    ViewData[\"Title\"] = \"Welcome\";\n}\n\n<h1>Welcome to my Razor Page!</h1>",
                Explanation = "Razor Pages use the @page directive to become endpoints. HTML and C# can be mixed.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 20,
                Title = "Pass Data to View",
                Description = "Pass a message from the PageModel to the view using ViewData.",
                Difficulty = "Intermediate",
                Topic = "RazorPages",
                CodeSnippet = "// In PageModel: ViewData[\"Message\"] = \"Hello\";\n// In View: Show the message\n\n// Hint: Use @@ViewData[\"Message\"]",
                Solution = "// PageModel.cs\npublic void OnGet()\n{\n    ViewData[\"Message\"] = \"Hello from PageModel!\";\n}\n\n// Page.cshtml\n<h1>@ViewData[\"Message\"]</h1>",
                Explanation = "ViewData is a dictionary that passes data from PageModel to the view.",
                Order = 2
            }
        };

        // ============================================================
        // SQL SERVER CHALLENGES
        // ============================================================
        _challenges["SqlServer"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 21,
                Title = "Write a SELECT Query",
                Description = "Write a SQL query that selects all columns from a 'Students' table.",
                Difficulty = "Beginner",
                Topic = "SqlServer",
                CodeSnippet = "-- Write your SQL query below\n\n-- Hint: SELECT * FROM Students",
                Solution = "SELECT * FROM Students;",
                Explanation = "SELECT * returns all columns from the specified table.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 22,
                Title = "Filter with WHERE",
                Description = "Write a SQL query that selects students with age greater than 18.",
                Difficulty = "Beginner",
                Topic = "SqlServer",
                CodeSnippet = "-- Write your SQL query below\n\n-- Hint: WHERE Age > 18",
                Solution = "SELECT * FROM Students WHERE Age > 18;",
                Explanation = "The WHERE clause filters rows based on a condition.",
                Order = 2
            }
        };

        // ============================================================
        // VS SQL CONNECTION CHALLENGES
        // ============================================================
        _challenges["VsSqlConnection"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 23,
                Title = "Create a Connection",
                Description = "Write C# code that creates a connection to SQL Server using a connection string.",
                Difficulty = "Intermediate",
                Topic = "VsSqlConnection",
                CodeSnippet = "// Write your code below\n\n// Hint: Use SqlConnection",
                Solution = "using Microsoft.Data.SqlClient;\nstring connectionString = \"Server=localhost;Database=MyDB;Trusted_Connection=True;\";\nusing var connection = new SqlConnection(connectionString);\nconnection.Open();",
                Explanation = "SqlConnection is used to connect to SQL Server. Always use 'using' to dispose of it.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 24,
                Title = "Execute a Query",
                Description = "Write C# code that executes a SELECT query and reads the results using SqlDataReader.",
                Difficulty = "Advanced",
                Topic = "VsSqlConnection",
                CodeSnippet = "// Write your code below\n\n// Hint: Use SqlCommand and SqlDataReader",
                Solution = "using var command = new SqlCommand(\"SELECT * FROM Students\", connection);\nusing var reader = command.ExecuteReader();\nwhile (reader.Read())\n{\n    Console.WriteLine(reader[\"Name\"]);\n}",
                Explanation = "SqlCommand executes SQL statements. SqlDataReader reads results row by row.",
                Order = 2
            }
        };

        // ============================================================
        // .NET MAUI CHALLENGES
        // ============================================================
        _challenges["DotNetMaui"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 25,
                Title = "Create a MAUI Page",
                Description = "Create a simple ContentPage with a Label in XAML.",
                Difficulty = "Intermediate",
                Topic = "DotNetMaui",
                CodeSnippet = "<!-- Create a ContentPage with a Label -->\n\n<!-- Hint: Use <Label> -->",
                Solution = "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\">\n    <Label Text=\"Hello, MAUI!\" FontSize=\"24\" />\n</ContentPage>",
                Explanation = "XAML is used to define the UI in MAUI. ContentPage is the base page type.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 26,
                Title = "Add a Button",
                Description = "Add a Button to your MAUI page that displays a message when clicked.",
                Difficulty = "Intermediate",
                Topic = "DotNetMaui",
                CodeSnippet = "<!-- Add a Button with Clicked event -->\n\n<!-- Hint: Use Clicked attribute -->",
                Solution = "<Button Text=\"Click Me\" Clicked=\"OnButtonClicked\" />",
                Explanation = "Buttons use the Clicked event to handle user taps or clicks.",
                Order = 2
            }
        };

        // ============================================================
        // RDLC REPORTS CHALLENGES
        // ============================================================
        _challenges["RdlcReports"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 27,
                Title = "Create a Dataset",
                Description = "Create a DataTable with columns: ProductId, Name, Price.",
                Difficulty = "Intermediate",
                Topic = "RdlcReports",
                CodeSnippet = "// Create a DataTable called Products\n\n// Hint: Use DataTable and DataColumn",
                Solution = "DataTable table = new DataTable(\"Products\");\ntable.Columns.Add(\"ProductId\", typeof(int));\ntable.Columns.Add(\"Name\", typeof(string));\ntable.Columns.Add(\"Price\", typeof(decimal));",
                Explanation = "DataTable defines the structure of your data for reports. Columns have names and types.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 28,
                Title = "Add Data to Dataset",
                Description = "Add rows to the Products DataTable with sample data.",
                Difficulty = "Intermediate",
                Topic = "RdlcReports",
                CodeSnippet = "// Add rows to the Products table\n\n// Hint: Use table.Rows.Add()",
                Solution = "table.Rows.Add(1, \"Laptop\", 999.99);\ntable.Rows.Add(2, \"Mouse\", 29.99);\ntable.Rows.Add(3, \"Keyboard\", 79.99);",
                Explanation = "Use Rows.Add() to add data to a DataTable. Each row must match the column structure.",
                Order = 2
            }
        };

        // ============================================================
        // DEPLOYMENT CHALLENGES
        // ============================================================
        _challenges["Deployment"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 29,
                Title = "Create a GitHub Workflow",
                Description = "Create a GitHub Actions workflow that builds a .NET project.",
                Difficulty = "Advanced",
                Topic = "Deployment",
                CodeSnippet = "# Write your workflow YAML below\n\n# Hint: Use dotnet build",
                Solution = "name: Build\non: [push]\njobs:\n  build:\n    runs-on: ubuntu-latest\n    steps:\n      - uses: actions/checkout@v3\n      - uses: actions/setup-dotnet@v3\n        with:\n          dotnet-version: '10.0.x'\n      - run: dotnet build",
                Explanation = "GitHub Actions workflows are YAML files that automate building and testing.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 30,
                Title = "Deploy to Azure",
                Description = "Write the steps to deploy an ASP.NET Core app to Azure App Service.",
                Difficulty = "Advanced",
                Topic = "Deployment",
                CodeSnippet = "# Write the deployment steps\n\n# Hint: Use Azure CLI",
                Solution = "# 1. az login\n# 2. az webapp create --name MyApp --resource-group MyRG\n# 3. az webapp deployment source config-zip --src publish.zip",
                Explanation = "Azure CLI commands deploy your app. Create an App Service, then deploy your code.",
                Order = 2
            }
        };

        // ============================================================
        // SECURITY CHALLENGES
        // ============================================================
        _challenges["Security"] = new List<CodeChallenge>
        {
            new CodeChallenge
            {
                Id = 31,
                Title = "Use Parameterized Query",
                Description = "Write a SQL query that uses parameters to prevent SQL injection.",
                Difficulty = "Advanced",
                Topic = "Security",
                CodeSnippet = "// Write your code below\n\n// Hint: Use @parameterName",
                Solution = "using var command = new SqlCommand(\"SELECT * FROM Users WHERE Username = @username\", connection);\ncommand.Parameters.AddWithValue(\"@username\", username);",
                Explanation = "Parameters separate SQL code from data, preventing SQL injection attacks.",
                Order = 1
            },
            new CodeChallenge
            {
                Id = 32,
                Title = "Add Security Headers",
                Description = "Add X-Content-Type-Options and X-Frame-Options headers to an ASP.NET Core app.",
                Difficulty = "Advanced",
                Topic = "Security",
                CodeSnippet = "// Write your middleware code below\n\n// Hint: Use context.Response.Headers.Add",
                Solution = "app.Use(async (context, next) =>\n{\n    context.Response.Headers.Add(\"X-Content-Type-Options\", \"nosniff\");\n    context.Response.Headers.Add(\"X-Frame-Options\", \"DENY\");\n    await next();\n});",
                Explanation = "Security headers tell browsers how to behave securely. Middleware adds them to responses.",
                Order = 2
            }
        };
    }

    // ============================================================
    // PUBLIC METHODS
    // ============================================================

    public List<CodeChallenge> GetChallengesForTopic(string topic)
    {
        if (_challenges.TryGetValue(topic, out var challenges))
        {
            return challenges;
        }
        return new List<CodeChallenge>();
    }

    public CodeChallenge? GetChallengeById(int id)
    {
        foreach (var topic in _challenges.Values)
        {
            var challenge = topic.FirstOrDefault(c => c.Id == id);
            if (challenge != null) return challenge;
        }
        return null;
    }

    public List<CodeChallenge> GetAllChallenges()
    {
        var allChallenges = new List<CodeChallenge>();
        foreach (var topic in _challenges.Values)
        {
            allChallenges.AddRange(topic);
        }
        return allChallenges.OrderBy(c => c.Topic).ThenBy(c => c.Order).ToList();
    }

    public List<string> GetAllTopics()
    {
        return _challenges.Keys.ToList();
    }

    public bool CheckSolution(CodeChallenge challenge, string userCode)
    {
        // Simple comparison - in a real app you'd compile and run the code
        // This is a simplified version for demonstration
        return userCode.Trim() == challenge.Solution.Trim();
    }
}