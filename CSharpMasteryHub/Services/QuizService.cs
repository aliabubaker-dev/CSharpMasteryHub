using CSharpMasteryHub.Models;

namespace CSharpMasteryHub.Services;

public class QuizService
{
    private readonly Dictionary<string, List<QuizQuestion>> _quizzes = new();

    public QuizService()
    {
        InitializeQuizzes();
    }

    private void InitializeQuizzes()
    {

        // ================================================================
        // CONSOLE APP - LESSON 1: Creating Console App
        // ================================================================
        _quizzes["ConsoleApp_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ConsoleApp_Lesson1",
        Question = "What is the entry point of a C# console application?",
        Options = new List<string> { "Main()", "Start()", "Run()", "Execute()" },
        CorrectAnswer = 0,
        Explanation = "Every C# console app starts with the Main() method. It's the entry point where program execution begins."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ConsoleApp_Lesson1",
        Question = "Which command creates a new console application using .NET CLI?",
        Options = new List<string> {
            "dotnet new console",
            "dotnet create console",
            "dotnet new app",
            "dotnet init console"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet new console' command creates a new console application project."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ConsoleApp_Lesson1",
        Question = "What is the purpose of the 'using System;' statement in a C# file?",
        Options = new List<string> {
            "To import the System namespace",
            "To create a new System object",
            "To define a new class",
            "To declare a variable"
        },
        CorrectAnswer = 0,
        Explanation = "The 'using System;' statement imports the System namespace, allowing you to use types like Console, String, and Int32 without full qualification."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ConsoleApp_Lesson1",
        Question = "Which Visual Studio template is used for creating a console application?",
        Options = new List<string> {
            "Console App (.NET Core)",
            "Windows Forms App",
            "ASP.NET Core Web App",
            "Class Library"
        },
        CorrectAnswer = 0,
        Explanation = "The 'Console App (.NET Core)' or 'Console App (.NET Framework)' template is used to create console applications in Visual Studio."
    }
};

        // ================================================================
        // CONSOLE APP - LESSON 2: Input and Output
        // ================================================================
        _quizzes["ConsoleApp_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ConsoleApp_Lesson2",
        Question = "What is the difference between Console.Write() and Console.WriteLine()?",
        Options = new List<string> {
            "Write() adds a new line, WriteLine() doesn't",
            "WriteLine() adds a new line, Write() doesn't",
            "They do the same thing",
            "Write() only works with numbers"
        },
        CorrectAnswer = 1,
        Explanation = "Console.WriteLine() writes text and adds a new line. Console.Write() writes without a new line."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ConsoleApp_Lesson2",
        Question = "Which method is used to read user input from the console?",
        Options = new List<string> { "Console.Read()", "Console.ReadLine()", "Console.ReadKey()", "All of the above" },
        CorrectAnswer = 3,
        Explanation = "All three methods read input: Read() reads one character, ReadLine() reads a line, ReadKey() reads a key press."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ConsoleApp_Lesson2",
        Question = "What is string interpolation in C#?",
        Options = new List<string> {
            "A way to concatenate strings using +",
            "A way to embed expressions inside strings using $",
            "A method to replace characters",
            "A way to split strings"
        },
        CorrectAnswer = 1,
        Explanation = "String interpolation using $ allows you to embed variables and expressions directly inside strings: $\"Hello {name}\"."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ConsoleApp_Lesson2",
        Question = "Which method should you use to safely convert a string to an integer?",
        Options = new List<string> {
            "int.Parse()",
            "Convert.ToInt32()",
            "int.TryParse()",
            "All of the above are equally safe"
        },
        CorrectAnswer = 2,
        Explanation = "int.TryParse() is the safest method as it doesn't throw an exception on invalid input, returning false instead."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ConsoleApp_Lesson2",
        Question = "How do you change the text color in a console application?",
        Options = new List<string> {
            "Console.Color = ConsoleColor.Red;",
            "Console.ForegroundColor = ConsoleColor.Red;",
            "Console.TextColor = ConsoleColor.Red;",
            "Console.SetColor(ConsoleColor.Red);"
        },
        CorrectAnswer = 1,
        Explanation = "Use Console.ForegroundColor = ConsoleColor.Red; to change text color. Don't forget to call Console.ResetColor() to reset."
    }
};

        // ================================================================
        // CONSOLE APP - LESSON 3: Calculator Project
        // ================================================================
        _quizzes["ConsoleApp_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ConsoleApp_Lesson3",
        Question = "What is the purpose of separating calculation logic into a separate class?",
        Options = new List<string> {
            "To follow the Single Responsibility Principle",
            "To make the code run faster",
            "To use more memory",
            "To make the code more complex"
        },
        CorrectAnswer = 0,
        Explanation = "Separating logic into a separate class follows the Single Responsibility Principle, making code more maintainable and testable."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ConsoleApp_Lesson3",
        Question = "Which exception is thrown when dividing by zero in C#?",
        Options = new List<string> {
            "NullReferenceException",
            "DivideByZeroException",
            "ArgumentException",
            "IndexOutOfRangeException"
        },
        CorrectAnswer = 1,
        Explanation = "DivideByZeroException is thrown when attempting to divide a number by zero in C#."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ConsoleApp_Lesson3",
        Question = "What is the purpose of a while loop in the calculator application?",
        Options = new List<string> {
            "To keep the program running until the user exits",
            "To make the program faster",
            "To calculate multiple operations at once",
            "To display the menu only once"
        },
        CorrectAnswer = 0,
        Explanation = "The while loop keeps the calculator running, allowing the user to perform multiple calculations until they choose to exit."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ConsoleApp_Lesson3",
        Question = "Why should you use try-catch blocks in a calculator application?",
        Options = new List<string> {
            "To make the code run faster",
            "To handle errors gracefully without crashing",
            "To avoid writing validation code",
            "To make the code more complex"
        },
        CorrectAnswer = 1,
        Explanation = "Try-catch blocks handle errors gracefully, preventing the application from crashing when unexpected errors occur (like division by zero)."
    }
};

        // ================================================================
        // CONSOLE APP - LESSON 4: File Handling
        // ================================================================
        _quizzes["ConsoleApp_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ConsoleApp_Lesson4",
        Question = "Which namespace contains file handling classes in C#?",
        Options = new List<string> {
            "System.IO",
            "System.File",
            "System.Data",
            "System.Collections"
        },
        CorrectAnswer = 0,
        Explanation = "The System.IO namespace contains classes for file handling like File, FileInfo, StreamReader, and StreamWriter."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ConsoleApp_Lesson4",
        Question = "Which method writes text to a file and overwrites if the file already exists?",
        Options = new List<string> {
            "File.AppendAllText()",
            "File.WriteAllText()",
            "File.AddText()",
            "File.CreateText()"
        },
        CorrectAnswer = 1,
        Explanation = "File.WriteAllText() writes text to a file and overwrites the file if it already exists."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ConsoleApp_Lesson4",
        Question = "What is the purpose of the 'using' statement with StreamReader/StreamWriter?",
        Options = new List<string> {
            "To make the code run faster",
            "To automatically dispose of resources",
            "To import namespaces",
            "To create a new file"
        },
        CorrectAnswer = 1,
        Explanation = "The 'using' statement ensures that IDisposable objects like StreamReader and StreamWriter are properly disposed of when they go out of scope."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ConsoleApp_Lesson4",
        Question = "How do you check if a file exists in C#?",
        Options = new List<string> {
            "File.Exists()",
            "File.IsExists()",
            "File.CheckExists()",
            "File.HasFile()"
        },
        CorrectAnswer = 0,
        Explanation = "File.Exists() is the method used to check if a file exists at the specified path."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ConsoleApp_Lesson4",
        Question = "Which method reads all lines from a file into a string array?",
        Options = new List<string> {
            "File.ReadAllText()",
            "File.ReadAllLines()",
            "File.ReadLines()",
            "File.ReadText()"
        },
        CorrectAnswer = 1,
        Explanation = "File.ReadAllLines() reads all lines from a file and returns them as a string array."
    }
};

        // ================================================================
        // CONSOLE APP - FULL SECTION (All 18 Questions)
        // ================================================================
        _quizzes["ConsoleApp"] = new List<QuizQuestion>
{
    // Lesson 1: Creating Console App
    new QuizQuestion
    {
        Id = 1,
        Topic = "ConsoleApp",
        Question = "What is the entry point of a C# console application?",
        Options = new List<string> { "Main()", "Start()", "Run()", "Execute()" },
        CorrectAnswer = 0,
        Explanation = "Every C# console app starts with the Main() method. It's the entry point where program execution begins."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ConsoleApp",
        Question = "Which command creates a new console application using .NET CLI?",
        Options = new List<string> {
            "dotnet new console",
            "dotnet create console",
            "dotnet new app",
            "dotnet init console"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet new console' command creates a new console application project."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ConsoleApp",
        Question = "What is the purpose of the 'using System;' statement in a C# file?",
        Options = new List<string> {
            "To import the System namespace",
            "To create a new System object",
            "To define a new class",
            "To declare a variable"
        },
        CorrectAnswer = 0,
        Explanation = "The 'using System;' statement imports the System namespace, allowing you to use types like Console, String, and Int32 without full qualification."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ConsoleApp",
        Question = "Which Visual Studio template is used for creating a console application?",
        Options = new List<string> {
            "Console App (.NET Core)",
            "Windows Forms App",
            "ASP.NET Core Web App",
            "Class Library"
        },
        CorrectAnswer = 0,
        Explanation = "The 'Console App (.NET Core)' or 'Console App (.NET Framework)' template is used to create console applications in Visual Studio."
    },

    // Lesson 2: Input and Output
    new QuizQuestion
    {
        Id = 5,
        Topic = "ConsoleApp",
        Question = "What is the difference between Console.Write() and Console.WriteLine()?",
        Options = new List<string> {
            "Write() adds a new line, WriteLine() doesn't",
            "WriteLine() adds a new line, Write() doesn't",
            "They do the same thing",
            "Write() only works with numbers"
        },
        CorrectAnswer = 1,
        Explanation = "Console.WriteLine() writes text and adds a new line. Console.Write() writes without a new line."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ConsoleApp",
        Question = "Which method is used to read user input from the console?",
        Options = new List<string> { "Console.Read()", "Console.ReadLine()", "Console.ReadKey()", "All of the above" },
        CorrectAnswer = 3,
        Explanation = "All three methods read input: Read() reads one character, ReadLine() reads a line, ReadKey() reads a key press."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "ConsoleApp",
        Question = "What is string interpolation in C#?",
        Options = new List<string> {
            "A way to concatenate strings using +",
            "A way to embed expressions inside strings using $",
            "A method to replace characters",
            "A way to split strings"
        },
        CorrectAnswer = 1,
        Explanation = "String interpolation using $ allows you to embed variables and expressions directly inside strings: $\"Hello {name}\"."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "ConsoleApp",
        Question = "Which method should you use to safely convert a string to an integer?",
        Options = new List<string> {
            "int.Parse()",
            "Convert.ToInt32()",
            "int.TryParse()",
            "All of the above are equally safe"
        },
        CorrectAnswer = 2,
        Explanation = "int.TryParse() is the safest method as it doesn't throw an exception on invalid input, returning false instead."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "ConsoleApp",
        Question = "How do you change the text color in a console application?",
        Options = new List<string> {
            "Console.Color = ConsoleColor.Red;",
            "Console.ForegroundColor = ConsoleColor.Red;",
            "Console.TextColor = ConsoleColor.Red;",
            "Console.SetColor(ConsoleColor.Red);"
        },
        CorrectAnswer = 1,
        Explanation = "Use Console.ForegroundColor = ConsoleColor.Red; to change text color. Don't forget to call Console.ResetColor() to reset."
    },

    // Lesson 3: Calculator Project
    new QuizQuestion
    {
        Id = 10,
        Topic = "ConsoleApp",
        Question = "What is the purpose of separating calculation logic into a separate class?",
        Options = new List<string> {
            "To follow the Single Responsibility Principle",
            "To make the code run faster",
            "To use more memory",
            "To make the code more complex"
        },
        CorrectAnswer = 0,
        Explanation = "Separating logic into a separate class follows the Single Responsibility Principle, making code more maintainable and testable."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "ConsoleApp",
        Question = "Which exception is thrown when dividing by zero in C#?",
        Options = new List<string> {
            "NullReferenceException",
            "DivideByZeroException",
            "ArgumentException",
            "IndexOutOfRangeException"
        },
        CorrectAnswer = 1,
        Explanation = "DivideByZeroException is thrown when attempting to divide a number by zero in C#."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "ConsoleApp",
        Question = "What is the purpose of a while loop in the calculator application?",
        Options = new List<string> {
            "To keep the program running until the user exits",
            "To make the program faster",
            "To calculate multiple operations at once",
            "To display the menu only once"
        },
        CorrectAnswer = 0,
        Explanation = "The while loop keeps the calculator running, allowing the user to perform multiple calculations until they choose to exit."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "ConsoleApp",
        Question = "Why should you use try-catch blocks in a calculator application?",
        Options = new List<string> {
            "To make the code run faster",
            "To handle errors gracefully without crashing",
            "To avoid writing validation code",
            "To make the code more complex"
        },
        CorrectAnswer = 1,
        Explanation = "Try-catch blocks handle errors gracefully, preventing the application from crashing when unexpected errors occur (like division by zero)."
    },

    // Lesson 4: File Handling
    new QuizQuestion
    {
        Id = 14,
        Topic = "ConsoleApp",
        Question = "Which namespace contains file handling classes in C#?",
        Options = new List<string> {
            "System.IO",
            "System.File",
            "System.Data",
            "System.Collections"
        },
        CorrectAnswer = 0,
        Explanation = "The System.IO namespace contains classes for file handling like File, FileInfo, StreamReader, and StreamWriter."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "ConsoleApp",
        Question = "Which method writes text to a file and overwrites if the file already exists?",
        Options = new List<string> {
            "File.AppendAllText()",
            "File.WriteAllText()",
            "File.AddText()",
            "File.CreateText()"
        },
        CorrectAnswer = 1,
        Explanation = "File.WriteAllText() writes text to a file and overwrites the file if it already exists."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "ConsoleApp",
        Question = "What is the purpose of the 'using' statement with StreamReader/StreamWriter?",
        Options = new List<string> {
            "To make the code run faster",
            "To automatically dispose of resources",
            "To import namespaces",
            "To create a new file"
        },
        CorrectAnswer = 1,
        Explanation = "The 'using' statement ensures that IDisposable objects like StreamReader and StreamWriter are properly disposed of when they go out of scope."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "ConsoleApp",
        Question = "How do you check if a file exists in C#?",
        Options = new List<string> {
            "File.Exists()",
            "File.IsExists()",
            "File.CheckExists()",
            "File.HasFile()"
        },
        CorrectAnswer = 0,
        Explanation = "File.Exists() is the method used to check if a file exists at the specified path."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "ConsoleApp",
        Question = "Which method reads all lines from a file into a string array?",
        Options = new List<string> {
            "File.ReadAllText()",
            "File.ReadAllLines()",
            "File.ReadLines()",
            "File.ReadText()"
        },
        CorrectAnswer = 1,
        Explanation = "File.ReadAllLines() reads all lines from a file and returns them as a string array."
    }
};





        // ================================================================
        // C# FUNDAMENTALS QUIZ
        // ================================================================
        _quizzes["CSharpFundamentals"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "CSharpFundamentals",
                Question = "What is the correct way to declare a variable in C#?",
                Options = new List<string> { "var x = 5;", "int x = 5;", "x = 5;", "int x;" },
                CorrectAnswer = 1,
                Explanation = "In C#, you declare a variable with a type followed by the variable name. 'int x = 5;' is the correct syntax."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "CSharpFundamentals",
                Question = "Which data type is used for decimal numbers in C#?",
                Options = new List<string> { "int", "decimal", "string", "bool" },
                CorrectAnswer = 1,
                Explanation = "The 'decimal' type is used for precise decimal calculations like money. 'int' is for whole numbers."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "CSharpFundamentals",
                Question = "What does the 'var' keyword do in C#?",
                Options = new List<string> {
                    "Creates a variable without a type",
                    "Implicitly types a variable based on the value",
                    "Makes a variable constant",
                    "Creates a global variable"
                },
                CorrectAnswer = 1,
                Explanation = "'var' tells the compiler to infer the type from the value assigned. It's not a type itself."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "CSharpFundamentals",
                Question = "Which of the following is NOT a valid C# data type?",
                Options = new List<string> { "int", "float", "double", "number" },
                CorrectAnswer = 3,
                Explanation = "'number' is not a valid C# data type. The correct types are int, float, double, decimal, etc."
            },
            new QuizQuestion
            {
                Id = 5,
                Topic = "CSharpFundamentals",
                Question = "What is the difference between '==' and 'Equals()' in C#?",
                Options = new List<string> {
                    "They are exactly the same",
                    "'==' compares references, 'Equals()' compares values",
                    "'==' is for numbers only",
                    "'Equals()' is for strings only"
                },
                CorrectAnswer = 1,
                Explanation = "For reference types, '==' checks reference equality, while 'Equals()' checks value equality. For value types, they behave the same."
            },
            new QuizQuestion
            {
                Id = 6,
                Topic = "CSharpFundamentals",
                Question = "What is a nullable type in C#?",
                Options = new List<string> {
                    "A type that can be null",
                    "A type that cannot be null",
                    "A type that is always optional",
                    "A type with a default value of null"
                },
                CorrectAnswer = 0,
                Explanation = "Nullable types (like int?) allow value types to be assigned null. This is useful for database fields that can be null."
            }
        };

        // ================================================================
        // CONSOLE APPS QUIZ
        // ================================================================
        _quizzes["ConsoleApp"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ConsoleApp",
                Question = "What method is used to read user input in a console app?",
                Options = new List<string> { "Console.Read()", "Console.ReadLine()", "Console.ReadKey()", "All of the above" },
                CorrectAnswer = 3,
                Explanation = "All three methods read input: Read() reads one character, ReadLine() reads a line, ReadKey() reads a key press."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ConsoleApp",
                Question = "What is the entry point of a C# console application?",
                Options = new List<string> { "Main()", "Start()", "Run()", "Execute()" },
                CorrectAnswer = 0,
                Explanation = "Every C# console app starts with the Main() method. It's the entry point."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ConsoleApp",
                Question = "Which method writes text to the console and adds a new line?",
                Options = new List<string> { "Console.Write()", "Console.WriteLine()", "Console.Print()", "Console.Log()" },
                CorrectAnswer = 1,
                Explanation = "Console.WriteLine() writes text and adds a new line. Console.Write() writes without a new line."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "ConsoleApp",
                Question = "What is a string interpolation in C#?",
                Options = new List<string> {
                    "A way to concatenate strings",
                    "A way to embed expressions inside strings using $",
                    "A method to replace characters",
                    "A way to split strings"
                },
                CorrectAnswer = 1,
                Explanation = "String interpolation using $ allows you to embed variables and expressions directly inside strings: $\"Hello {name}\"."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 1: What Is A Class
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson1"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson1",
                Question = "What is a class in C#?",
                Options = new List<string> {
                    "A blueprint or template for creating objects",
                    "A variable that stores data",
                    "A method that performs calculations",
                    "A type of loop"
                },
                CorrectAnswer = 0,
                Explanation = "A class is a blueprint or template for creating objects. It defines the structure and behavior that objects of that class will have."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson1",
                Question = "What is an object in C#?",
                Options = new List<string> {
                    "A class that contains methods",
                    "An instance of a class",
                    "A type of variable",
                    "A method that returns a value"
                },
                CorrectAnswer = 1,
                Explanation = "An object is an instance of a class. It has the properties and behaviors defined by its class."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson1",
                Question = "Which keyword is used to create an object in C#?",
                Options = new List<string> { "create", "new", "object", "instance" },
                CorrectAnswer = 1,
                Explanation = "The 'new' keyword is used to create an instance of a class in C#."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 2: Fields and Properties
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson2"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson2",
                Question = "What is a field in a C# class?",
                Options = new List<string> {
                    "A method that returns data",
                    "A variable declared inside a class",
                    "A property that validates data",
                    "A constructor that initializes data"
                },
                CorrectAnswer = 1,
                Explanation = "A field is a variable declared directly inside a class that holds data. Fields are typically kept private."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson2",
                Question = "What is the purpose of a property in C#?",
                Options = new List<string> {
                    "To store data without validation",
                    "To provide controlled access to fields with get and set accessors",
                    "To create methods that return data",
                    "To define the constructor of a class"
                },
                CorrectAnswer = 1,
                Explanation = "Properties provide controlled access to fields through get and set accessors, allowing validation and logic."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson2",
                Question = "What is an auto-implemented property in C#?",
                Options = new List<string> {
                    "A property that requires manual backing field implementation",
                    "A property where the compiler automatically generates the backing field",
                    "A property that cannot be modified",
                    "A property that only has a getter"
                },
                CorrectAnswer = 1,
                Explanation = "Auto-implemented properties let the compiler generate the backing field automatically. Example: public string Name { get; set; }"
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "ClassesAndOOP_Lesson2",
                Question = "What does the 'init' accessor do in a property?",
                Options = new List<string> {
                    "Allows the property to be set only during object initialization",
                    "Makes the property read-only",
                    "Makes the property write-only",
                    "Allows the property to be set at any time"
                },
                CorrectAnswer = 0,
                Explanation = "The 'init' accessor allows a property to be set only during object initialization, making it immutable afterward."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 3: Methods Deep Dive
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson3"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson3",
                Question = "What is a method in C#?",
                Options = new List<string> {
                    "A block of code that performs a specific task",
                    "A variable that stores data",
                    "A type of class",
                    "A property that validates data"
                },
                CorrectAnswer = 0,
                Explanation = "A method is a block of code that performs a specific task. Methods help organize code and promote reuse."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson3",
                Question = "What is method overloading in C#?",
                Options = new List<string> {
                    "Having multiple methods with the same name but different parameters",
                    "Having methods with different names",
                    "Having methods in different classes",
                    "Having methods that return different types"
                },
                CorrectAnswer = 0,
                Explanation = "Method overloading allows multiple methods with the same name but different parameters (different number or types)."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson3",
                Question = "What is the purpose of the 'params' keyword in C#?",
                Options = new List<string> {
                    "To define a parameter as optional",
                    "To allow a method to accept a variable number of arguments",
                    "To make a parameter read-only",
                    "To pass parameters by reference"
                },
                CorrectAnswer = 1,
                Explanation = "The 'params' keyword allows a method to accept a variable number of arguments of the same type."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 4: Constructors
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson4"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson4",
                Question = "What is a constructor in C#?",
                Options = new List<string> {
                    "A method that is called when an object is created",
                    "A method that is called when an object is destroyed",
                    "A property that initializes data",
                    "A field that stores data"
                },
                CorrectAnswer = 0,
                Explanation = "A constructor is a special method that is automatically called when an object is created to initialize the object's state."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson4",
                Question = "What is constructor chaining in C#?",
                Options = new List<string> {
                    "Calling multiple constructors in sequence",
                    "One constructor calling another constructor in the same class using : this()",
                    "Creating multiple objects with the same constructor",
                    "Inheriting constructors from a base class"
                },
                CorrectAnswer = 1,
                Explanation = "Constructor chaining allows one constructor to call another constructor in the same class using the : this() syntax."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 5: Encapsulation
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson5"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson5",
                Question = "What is encapsulation in C#?",
                Options = new List<string> {
                    "Hiding internal data and exposing only what's needed",
                    "Creating multiple methods with the same name",
                    "Inheriting from a base class",
                    "Sharing data between classes"
                },
                CorrectAnswer = 0,
                Explanation = "Encapsulation is about hiding internal implementation details and exposing only necessary functionality through public methods/properties."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson5",
                Question = "Which access modifier makes a member accessible only within the same class?",
                Options = new List<string> { "public", "private", "protected", "internal" },
                CorrectAnswer = 1,
                Explanation = "'private' members are only accessible within the same class. This is the most restrictive access level."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson5",
                Question = "What is the purpose of the 'protected' access modifier?",
                Options = new List<string> {
                    "Allows access only within the same class",
                    "Allows access within the same class and derived classes",
                    "Allows access anywhere in the same assembly",
                    "Allows access from anywhere"
                },
                CorrectAnswer = 1,
                Explanation = "'protected' members are accessible within the same class and in derived classes (subclasses)."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 6: Inheritance
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson6"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson6",
                Question = "What is inheritance in C#?",
                Options = new List<string> {
                    "A class inheriting properties and methods from another class",
                    "A class inheriting from multiple classes",
                    "A class inheriting from an interface",
                    "A method inheriting from another method"
                },
                CorrectAnswer = 0,
                Explanation = "Inheritance allows a class (derived) to inherit properties and methods from another class (base). C# supports single inheritance only."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson6",
                Question = "Which keyword is used to call a base class constructor in C#?",
                Options = new List<string> { "base", "this", "super", "parent" },
                CorrectAnswer = 0,
                Explanation = "The 'base' keyword is used to call a base class constructor or access base class members."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson6",
                Question = "What is the purpose of the 'sealed' keyword in C#?",
                Options = new List<string> {
                    "To prevent a class from being inherited",
                    "To prevent a method from being overridden",
                    "To make a class abstract",
                    "To make a method virtual"
                },
                CorrectAnswer = 0,
                Explanation = "The 'sealed' keyword prevents a class from being inherited or a method from being overridden."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 7: Polymorphism
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson7"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson7",
                Question = "What is polymorphism in C#?",
                Options = new List<string> {
                    "The ability to have many forms",
                    "The ability to have many classes",
                    "The ability to have many methods",
                    "The ability to have many objects"
                },
                CorrectAnswer = 0,
                Explanation = "Polymorphism allows objects of different types to be treated as objects of a common base type, with the correct method being called based on the actual object type."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson7",
                Question = "What is the difference between 'virtual' and 'override' in C#?",
                Options = new List<string> {
                    "'virtual' allows a method to be overridden, 'override' replaces the method implementation",
                    "'virtual' replaces the method, 'override' allows a method to be overridden",
                    "They are the same thing",
                    "'virtual' is used for properties, 'override' is used for methods"
                },
                CorrectAnswer = 0,
                Explanation = "'virtual' marks a method that can be overridden in derived classes. 'override' replaces the base class implementation in a derived class."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 8: Abstraction & Interfaces
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson8"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson8",
                Question = "What is an abstract class in C#?",
                Options = new List<string> {
                    "A class that cannot be instantiated and can contain abstract methods",
                    "A class that can only be inherited",
                    "A class that contains only static methods",
                    "A class that cannot be inherited"
                },
                CorrectAnswer = 0,
                Explanation = "An abstract class cannot be instantiated. It can contain abstract methods (no implementation) and concrete methods (with implementation)."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson8",
                Question = "What is an interface in C#?",
                Options = new List<string> {
                    "A contract that defines methods without implementation",
                    "A class that contains implementation",
                    "A type of abstract class",
                    "A method that can be overridden"
                },
                CorrectAnswer = 0,
                Explanation = "An interface defines a contract with method signatures but no implementation. Classes implement interfaces."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson8",
                Question = "What is the main difference between an abstract class and an interface?",
                Options = new List<string> {
                    "Abstract classes can have implementation, interfaces cannot (before C# 8)",
                    "Abstract classes cannot be inherited, interfaces can",
                    "Interfaces can have fields, abstract classes cannot",
                    "There is no difference"
                },
                CorrectAnswer = 0,
                Explanation = "Abstract classes can contain implementation (concrete methods), while interfaces traditionally only defined method signatures (before default interface methods in C# 8)."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 9: Static vs Instance
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson9"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson9",
                Question = "What is the difference between static and instance members in C#?",
                Options = new List<string> {
                    "Static members belong to the class, instance members belong to objects",
                    "Static members belong to objects, instance members belong to the class",
                    "They are the same thing",
                    "Static members can only be used in static classes"
                },
                CorrectAnswer = 0,
                Explanation = "Static members belong to the class itself and are shared by all instances. Instance members belong to each individual object."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson9",
                Question = "When should you use static methods?",
                Options = new List<string> {
                    "When the method doesn't need access to instance data",
                    "When the method needs access to instance data",
                    "When you want to create multiple instances",
                    "When you want to override the method"
                },
                CorrectAnswer = 0,
                Explanation = "Static methods are used when the method doesn't need to access instance-specific data and can operate independently."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 10: Generics
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson10"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson10",
                Question = "What are generics in C#?",
                Options = new List<string> {
                    "A way to define classes and methods with type parameters",
                    "A way to create objects without types",
                    "A type of collection",
                    "A way to avoid type safety"
                },
                CorrectAnswer = 0,
                Explanation = "Generics allow you to define classes, methods, and structures with type parameters, enabling type-safe code reuse."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson10",
                Question = "What is the purpose of generic constraints in C#?",
                Options = new List<string> {
                    "To restrict the types that can be used as type arguments",
                    "To make generics faster",
                    "To allow any type to be used",
                    "To create multiple instances"
                },
                CorrectAnswer = 0,
                Explanation = "Generic constraints restrict what types can be used as type arguments, ensuring they meet certain requirements (e.g., implementing an interface, having a constructor)."
            }
        };

        // ================================================================
        // CLASSES & OOP - LESSON 11: SOLID Principles
        // ================================================================
        _quizzes["ClassesAndOOP_Lesson11"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP_Lesson11",
                Question = "What does the 'S' in SOLID stand for?",
                Options = new List<string> {
                    "Single Responsibility Principle",
                    "Simple Responsibility Principle",
                    "Static Responsibility Principle",
                    "System Responsibility Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'S' in SOLID stands for Single Responsibility Principle - a class should have only one reason to change."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP_Lesson11",
                Question = "What does the 'O' in SOLID stand for?",
                Options = new List<string> {
                    "Open/Closed Principle",
                    "Object-Oriented Principle",
                    "Overriding Principle",
                    "Optimization Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'O' in SOLID stands for Open/Closed Principle - software entities should be open for extension but closed for modification."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP_Lesson11",
                Question = "What does the 'L' in SOLID stand for?",
                Options = new List<string> {
                    "Liskov Substitution Principle",
                    "Linear Substitution Principle",
                    "Logical Substitution Principle",
                    "Language Substitution Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'L' in SOLID stands for Liskov Substitution Principle - objects of a derived class should be able to replace objects of the base class."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "ClassesAndOOP_Lesson11",
                Question = "What does the 'I' in SOLID stand for?",
                Options = new List<string> {
                    "Interface Segregation Principle",
                    "Interface Substitution Principle",
                    "Implementation Segregation Principle",
                    "Inheritance Segregation Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'I' in SOLID stands for Interface Segregation Principle - clients should not be forced to depend on interfaces they don't use."
            },
            new QuizQuestion
            {
                Id = 5,
                Topic = "ClassesAndOOP_Lesson11",
                Question = "What does the 'D' in SOLID stand for?",
                Options = new List<string> {
                    "Dependency Inversion Principle",
                    "Dependency Integration Principle",
                    "Direct Inversion Principle",
                    "Data Inversion Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'D' in SOLID stands for Dependency Inversion Principle - high-level modules should not depend on low-level modules; both should depend on abstractions."
            }
        };

        // ================================================================
        // CLASSES & OOP - FULL SECTION (All 32 Questions)
        // ================================================================
        _quizzes["ClassesAndOOP"] = new List<QuizQuestion>
        {
            // Lesson 1: What Is A Class
            new QuizQuestion
            {
                Id = 1,
                Topic = "ClassesAndOOP",
                Question = "What is a class in C#?",
                Options = new List<string> {
                    "A blueprint or template for creating objects",
                    "A variable that stores data",
                    "A method that performs calculations",
                    "A type of loop"
                },
                CorrectAnswer = 0,
                Explanation = "A class is a blueprint or template for creating objects. It defines the structure and behavior that objects of that class will have."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "ClassesAndOOP",
                Question = "What is an object in C#?",
                Options = new List<string> {
                    "A class that contains methods",
                    "An instance of a class",
                    "A type of variable",
                    "A method that returns a value"
                },
                CorrectAnswer = 1,
                Explanation = "An object is an instance of a class. It has the properties and behaviors defined by its class."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "ClassesAndOOP",
                Question = "Which keyword is used to create an object in C#?",
                Options = new List<string> { "create", "new", "object", "instance" },
                CorrectAnswer = 1,
                Explanation = "The 'new' keyword is used to create an instance of a class in C#."
            },

            // Lesson 2: Fields and Properties
            new QuizQuestion
            {
                Id = 4,
                Topic = "ClassesAndOOP",
                Question = "What is a field in a C# class?",
                Options = new List<string> {
                    "A method that returns data",
                    "A variable declared inside a class",
                    "A property that validates data",
                    "A constructor that initializes data"
                },
                CorrectAnswer = 1,
                Explanation = "A field is a variable declared directly inside a class that holds data. Fields are typically kept private."
            },
            new QuizQuestion
            {
                Id = 5,
                Topic = "ClassesAndOOP",
                Question = "What is the purpose of a property in C#?",
                Options = new List<string> {
                    "To store data without validation",
                    "To provide controlled access to fields with get and set accessors",
                    "To create methods that return data",
                    "To define the constructor of a class"
                },
                CorrectAnswer = 1,
                Explanation = "Properties provide controlled access to fields through get and set accessors, allowing validation and logic."
            },
            new QuizQuestion
            {
                Id = 6,
                Topic = "ClassesAndOOP",
                Question = "What is an auto-implemented property in C#?",
                Options = new List<string> {
                    "A property that requires manual backing field implementation",
                    "A property where the compiler automatically generates the backing field",
                    "A property that cannot be modified",
                    "A property that only has a getter"
                },
                CorrectAnswer = 1,
                Explanation = "Auto-implemented properties let the compiler generate the backing field automatically. Example: public string Name { get; set; }"
            },
            new QuizQuestion
            {
                Id = 7,
                Topic = "ClassesAndOOP",
                Question = "What does the 'init' accessor do in a property?",
                Options = new List<string> {
                    "Allows the property to be set only during object initialization",
                    "Makes the property read-only",
                    "Makes the property write-only",
                    "Allows the property to be set at any time"
                },
                CorrectAnswer = 0,
                Explanation = "The 'init' accessor allows a property to be set only during object initialization, making it immutable afterward."
            },

            // Lesson 3: Methods Deep Dive
            new QuizQuestion
            {
                Id = 8,
                Topic = "ClassesAndOOP",
                Question = "What is a method in C#?",
                Options = new List<string> {
                    "A block of code that performs a specific task",
                    "A variable that stores data",
                    "A type of class",
                    "A property that validates data"
                },
                CorrectAnswer = 0,
                Explanation = "A method is a block of code that performs a specific task. Methods help organize code and promote reuse."
            },
            new QuizQuestion
            {
                Id = 9,
                Topic = "ClassesAndOOP",
                Question = "What is method overloading in C#?",
                Options = new List<string> {
                    "Having multiple methods with the same name but different parameters",
                    "Having methods with different names",
                    "Having methods in different classes",
                    "Having methods that return different types"
                },
                CorrectAnswer = 0,
                Explanation = "Method overloading allows multiple methods with the same name but different parameters (different number or types)."
            },
            new QuizQuestion
            {
                Id = 10,
                Topic = "ClassesAndOOP",
                Question = "What is the purpose of the 'params' keyword in C#?",
                Options = new List<string> {
                    "To define a parameter as optional",
                    "To allow a method to accept a variable number of arguments",
                    "To make a parameter read-only",
                    "To pass parameters by reference"
                },
                CorrectAnswer = 1,
                Explanation = "The 'params' keyword allows a method to accept a variable number of arguments of the same type."
            },

            // Lesson 4: Constructors
            new QuizQuestion
            {
                Id = 11,
                Topic = "ClassesAndOOP",
                Question = "What is a constructor in C#?",
                Options = new List<string> {
                    "A method that is called when an object is created",
                    "A method that is called when an object is destroyed",
                    "A property that initializes data",
                    "A field that stores data"
                },
                CorrectAnswer = 0,
                Explanation = "A constructor is a special method that is automatically called when an object is created to initialize the object's state."
            },
            new QuizQuestion
            {
                Id = 12,
                Topic = "ClassesAndOOP",
                Question = "What is constructor chaining in C#?",
                Options = new List<string> {
                    "Calling multiple constructors in sequence",
                    "One constructor calling another constructor in the same class using : this()",
                    "Creating multiple objects with the same constructor",
                    "Inheriting constructors from a base class"
                },
                CorrectAnswer = 1,
                Explanation = "Constructor chaining allows one constructor to call another constructor in the same class using the : this() syntax."
            },

            // Lesson 5: Encapsulation
            new QuizQuestion
            {
                Id = 13,
                Topic = "ClassesAndOOP",
                Question = "What is encapsulation in C#?",
                Options = new List<string> {
                    "Hiding internal data and exposing only what's needed",
                    "Creating multiple methods with the same name",
                    "Inheriting from a base class",
                    "Sharing data between classes"
                },
                CorrectAnswer = 0,
                Explanation = "Encapsulation is about hiding internal implementation details and exposing only necessary functionality through public methods/properties."
            },
            new QuizQuestion
            {
                Id = 14,
                Topic = "ClassesAndOOP",
                Question = "Which access modifier makes a member accessible only within the same class?",
                Options = new List<string> { "public", "private", "protected", "internal" },
                CorrectAnswer = 1,
                Explanation = "'private' members are only accessible within the same class. This is the most restrictive access level."
            },
            new QuizQuestion
            {
                Id = 15,
                Topic = "ClassesAndOOP",
                Question = "What is the purpose of the 'protected' access modifier?",
                Options = new List<string> {
                    "Allows access only within the same class",
                    "Allows access within the same class and derived classes",
                    "Allows access anywhere in the same assembly",
                    "Allows access from anywhere"
                },
                CorrectAnswer = 1,
                Explanation = "'protected' members are accessible within the same class and in derived classes (subclasses)."
            },

            // Lesson 6: Inheritance
            new QuizQuestion
            {
                Id = 16,
                Topic = "ClassesAndOOP",
                Question = "What is inheritance in C#?",
                Options = new List<string> {
                    "A class inheriting properties and methods from another class",
                    "A class inheriting from multiple classes",
                    "A class inheriting from an interface",
                    "A method inheriting from another method"
                },
                CorrectAnswer = 0,
                Explanation = "Inheritance allows a class (derived) to inherit properties and methods from another class (base). C# supports single inheritance only."
            },
            new QuizQuestion
            {
                Id = 17,
                Topic = "ClassesAndOOP",
                Question = "Which keyword is used to call a base class constructor in C#?",
                Options = new List<string> { "base", "this", "super", "parent" },
                CorrectAnswer = 0,
                Explanation = "The 'base' keyword is used to call a base class constructor or access base class members."
            },
            new QuizQuestion
            {
                Id = 18,
                Topic = "ClassesAndOOP",
                Question = "What is the purpose of the 'sealed' keyword in C#?",
                Options = new List<string> {
                    "To prevent a class from being inherited",
                    "To prevent a method from being overridden",
                    "To make a class abstract",
                    "To make a method virtual"
                },
                CorrectAnswer = 0,
                Explanation = "The 'sealed' keyword prevents a class from being inherited or a method from being overridden."
            },

            // Lesson 7: Polymorphism
            new QuizQuestion
            {
                Id = 19,
                Topic = "ClassesAndOOP",
                Question = "What is polymorphism in C#?",
                Options = new List<string> {
                    "The ability to have many forms",
                    "The ability to have many classes",
                    "The ability to have many methods",
                    "The ability to have many objects"
                },
                CorrectAnswer = 0,
                Explanation = "Polymorphism allows objects of different types to be treated as objects of a common base type, with the correct method being called based on the actual object type."
            },
            new QuizQuestion
            {
                Id = 20,
                Topic = "ClassesAndOOP",
                Question = "What is the difference between 'virtual' and 'override' in C#?",
                Options = new List<string> {
                    "'virtual' allows a method to be overridden, 'override' replaces the method implementation",
                    "'virtual' replaces the method, 'override' allows a method to be overridden",
                    "They are the same thing",
                    "'virtual' is used for properties, 'override' is used for methods"
                },
                CorrectAnswer = 0,
                Explanation = "'virtual' marks a method that can be overridden in derived classes. 'override' replaces the base class implementation in a derived class."
            },

            // Lesson 8: Abstraction & Interfaces
            new QuizQuestion
            {
                Id = 21,
                Topic = "ClassesAndOOP",
                Question = "What is an abstract class in C#?",
                Options = new List<string> {
                    "A class that cannot be instantiated and can contain abstract methods",
                    "A class that can only be inherited",
                    "A class that contains only static methods",
                    "A class that cannot be inherited"
                },
                CorrectAnswer = 0,
                Explanation = "An abstract class cannot be instantiated. It can contain abstract methods (no implementation) and concrete methods (with implementation)."
            },
            new QuizQuestion
            {
                Id = 22,
                Topic = "ClassesAndOOP",
                Question = "What is an interface in C#?",
                Options = new List<string> {
                    "A contract that defines methods without implementation",
                    "A class that contains implementation",
                    "A type of abstract class",
                    "A method that can be overridden"
                },
                CorrectAnswer = 0,
                Explanation = "An interface defines a contract with method signatures but no implementation. Classes implement interfaces."
            },
            new QuizQuestion
            {
                Id = 23,
                Topic = "ClassesAndOOP",
                Question = "What is the main difference between an abstract class and an interface?",
                Options = new List<string> {
                    "Abstract classes can have implementation, interfaces cannot (before C# 8)",
                    "Abstract classes cannot be inherited, interfaces can",
                    "Interfaces can have fields, abstract classes cannot",
                    "There is no difference"
                },
                CorrectAnswer = 0,
                Explanation = "Abstract classes can contain implementation (concrete methods), while interfaces traditionally only defined method signatures (before default interface methods in C# 8)."
            },

            // Lesson 9: Static vs Instance
            new QuizQuestion
            {
                Id = 24,
                Topic = "ClassesAndOOP",
                Question = "What is the difference between static and instance members in C#?",
                Options = new List<string> {
                    "Static members belong to the class, instance members belong to objects",
                    "Static members belong to objects, instance members belong to the class",
                    "They are the same thing",
                    "Static members can only be used in static classes"
                },
                CorrectAnswer = 0,
                Explanation = "Static members belong to the class itself and are shared by all instances. Instance members belong to each individual object."
            },
            new QuizQuestion
            {
                Id = 25,
                Topic = "ClassesAndOOP",
                Question = "When should you use static methods?",
                Options = new List<string> {
                    "When the method doesn't need access to instance data",
                    "When the method needs access to instance data",
                    "When you want to create multiple instances",
                    "When you want to override the method"
                },
                CorrectAnswer = 0,
                Explanation = "Static methods are used when the method doesn't need to access instance-specific data and can operate independently."
            },

            // Lesson 10: Generics
            new QuizQuestion
            {
                Id = 26,
                Topic = "ClassesAndOOP",
                Question = "What are generics in C#?",
                Options = new List<string> {
                    "A way to define classes and methods with type parameters",
                    "A way to create objects without types",
                    "A type of collection",
                    "A way to avoid type safety"
                },
                CorrectAnswer = 0,
                Explanation = "Generics allow you to define classes, methods, and structures with type parameters, enabling type-safe code reuse."
            },
            new QuizQuestion
            {
                Id = 27,
                Topic = "ClassesAndOOP",
                Question = "What is the purpose of generic constraints in C#?",
                Options = new List<string> {
                    "To restrict the types that can be used as type arguments",
                    "To make generics faster",
                    "To allow any type to be used",
                    "To create multiple instances"
                },
                CorrectAnswer = 0,
                Explanation = "Generic constraints restrict what types can be used as type arguments, ensuring they meet certain requirements (e.g., implementing an interface, having a constructor)."
            },

            // Lesson 11: SOLID Principles
            new QuizQuestion
            {
                Id = 28,
                Topic = "ClassesAndOOP",
                Question = "What does the 'S' in SOLID stand for?",
                Options = new List<string> {
                    "Single Responsibility Principle",
                    "Simple Responsibility Principle",
                    "Static Responsibility Principle",
                    "System Responsibility Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'S' in SOLID stands for Single Responsibility Principle - a class should have only one reason to change."
            },
            new QuizQuestion
            {
                Id = 29,
                Topic = "ClassesAndOOP",
                Question = "What does the 'O' in SOLID stand for?",
                Options = new List<string> {
                    "Open/Closed Principle",
                    "Object-Oriented Principle",
                    "Overriding Principle",
                    "Optimization Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'O' in SOLID stands for Open/Closed Principle - software entities should be open for extension but closed for modification."
            },
            new QuizQuestion
            {
                Id = 30,
                Topic = "ClassesAndOOP",
                Question = "What does the 'L' in SOLID stand for?",
                Options = new List<string> {
                    "Liskov Substitution Principle",
                    "Linear Substitution Principle",
                    "Logical Substitution Principle",
                    "Language Substitution Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'L' in SOLID stands for Liskov Substitution Principle - objects of a derived class should be able to replace objects of the base class."
            },
            new QuizQuestion
            {
                Id = 31,
                Topic = "ClassesAndOOP",
                Question = "What does the 'I' in SOLID stand for?",
                Options = new List<string> {
                    "Interface Segregation Principle",
                    "Interface Substitution Principle",
                    "Implementation Segregation Principle",
                    "Inheritance Segregation Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'I' in SOLID stands for Interface Segregation Principle - clients should not be forced to depend on interfaces they don't use."
            },
            new QuizQuestion
            {
                Id = 32,
                Topic = "ClassesAndOOP",
                Question = "What does the 'D' in SOLID stand for?",
                Options = new List<string> {
                    "Dependency Inversion Principle",
                    "Dependency Integration Principle",
                    "Direct Inversion Principle",
                    "Data Inversion Principle"
                },
                CorrectAnswer = 0,
                Explanation = "The 'D' in SOLID stands for Dependency Inversion Principle - high-level modules should not depend on low-level modules; both should depend on abstractions."
            }
        };

        // ================================================================
        // WINDOWS FORMS QUIZ
        // ================================================================
        _quizzes["WindowsForms"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "WindowsForms",
                Question = "What is a Windows Forms event?",
                Options = new List<string> {
                    "A method that runs when the form loads",
                    "A way for the user to interact with the interface",
                    "A response to user actions like clicking a button",
                    "A property of a control"
                },
                CorrectAnswer = 2,
                Explanation = "Events are responses to user actions (click, hover, key press, etc.). The code runs when the event is triggered."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "WindowsForms",
                Question = "Which control is used for tabular data display?",
                Options = new List<string> { "DataGrid", "DataGridView", "ListBox", "ComboBox" },
                CorrectAnswer = 1,
                Explanation = "DataGridView is the primary control for displaying tabular data in Windows Forms applications."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "WindowsForms",
                Question = "What is the purpose of the 'using' statement in Windows Forms?",
                Options = new List<string> {
                    "To import namespaces",
                    "To automatically dispose of resources",
                    "To create a new object",
                    "To define a scope"
                },
                CorrectAnswer = 1,
                Explanation = "The 'using' statement ensures that IDisposable objects are properly disposed of when they go out of scope."
            }
        };

        // ================================================================
        // ASP.NET CORE QUIZ
        // ================================================================
        _quizzes["RazorPages"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "RazorPages",
                Question = "What is a Razor Page in ASP.NET Core?",
                Options = new List<string> {
                    "A page with only HTML",
                    "A page with .cshtml extension that combines HTML and C#",
                    "A JavaScript file",
                    "A CSS stylesheet"
                },
                CorrectAnswer = 1,
                Explanation = "Razor Pages (.cshtml) combine HTML markup with C# code using Razor syntax. It's the page-based model in ASP.NET Core."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "RazorPages",
                Question = "What is the purpose of @page in Razor Pages?",
                Options = new List<string> {
                    "It's optional",
                    "It makes the page a Razor Page endpoint",
                    "It defines a layout",
                    "It imports a namespace"
                },
                CorrectAnswer = 1,
                Explanation = "The @page directive is required and tells ASP.NET Core that this is a Razor Page endpoint."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "RazorPages",
                Question = "What is dependency injection in ASP.NET Core?",
                Options = new List<string> {
                    "Injecting dependencies into a class",
                    "Creating objects manually",
                    "A type of database",
                    "A front-end framework"
                },
                CorrectAnswer = 0,
                Explanation = "Dependency Injection is a design pattern where objects receive their dependencies from an external source rather than creating them internally."
            }
        };

        // ================================================================
        // SQL SERVER QUIZ
        // ================================================================
        _quizzes["SqlServer"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "SqlServer",
                Question = "What does SQL stand for?",
                Options = new List<string> {
                    "Structured Query Language",
                    "Standard Query Language",
                    "System Query Language",
                    "Structured Quick Language"
                },
                CorrectAnswer = 0,
                Explanation = "SQL stands for Structured Query Language. It's the standard language for managing relational databases."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "SqlServer",
                Question = "Which SQL command is used to retrieve data?",
                Options = new List<string> { "GET", "SELECT", "RETRIEVE", "FIND" },
                CorrectAnswer = 1,
                Explanation = "SELECT is the SQL command used to query and retrieve data from a database table."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "SqlServer",
                Question = "What is a primary key in SQL Server?",
                Options = new List<string> {
                    "A key that uniquely identifies each row",
                    "A key that allows duplicates",
                    "A key that is always a number",
                    "A key that is always a string"
                },
                CorrectAnswer = 0,
                Explanation = "A primary key uniquely identifies each row in a table. It cannot contain NULL values and must be unique."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "SqlServer",
                Question = "What is a foreign key in SQL Server?",
                Options = new List<string> {
                    "A key that references another table",
                    "A key that is always a string",
                    "A key that allows duplicates",
                    "A key that is optional"
                },
                CorrectAnswer = 0,
                Explanation = "A foreign key is a column or set of columns that references a primary key in another table, establishing a relationship between tables."
            }
        };

        // ================================================================
        // VS SQL CONNECTION QUIZ
        // ================================================================
        _quizzes["VsSqlConnection"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "VsSqlConnection",
                Question = "What is a connection string in C#?",
                Options = new List<string> {
                    "A string used to connect files",
                    "Information needed to connect to a database",
                    "A type of string variable",
                    "A connection between two classes"
                },
                CorrectAnswer = 1,
                Explanation = "A connection string contains the information needed to establish a connection to a database (server, database name, credentials)."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "VsSqlConnection",
                Question = "Which namespace is used for SQL Server connections in .NET?",
                Options = new List<string> { "System.Data.Sql", "Microsoft.Data.SqlClient", "System.SQL", "Data.SqlServer" },
                CorrectAnswer = 1,
                Explanation = "Microsoft.Data.SqlClient is the recommended namespace for SQL Server connections in modern .NET applications."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "VsSqlConnection",
                Question = "What is the purpose of SqlCommand in ADO.NET?",
                Options = new List<string> {
                    "To connect to the database",
                    "To execute SQL commands",
                    "To read data",
                    "To store data"
                },
                CorrectAnswer = 1,
                Explanation = "SqlCommand is used to execute SQL commands (queries, stored procedures) against the database."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "VsSqlConnection",
                Question = "What is SqlDataReader used for?",
                Options = new List<string> {
                    "To write data to the database",
                    "To read data forward-only from the database",
                    "To update data in the database",
                    "To delete data from the database"
                },
                CorrectAnswer = 1,
                Explanation = "SqlDataReader provides a fast, forward-only, read-only stream of data from the database. It's the most efficient way to read data."
            }
        };

        // ================================================================
        // .NET MAUI QUIZ
        // ================================================================
        _quizzes["DotNetMaui"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "DotNetMaui",
                Question = "What does MAUI stand for?",
                Options = new List<string> {
                    "Multi-platform App UI",
                    "Mobile App User Interface",
                    "Modern Application UI",
                    "Microsoft App UI"
                },
                CorrectAnswer = 0,
                Explanation = "MAUI stands for Multi-platform App UI. It's the evolution of Xamarin.Forms for building cross-platform apps."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "DotNetMaui",
                Question = "Which platforms does .NET MAUI support?",
                Options = new List<string> {
                    "Android, iOS, Windows, macOS",
                    "Android only",
                    "iOS only",
                    "Windows only"
                },
                CorrectAnswer = 0,
                Explanation = ".NET MAUI supports Android, iOS, Windows, and macOS from a single codebase."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "DotNetMaui",
                Question = "What is XAML in .NET MAUI?",
                Options = new List<string> {
                    "A programming language",
                    "A markup language for defining UI",
                    "A database",
                    "A web framework"
                },
                CorrectAnswer = 1,
                Explanation = "XAML (eXtensible Application Markup Language) is used to define user interfaces in .NET MAUI applications."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = "DotNetMaui",
                Question = "What is the MVVM pattern in .NET MAUI?",
                Options = new List<string> {
                    "Model-View-ViewModel",
                    "Model-View-Controller",
                    "Model-View-Presenter",
                    "Model-View-View"
                },
                CorrectAnswer = 0,
                Explanation = "MVVM stands for Model-View-ViewModel. It's a design pattern that separates the UI from the business logic."
            }
        };

        // ================================================================
        // DEPLOYMENT QUIZ
        // ================================================================
        _quizzes["Deployment"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "Deployment",
                Question = "What is CI/CD?",
                Options = new List<string> {
                    "Continuous Integration / Continuous Deployment",
                    "Code Integration / Code Deployment",
                    "Continuous Improvement / Continuous Delivery",
                    "Code Infrastructure / Code Development"
                },
                CorrectAnswer = 0,
                Explanation = "CI/CD stands for Continuous Integration and Continuous Deployment. It's a practice of automating the building, testing, and deployment of applications."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "Deployment",
                Question = "Which platform offers free hosting for ASP.NET Core applications?",
                Options = new List<string> {
                    "Azure Free Tier",
                    "Netlify",
                    "Render Free Tier",
                    "All of the above"
                },
                CorrectAnswer = 3,
                Explanation = "Azure, Netlify, and Render all offer free hosting options for ASP.NET Core applications."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "Deployment",
                Question = "What is a custom domain?",
                Options = new List<string> {
                    "A domain name owned by the user",
                    "A default domain provided by hosting",
                    "A subdomain",
                    "A free domain"
                },
                CorrectAnswer = 0,
                Explanation = "A custom domain is a domain name that the user owns (like yourdomain.com) instead of using the default domain provided by the hosting service."
            }
        };

        // ================================================================
        // SECURITY QUIZ
        // ================================================================
        _quizzes["Security"] = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Topic = "Security",
                Question = "What is HTTPS?",
                Options = new List<string> {
                    "Hypertext Transfer Protocol Secure",
                    "Hypertext Transfer Protocol Standard",
                    "Hypertext Transfer Protocol Simple",
                    "Hypertext Transfer Protocol System"
                },
                CorrectAnswer = 0,
                Explanation = "HTTPS is the secure version of HTTP. It encrypts data between the client and server using SSL/TLS."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = "Security",
                Question = "What is SQL Injection?",
                Options = new List<string> {
                    "A type of database backup",
                    "A security vulnerability where SQL code is injected",
                    "A database optimization technique",
                    "A SQL query optimization"
                },
                CorrectAnswer = 1,
                Explanation = "SQL Injection is a security vulnerability where an attacker injects malicious SQL code into a query through user input."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = "Security",
                Question = "How can you prevent SQL Injection in C#?",
                Options = new List<string> {
                    "By using parameterized queries",
                    "By using string concatenation",
                    "By using dynamic SQL",
                    "By using hard-coded values"
                },
                CorrectAnswer = 0,
                Explanation = "Using parameterized queries (or an ORM) prevents SQL injection by separating SQL code from data."
            }
        };
    }

    public List<QuizQuestion> GetQuizQuestions(string topic)
    {
        if (_quizzes.TryGetValue(topic, out var questions))
        {
            return questions;
        }
        return new List<QuizQuestion>();
    }

    public QuizResult EvaluateQuiz(List<QuizQuestion> questions, List<int> userAnswers)
    {
        var result = new QuizResult
        {
            TotalQuestions = questions.Count,
            CorrectAnswers = 0,
            AnswerDetails = new List<QuizAnswerResult>()
        };

        for (int i = 0; i < questions.Count && i < userAnswers.Count; i++)
        {
            var isCorrect = questions[i].CorrectAnswer == userAnswers[i];
            if (isCorrect) result.CorrectAnswers++;

            result.AnswerDetails.Add(new QuizAnswerResult
            {
                QuestionId = questions[i].Id,
                Question = questions[i].Question,
                UserAnswer = userAnswers[i],
                CorrectAnswer = questions[i].CorrectAnswer,
                IsCorrect = isCorrect,
                Explanation = questions[i].Explanation
            });
        }

        result.Score = result.TotalQuestions > 0
            ? (int)Math.Round((double)result.CorrectAnswers / result.TotalQuestions * 100)
            : 0;

        result.Grade = result.Score switch
        {
            >= 90 => "Excellent! 🏆",
            >= 70 => "Good job! 👍",
            >= 50 => "Keep learning! 📚",
            _ => "Review the material again! 🔄"
        };

        return result;
    }
}