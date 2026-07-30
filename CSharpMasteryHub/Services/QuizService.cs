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
        // SQL SERVER - LESSON 1: SSMS Interface Tour
        // ================================================================
        _quizzes["SqlServer_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson1",
        Question = "What is SSMS used for?",
        Options = new List<string> {
            "Managing SQL Server databases",
            "Writing C# code",
            "Building websites",
            "Creating mobile apps"
        },
        CorrectAnswer = 0,
        Explanation = "SSMS (SQL Server Management Studio) is used to manage SQL Server databases."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson1",
        Question = "What is the purpose of Object Explorer in SSMS?",
        Options = new List<string> {
            "To navigate and manage database objects",
            "To write queries",
            "To debug code",
            "To design web pages"
        },
        CorrectAnswer = 0,
        Explanation = "Object Explorer shows all servers, databases, and objects in a tree view for easy navigation."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson1",
        Question = "What command checks the SQL Server version?",
        Options = new List<string> {
            "SELECT @@VERSION",
            "SELECT VERSION",
            "SHOW VERSION",
            "GET VERSION"
        },
        CorrectAnswer = 0,
        Explanation = "SELECT @@VERSION returns the SQL Server version information."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson1",
        Question = "What shortcut runs a query in SSMS?",
        Options = new List<string> {
            "F5",
            "Ctrl+S",
            "F10",
            "Ctrl+R"
        },
        CorrectAnswer = 0,
        Explanation = "F5 executes the current query in SSMS."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson1",
        Question = "Which databases are system databases in SQL Server?",
        Options = new List<string> {
            "master, model, msdb, tempdb",
            "user1, user2, user3",
            "system1, system2",
            "data1, data2, data3"
        },
        CorrectAnswer = 0,
        Explanation = "The system databases are master, model, msdb, and tempdb."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 2: Databases and Tables
        // ================================================================
        _quizzes["SqlServer_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson2",
        Question = "What command creates a new database?",
        Options = new List<string> {
            "CREATE DATABASE",
            "NEW DATABASE",
            "ADD DATABASE",
            "MAKE DATABASE"
        },
        CorrectAnswer = 0,
        Explanation = "CREATE DATABASE is the command to create a new database."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson2",
        Question = "What does IDENTITY(1,1) do in a table definition?",
        Options = new List<string> {
            "Auto-increments the column starting from 1",
            "Creates a primary key",
            "Adds a foreign key",
            "Makes the column nullable"
        },
        CorrectAnswer = 0,
        Explanation = "IDENTITY(1,1) makes the column auto-increment starting at 1 and incrementing by 1."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson2",
        Question = "What is the purpose of a PRIMARY KEY?",
        Options = new List<string> {
            "Uniquely identifies each row",
            "Links two tables together",
            "Allows duplicate values",
            "Speeds up queries"
        },
        CorrectAnswer = 0,
        Explanation = "A PRIMARY KEY uniquely identifies each row in a table."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson2",
        Question = "What does NOT NULL mean in SQL?",
        Options = new List<string> {
            "The column cannot be empty",
            "The column can be empty",
            "The column must be unique",
            "The column is a primary key"
        },
        CorrectAnswer = 0,
        Explanation = "NOT NULL means the column must have a value and cannot be empty."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson2",
        Question = "What command shows the structure of a table?",
        Options = new List<string> {
            "EXEC sp_help 'TableName'",
            "SHOW TABLE TableName",
            "DESCRIBE TableName",
            "VIEW TableName"
        },
        CorrectAnswer = 0,
        Explanation = "EXEC sp_help 'TableName' shows the structure and columns of a table."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "SqlServer_Lesson2",
        Question = "What does UNIQUE do in SQL?",
        Options = new List<string> {
            "Ensures no two rows have the same value in that column",
            "Allows duplicate values",
            "Creates a primary key",
            "Creates a foreign key"
        },
        CorrectAnswer = 0,
        Explanation = "UNIQUE ensures all values in the column are different (no duplicates)."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 3: Data Types & Constraints
        // ================================================================
        _quizzes["SqlServer_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson3",
        Question = "Which data type is used for whole numbers?",
        Options = new List<string> {
            "INT",
            "DECIMAL",
            "NVARCHAR",
            "DATE"
        },
        CorrectAnswer = 0,
        Explanation = "INT is used for whole numbers."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson3",
        Question = "Which data type is used for text with variable length?",
        Options = new List<string> {
            "NVARCHAR",
            "INT",
            "DECIMAL",
            "BIT"
        },
        CorrectAnswer = 0,
        Explanation = "NVARCHAR is used for variable-length Unicode text."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson3",
        Question = "Which data type is used for money/decimal values?",
        Options = new List<string> {
            "DECIMAL",
            "INT",
            "NVARCHAR",
            "DATE"
        },
        CorrectAnswer = 0,
        Explanation = "DECIMAL is used for exact money and decimal values."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson3",
        Question = "What is the purpose of a CHECK constraint?",
        Options = new List<string> {
            "Restricts values to a valid range",
            "Creates a primary key",
            "Creates a foreign key",
            "Allows null values"
        },
        CorrectAnswer = 0,
        Explanation = "A CHECK constraint restricts values to a valid range or condition."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson3",
        Question = "What is the purpose of a FOREIGN KEY constraint?",
        Options = new List<string> {
            "Enforces that a value must exist in another table",
            "Creates a primary key",
            "Restricts values to a range",
            "Allows duplicates"
        },
        CorrectAnswer = 0,
        Explanation = "A FOREIGN KEY enforces referential integrity - the value must exist in another table."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "SqlServer_Lesson3",
        Question = "What is DECIMAL(10,2) used for?",
        Options = new List<string> {
            "Numbers with 10 total digits and 2 decimal places",
            "Numbers with 10 decimal places",
            "Numbers up to 10",
            "Text with 10 characters"
        },
        CorrectAnswer = 0,
        Explanation = "DECIMAL(10,2) has 10 total digits with 2 digits after the decimal point."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 4: SELECT, WHERE, ORDER BY
        // ================================================================
        _quizzes["SqlServer_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson4",
        Question = "What does SELECT * FROM Students do?",
        Options = new List<string> {
            "Returns all columns from the Students table",
            "Returns only the first column",
            "Deletes the Students table",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "SELECT * returns all columns from the specified table."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson4",
        Question = "What is the purpose of WHERE in SQL?",
        Options = new List<string> {
            "Filters rows based on a condition",
            "Sorts the results",
            "Groups the results",
            "Adds new rows"
        },
        CorrectAnswer = 0,
        Explanation = "WHERE filters rows based on a condition."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson4",
        Question = "What does ORDER BY do?",
        Options = new List<string> {
            "Sorts the results",
            "Filters the results",
            "Groups the results",
            "Adds new rows"
        },
        CorrectAnswer = 0,
        Explanation = "ORDER BY sorts the results in ascending (ASC) or descending (DESC) order."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson4",
        Question = "What does ORDER BY LastName DESC do?",
        Options = new List<string> {
            "Sorts by LastName in descending order",
            "Sorts by LastName in ascending order",
            "Filters by LastName",
            "Deletes rows with LastName"
        },
        CorrectAnswer = 0,
        Explanation = "ORDER BY LastName DESC sorts the results by LastName in descending order (Z to A)."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson4",
        Question = "Which clause filters rows based on a condition?",
        Options = new List<string> {
            "WHERE",
            "ORDER BY",
            "SELECT",
            "GROUP BY"
        },
        CorrectAnswer = 0,
        Explanation = "WHERE is used to filter rows based on a condition."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 5: Joins
        // ================================================================
        _quizzes["SqlServer_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson5",
        Question = "What does INNER JOIN do?",
        Options = new List<string> {
            "Returns only matching rows from both tables",
            "Returns all rows from the left table",
            "Returns all rows from both tables",
            "Deletes matching rows"
        },
        CorrectAnswer = 0,
        Explanation = "INNER JOIN returns only rows that have matching values in both tables."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson5",
        Question = "What does LEFT JOIN do?",
        Options = new List<string> {
            "Returns all rows from the left table, matched or not",
            "Returns only matching rows",
            "Returns all rows from both tables",
            "Returns only rows from the right table"
        },
        CorrectAnswer = 0,
        Explanation = "LEFT JOIN returns all rows from the left table, with NULL for non-matching rows on the right."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson5",
        Question = "When should you use LEFT JOIN?",
        Options = new List<string> {
            "When you want all rows from the main table even if there's no match",
            "When you only want matching rows",
            "When you want to delete data",
            "When you want to insert data"
        },
        CorrectAnswer = 0,
        Explanation = "Use LEFT JOIN when you want everything from your main table even when there's no match."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson5",
        Question = "What is the difference between INNER JOIN and LEFT JOIN?",
        Options = new List<string> {
            "INNER JOIN returns only matches, LEFT JOIN returns all rows from the left table",
            "They are the same",
            "INNER JOIN is faster",
            "LEFT JOIN is faster"
        },
        CorrectAnswer = 0,
        Explanation = "INNER JOIN returns only matching rows. LEFT JOIN returns all rows from the left table."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson5",
        Question = "Which join returns all rows from both tables, matched where possible?",
        Options = new List<string> {
            "FULL JOIN",
            "INNER JOIN",
            "LEFT JOIN",
            "RIGHT JOIN"
        },
        CorrectAnswer = 0,
        Explanation = "FULL JOIN returns all rows from both tables, matched where possible."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 6: INSERT, UPDATE, DELETE
        // ================================================================
        _quizzes["SqlServer_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson6",
        Question = "What does INSERT do?",
        Options = new List<string> {
            "Adds new rows to a table",
            "Modifies existing rows",
            "Removes rows from a table",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "INSERT adds new rows to a table."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson6",
        Question = "What does UPDATE do?",
        Options = new List<string> {
            "Modifies existing rows",
            "Adds new rows",
            "Removes rows",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "UPDATE modifies existing rows in a table."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson6",
        Question = "What does DELETE do?",
        Options = new List<string> {
            "Removes rows from a table",
            "Adds new rows",
            "Modifies existing rows",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "DELETE removes rows from a table."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson6",
        Question = "What is the most important rule for UPDATE and DELETE?",
        Options = new List<string> {
            "Always use a WHERE clause",
            "Always use ORDER BY",
            "Always use SELECT first",
            "Always use JOIN"
        },
        CorrectAnswer = 0,
        Explanation = "Always use a WHERE clause with UPDATE and DELETE to avoid affecting all rows."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson6",
        Question = "How can you safely test a DELETE statement?",
        Options = new List<string> {
            "Run SELECT with the same WHERE clause first",
            "Run the DELETE and hope for the best",
            "Use a transaction",
            "Backup the database"
        },
        CorrectAnswer = 0,
        Explanation = "Test a DELETE by running SELECT with the same WHERE clause to see what will be affected."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 7: Stored Procedures
        // ================================================================
        _quizzes["SqlServer_Lesson7"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson7",
        Question = "What is a stored procedure?",
        Options = new List<string> {
            "Precompiled T-SQL saved in the database",
            "A function that returns a value",
            "A view that shows data",
            "A type of table"
        },
        CorrectAnswer = 0,
        Explanation = "A stored procedure is precompiled T-SQL saved in the database that can be called by name."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson7",
        Question = "Why use stored procedures?",
        Options = new List<string> {
            "They prevent SQL injection and improve performance",
            "They are slower than inline SQL",
            "They can't be reused",
            "They are less secure"
        },
        CorrectAnswer = 0,
        Explanation = "Stored procedures prevent SQL injection, improve performance, and are reusable."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson7",
        Question = "How do you call a stored procedure?",
        Options = new List<string> {
            "EXEC ProcedureName",
            "SELECT ProcedureName",
            "CALL ProcedureName",
            "RUN ProcedureName"
        },
        CorrectAnswer = 0,
        Explanation = "Use EXEC or EXECUTE to call a stored procedure."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson7",
        Question = "What command creates a stored procedure?",
        Options = new List<string> {
            "CREATE PROCEDURE",
            "CREATE FUNCTION",
            "CREATE VIEW",
            "CREATE TABLE"
        },
        CorrectAnswer = 0,
        Explanation = "CREATE PROCEDURE creates a stored procedure."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson7",
        Question = "How do stored procedures prevent SQL injection?",
        Options = new List<string> {
            "Parameters are never concatenated into the query text",
            "They are not executed",
            "They delete all user input",
            "They only allow SELECT statements"
        },
        CorrectAnswer = 0,
        Explanation = "Stored procedures use parameters that are never concatenated into the query text, preventing SQL injection."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 8: Functions & Views
        // ================================================================
        _quizzes["SqlServer_Lesson8"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson8",
        Question = "What is a scalar function?",
        Options = new List<string> {
            "A function that returns a single value",
            "A function that returns a table",
            "A function that returns a view",
            "A function that returns nothing"
        },
        CorrectAnswer = 0,
        Explanation = "A scalar function returns a single value."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson8",
        Question = "What is a view in SQL Server?",
        Options = new List<string> {
            "A saved query that acts like a virtual table",
            "A stored procedure",
            "A function",
            "A physical table"
        },
        CorrectAnswer = 0,
        Explanation = "A view is a saved query that acts like a virtual table for SELECT operations."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson8",
        Question = "What is a table-valued function?",
        Options = new List<string> {
            "A function that returns a table",
            "A function that returns a single value",
            "A function that returns a view",
            "A function that returns nothing"
        },
        CorrectAnswer = 0,
        Explanation = "A table-valued function returns a table that can be used in SELECT statements."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson8",
        Question = "Can you use WHERE on a view?",
        Options = new List<string> {
            "Yes, views behave like tables for SELECT",
            "No, views cannot be filtered",
            "Only with stored procedures",
            "Only with functions"
        },
        CorrectAnswer = 0,
        Explanation = "Yes, you can use WHERE on a view just like a regular table."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson8",
        Question = "What is the difference between a view and a table?",
        Options = new List<string> {
            "A view is a saved query, a table stores data",
            "A view stores data, a table is a query",
            "They are the same",
            "Views are faster than tables"
        },
        CorrectAnswer = 0,
        Explanation = "A view is a saved query that shows live data. A table physically stores data."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 9: Indexes & Performance
        // ================================================================
        _quizzes["SqlServer_Lesson9"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson9",
        Question = "What is the purpose of an index?",
        Options = new List<string> {
            "To speed up data retrieval",
            "To slow down queries",
            "To delete data",
            "To store data"
        },
        CorrectAnswer = 0,
        Explanation = "An index speeds up data retrieval by helping SQL Server find rows without scanning the entire table."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson9",
        Question = "What is the downside of having too many indexes?",
        Options = new List<string> {
            "They slow down INSERT, UPDATE, and DELETE",
            "They speed up everything",
            "They have no downside",
            "They use no storage"
        },
        CorrectAnswer = 0,
        Explanation = "Indexes speed up reads but slow down writes because the index must be maintained."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson9",
        Question = "Which columns should you index?",
        Options = new List<string> {
            "Columns you frequently filter or sort by",
            "All columns",
            "Only primary keys",
            "Only foreign keys"
        },
        CorrectAnswer = 0,
        Explanation = "Index columns you frequently use in WHERE clauses and ORDER BY."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson9",
        Question = "What is a composite index?",
        Options = new List<string> {
            "An index on multiple columns",
            "An index on one column",
            "An index that is always unique",
            "An index on a view"
        },
        CorrectAnswer = 0,
        Explanation = "A composite index is an index on multiple columns."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson9",
        Question = "Does a PRIMARY KEY have an index automatically?",
        Options = new List<string> {
            "Yes, SQL Server creates one automatically",
            "No, you must create one manually",
            "Only for VARCHAR columns",
            "Only for INT columns"
        },
        CorrectAnswer = 0,
        Explanation = "SQL Server automatically creates a clustered index on PRIMARY KEY columns."
    }
};

        // ================================================================
        // SQL SERVER - LESSON 10: Transactions
        // ================================================================
        _quizzes["SqlServer_Lesson10"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer_Lesson10",
        Question = "What is a transaction?",
        Options = new List<string> {
            "A group of statements that all succeed or fail together",
            "A single statement",
            "A type of index",
            "A view"
        },
        CorrectAnswer = 0,
        Explanation = "A transaction groups multiple statements so they all succeed or all fail together."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer_Lesson10",
        Question = "What does COMMIT do?",
        Options = new List<string> {
            "Saves the transaction permanently",
            "Undoes the transaction",
            "Cancels the transaction",
            "Pauses the transaction"
        },
        CorrectAnswer = 0,
        Explanation = "COMMIT saves the transaction permanently to the database."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer_Lesson10",
        Question = "What does ROLLBACK do?",
        Options = new List<string> {
            "Undoes all changes in the transaction",
            "Saves the transaction",
            "Pauses the transaction",
            "Starts a new transaction"
        },
        CorrectAnswer = 0,
        Explanation = "ROLLBACK undoes all changes made in the current transaction."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer_Lesson10",
        Question = "What does the 'A' in ACID stand for?",
        Options = new List<string> {
            "Atomicity",
            "Availability",
            "Accuracy",
            "Authenticity"
        },
        CorrectAnswer = 0,
        Explanation = "Atomicity means all statements in a transaction succeed or none do."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer_Lesson10",
        Question = "What does the 'D' in ACID stand for?",
        Options = new List<string> {
            "Durability",
            "Data",
            "Database",
            "Default"
        },
        CorrectAnswer = 0,
        Explanation = "Durability means once a transaction is committed, changes survive a crash."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "SqlServer_Lesson10",
        Question = "What should you use to handle errors in a transaction?",
        Options = new List<string> {
            "TRY-CATCH with ROLLBACK",
            "Ignore errors",
            "COMMIT on error",
            "DELETE on error"
        },
        CorrectAnswer = 0,
        Explanation = "Use TRY-CATCH with ROLLBACK in the CATCH block to handle errors in a transaction."
    }
};

        // ================================================================
        // SQL SERVER - FULL SECTION (All 54 Questions)
        // ================================================================
        _quizzes["SqlServer"] = new List<QuizQuestion>
{
    // ===== LESSON 1: SSMS Interface Tour (5 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "SqlServer",
        Question = "What is SSMS used for?",
        Options = new List<string> {
            "Managing SQL Server databases",
            "Writing C# code",
            "Building websites",
            "Creating mobile apps"
        },
        CorrectAnswer = 0,
        Explanation = "SSMS (SQL Server Management Studio) is used to manage SQL Server databases."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "SqlServer",
        Question = "What is the purpose of Object Explorer in SSMS?",
        Options = new List<string> {
            "To navigate and manage database objects",
            "To write queries",
            "To debug code",
            "To design web pages"
        },
        CorrectAnswer = 0,
        Explanation = "Object Explorer shows all servers, databases, and objects in a tree view for easy navigation."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "SqlServer",
        Question = "What command checks the SQL Server version?",
        Options = new List<string> {
            "SELECT @@VERSION",
            "SELECT VERSION",
            "SHOW VERSION",
            "GET VERSION"
        },
        CorrectAnswer = 0,
        Explanation = "SELECT @@VERSION returns the SQL Server version information."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "SqlServer",
        Question = "What shortcut runs a query in SSMS?",
        Options = new List<string> {
            "F5",
            "Ctrl+S",
            "F10",
            "Ctrl+R"
        },
        CorrectAnswer = 0,
        Explanation = "F5 executes the current query in SSMS."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "SqlServer",
        Question = "Which databases are system databases in SQL Server?",
        Options = new List<string> {
            "master, model, msdb, tempdb",
            "user1, user2, user3",
            "system1, system2",
            "data1, data2, data3"
        },
        CorrectAnswer = 0,
        Explanation = "The system databases are master, model, msdb, and tempdb."
    },

    // ===== LESSON 2: Databases and Tables (6 Questions) =====
    new QuizQuestion
    {
        Id = 6,
        Topic = "SqlServer",
        Question = "What command creates a new database?",
        Options = new List<string> {
            "CREATE DATABASE",
            "NEW DATABASE",
            "ADD DATABASE",
            "MAKE DATABASE"
        },
        CorrectAnswer = 0,
        Explanation = "CREATE DATABASE is the command to create a new database."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "SqlServer",
        Question = "What does IDENTITY(1,1) do in a table definition?",
        Options = new List<string> {
            "Auto-increments the column starting from 1",
            "Creates a primary key",
            "Adds a foreign key",
            "Makes the column nullable"
        },
        CorrectAnswer = 0,
        Explanation = "IDENTITY(1,1) makes the column auto-increment starting at 1 and incrementing by 1."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "SqlServer",
        Question = "What is the purpose of a PRIMARY KEY?",
        Options = new List<string> {
            "Uniquely identifies each row",
            "Links two tables together",
            "Allows duplicate values",
            "Speeds up queries"
        },
        CorrectAnswer = 0,
        Explanation = "A PRIMARY KEY uniquely identifies each row in a table."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "SqlServer",
        Question = "What does NOT NULL mean in SQL?",
        Options = new List<string> {
            "The column cannot be empty",
            "The column can be empty",
            "The column must be unique",
            "The column is a primary key"
        },
        CorrectAnswer = 0,
        Explanation = "NOT NULL means the column must have a value and cannot be empty."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "SqlServer",
        Question = "What command shows the structure of a table?",
        Options = new List<string> {
            "EXEC sp_help 'TableName'",
            "SHOW TABLE TableName",
            "DESCRIBE TableName",
            "VIEW TableName"
        },
        CorrectAnswer = 0,
        Explanation = "EXEC sp_help 'TableName' shows the structure and columns of a table."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "SqlServer",
        Question = "What does UNIQUE do in SQL?",
        Options = new List<string> {
            "Ensures no two rows have the same value in that column",
            "Allows duplicate values",
            "Creates a primary key",
            "Creates a foreign key"
        },
        CorrectAnswer = 0,
        Explanation = "UNIQUE ensures all values in the column are different (no duplicates)."
    },

    // ===== LESSON 3: Data Types & Constraints (6 Questions) =====
    new QuizQuestion
    {
        Id = 12,
        Topic = "SqlServer",
        Question = "Which data type is used for whole numbers?",
        Options = new List<string> {
            "INT",
            "DECIMAL",
            "NVARCHAR",
            "DATE"
        },
        CorrectAnswer = 0,
        Explanation = "INT is used for whole numbers."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "SqlServer",
        Question = "Which data type is used for text with variable length?",
        Options = new List<string> {
            "NVARCHAR",
            "INT",
            "DECIMAL",
            "BIT"
        },
        CorrectAnswer = 0,
        Explanation = "NVARCHAR is used for variable-length Unicode text."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "SqlServer",
        Question = "Which data type is used for money/decimal values?",
        Options = new List<string> {
            "DECIMAL",
            "INT",
            "NVARCHAR",
            "DATE"
        },
        CorrectAnswer = 0,
        Explanation = "DECIMAL is used for exact money and decimal values."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "SqlServer",
        Question = "What is the purpose of a CHECK constraint?",
        Options = new List<string> {
            "Restricts values to a valid range",
            "Creates a primary key",
            "Creates a foreign key",
            "Allows null values"
        },
        CorrectAnswer = 0,
        Explanation = "A CHECK constraint restricts values to a valid range or condition."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "SqlServer",
        Question = "What is the purpose of a FOREIGN KEY constraint?",
        Options = new List<string> {
            "Enforces that a value must exist in another table",
            "Creates a primary key",
            "Restricts values to a range",
            "Allows duplicates"
        },
        CorrectAnswer = 0,
        Explanation = "A FOREIGN KEY enforces referential integrity - the value must exist in another table."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "SqlServer",
        Question = "What is DECIMAL(10,2) used for?",
        Options = new List<string> {
            "Numbers with 10 total digits and 2 decimal places",
            "Numbers with 10 decimal places",
            "Numbers up to 10",
            "Text with 10 characters"
        },
        CorrectAnswer = 0,
        Explanation = "DECIMAL(10,2) has 10 total digits with 2 digits after the decimal point."
    },

    // ===== LESSON 4: SELECT, WHERE, ORDER BY (5 Questions) =====
    new QuizQuestion
    {
        Id = 18,
        Topic = "SqlServer",
        Question = "What does SELECT * FROM Students do?",
        Options = new List<string> {
            "Returns all columns from the Students table",
            "Returns only the first column",
            "Deletes the Students table",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "SELECT * returns all columns from the specified table."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "SqlServer",
        Question = "What is the purpose of WHERE in SQL?",
        Options = new List<string> {
            "Filters rows based on a condition",
            "Sorts the results",
            "Groups the results",
            "Adds new rows"
        },
        CorrectAnswer = 0,
        Explanation = "WHERE filters rows based on a condition."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "SqlServer",
        Question = "What does ORDER BY do?",
        Options = new List<string> {
            "Sorts the results",
            "Filters the results",
            "Groups the results",
            "Adds new rows"
        },
        CorrectAnswer = 0,
        Explanation = "ORDER BY sorts the results in ascending (ASC) or descending (DESC) order."
    },
    new QuizQuestion
    {
        Id = 21,
        Topic = "SqlServer",
        Question = "What does ORDER BY LastName DESC do?",
        Options = new List<string> {
            "Sorts by LastName in descending order",
            "Sorts by LastName in ascending order",
            "Filters by LastName",
            "Deletes rows with LastName"
        },
        CorrectAnswer = 0,
        Explanation = "ORDER BY LastName DESC sorts the results by LastName in descending order (Z to A)."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "SqlServer",
        Question = "Which clause filters rows based on a condition?",
        Options = new List<string> {
            "WHERE",
            "ORDER BY",
            "SELECT",
            "GROUP BY"
        },
        CorrectAnswer = 0,
        Explanation = "WHERE is used to filter rows based on a condition."
    },

    // ===== LESSON 5: Joins (5 Questions) =====
    new QuizQuestion
    {
        Id = 23,
        Topic = "SqlServer",
        Question = "What does INNER JOIN do?",
        Options = new List<string> {
            "Returns only matching rows from both tables",
            "Returns all rows from the left table",
            "Returns all rows from both tables",
            "Deletes matching rows"
        },
        CorrectAnswer = 0,
        Explanation = "INNER JOIN returns only rows that have matching values in both tables."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "SqlServer",
        Question = "What does LEFT JOIN do?",
        Options = new List<string> {
            "Returns all rows from the left table, matched or not",
            "Returns only matching rows",
            "Returns all rows from both tables",
            "Returns only rows from the right table"
        },
        CorrectAnswer = 0,
        Explanation = "LEFT JOIN returns all rows from the left table, with NULL for non-matching rows on the right."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "SqlServer",
        Question = "When should you use LEFT JOIN?",
        Options = new List<string> {
            "When you want all rows from the main table even if there's no match",
            "When you only want matching rows",
            "When you want to delete data",
            "When you want to insert data"
        },
        CorrectAnswer = 0,
        Explanation = "Use LEFT JOIN when you want everything from your main table even when there's no match."
    },
    new QuizQuestion
    {
        Id = 26,
        Topic = "SqlServer",
        Question = "What is the difference between INNER JOIN and LEFT JOIN?",
        Options = new List<string> {
            "INNER JOIN returns only matches, LEFT JOIN returns all rows from the left table",
            "They are the same",
            "INNER JOIN is faster",
            "LEFT JOIN is faster"
        },
        CorrectAnswer = 0,
        Explanation = "INNER JOIN returns only matching rows. LEFT JOIN returns all rows from the left table."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "SqlServer",
        Question = "Which join returns all rows from both tables, matched where possible?",
        Options = new List<string> {
            "FULL JOIN",
            "INNER JOIN",
            "LEFT JOIN",
            "RIGHT JOIN"
        },
        CorrectAnswer = 0,
        Explanation = "FULL JOIN returns all rows from both tables, matched where possible."
    },

    // ===== LESSON 6: INSERT, UPDATE, DELETE (5 Questions) =====
    new QuizQuestion
    {
        Id = 28,
        Topic = "SqlServer",
        Question = "What does INSERT do?",
        Options = new List<string> {
            "Adds new rows to a table",
            "Modifies existing rows",
            "Removes rows from a table",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "INSERT adds new rows to a table."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "SqlServer",
        Question = "What does UPDATE do?",
        Options = new List<string> {
            "Modifies existing rows",
            "Adds new rows",
            "Removes rows",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "UPDATE modifies existing rows in a table."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "SqlServer",
        Question = "What does DELETE do?",
        Options = new List<string> {
            "Removes rows from a table",
            "Adds new rows",
            "Modifies existing rows",
            "Creates a new table"
        },
        CorrectAnswer = 0,
        Explanation = "DELETE removes rows from a table."
    },
    new QuizQuestion
    {
        Id = 31,
        Topic = "SqlServer",
        Question = "What is the most important rule for UPDATE and DELETE?",
        Options = new List<string> {
            "Always use a WHERE clause",
            "Always use ORDER BY",
            "Always use SELECT first",
            "Always use JOIN"
        },
        CorrectAnswer = 0,
        Explanation = "Always use a WHERE clause with UPDATE and DELETE to avoid affecting all rows."
    },
    new QuizQuestion
    {
        Id = 32,
        Topic = "SqlServer",
        Question = "How can you safely test a DELETE statement?",
        Options = new List<string> {
            "Run SELECT with the same WHERE clause first",
            "Run the DELETE and hope for the best",
            "Use a transaction",
            "Backup the database"
        },
        CorrectAnswer = 0,
        Explanation = "Test a DELETE by running SELECT with the same WHERE clause to see what will be affected."
    },

    // ===== LESSON 7: Stored Procedures (5 Questions) =====
    new QuizQuestion
    {
        Id = 33,
        Topic = "SqlServer",
        Question = "What is a stored procedure?",
        Options = new List<string> {
            "Precompiled T-SQL saved in the database",
            "A function that returns a value",
            "A view that shows data",
            "A type of table"
        },
        CorrectAnswer = 0,
        Explanation = "A stored procedure is precompiled T-SQL saved in the database that can be called by name."
    },
    new QuizQuestion
    {
        Id = 34,
        Topic = "SqlServer",
        Question = "Why use stored procedures?",
        Options = new List<string> {
            "They prevent SQL injection and improve performance",
            "They are slower than inline SQL",
            "They can't be reused",
            "They are less secure"
        },
        CorrectAnswer = 0,
        Explanation = "Stored procedures prevent SQL injection, improve performance, and are reusable."
    },
    new QuizQuestion
    {
        Id = 35,
        Topic = "SqlServer",
        Question = "How do you call a stored procedure?",
        Options = new List<string> {
            "EXEC ProcedureName",
            "SELECT ProcedureName",
            "CALL ProcedureName",
            "RUN ProcedureName"
        },
        CorrectAnswer = 0,
        Explanation = "Use EXEC or EXECUTE to call a stored procedure."
    },
    new QuizQuestion
    {
        Id = 36,
        Topic = "SqlServer",
        Question = "What command creates a stored procedure?",
        Options = new List<string> {
            "CREATE PROCEDURE",
            "CREATE FUNCTION",
            "CREATE VIEW",
            "CREATE TABLE"
        },
        CorrectAnswer = 0,
        Explanation = "CREATE PROCEDURE creates a stored procedure."
    },
    new QuizQuestion
    {
        Id = 37,
        Topic = "SqlServer",
        Question = "How do stored procedures prevent SQL injection?",
        Options = new List<string> {
            "Parameters are never concatenated into the query text",
            "They are not executed",
            "They delete all user input",
            "They only allow SELECT statements"
        },
        CorrectAnswer = 0,
        Explanation = "Stored procedures use parameters that are never concatenated into the query text, preventing SQL injection."
    },

    // ===== LESSON 8: Functions & Views (5 Questions) =====
    new QuizQuestion
    {
        Id = 38,
        Topic = "SqlServer",
        Question = "What is a scalar function?",
        Options = new List<string> {
            "A function that returns a single value",
            "A function that returns a table",
            "A function that returns a view",
            "A function that returns nothing"
        },
        CorrectAnswer = 0,
        Explanation = "A scalar function returns a single value."
    },
    new QuizQuestion
    {
        Id = 39,
        Topic = "SqlServer",
        Question = "What is a view in SQL Server?",
        Options = new List<string> {
            "A saved query that acts like a virtual table",
            "A stored procedure",
            "A function",
            "A physical table"
        },
        CorrectAnswer = 0,
        Explanation = "A view is a saved query that acts like a virtual table for SELECT operations."
    },
    new QuizQuestion
    {
        Id = 40,
        Topic = "SqlServer",
        Question = "What is a table-valued function?",
        Options = new List<string> {
            "A function that returns a table",
            "A function that returns a single value",
            "A function that returns a view",
            "A function that returns nothing"
        },
        CorrectAnswer = 0,
        Explanation = "A table-valued function returns a table that can be used in SELECT statements."
    },
    new QuizQuestion
    {
        Id = 41,
        Topic = "SqlServer",
        Question = "Can you use WHERE on a view?",
        Options = new List<string> {
            "Yes, views behave like tables for SELECT",
            "No, views cannot be filtered",
            "Only with stored procedures",
            "Only with functions"
        },
        CorrectAnswer = 0,
        Explanation = "Yes, you can use WHERE on a view just like a regular table."
    },
    new QuizQuestion
    {
        Id = 42,
        Topic = "SqlServer",
        Question = "What is the difference between a view and a table?",
        Options = new List<string> {
            "A view is a saved query, a table stores data",
            "A view stores data, a table is a query",
            "They are the same",
            "Views are faster than tables"
        },
        CorrectAnswer = 0,
        Explanation = "A view is a saved query that shows live data. A table physically stores data."
    },

    // ===== LESSON 9: Indexes & Performance (5 Questions) =====
    new QuizQuestion
    {
        Id = 43,
        Topic = "SqlServer",
        Question = "What is the purpose of an index?",
        Options = new List<string> {
            "To speed up data retrieval",
            "To slow down queries",
            "To delete data",
            "To store data"
        },
        CorrectAnswer = 0,
        Explanation = "An index speeds up data retrieval by helping SQL Server find rows without scanning the entire table."
    },
    new QuizQuestion
    {
        Id = 44,
        Topic = "SqlServer",
        Question = "What is the downside of having too many indexes?",
        Options = new List<string> {
            "They slow down INSERT, UPDATE, and DELETE",
            "They speed up everything",
            "They have no downside",
            "They use no storage"
        },
        CorrectAnswer = 0,
        Explanation = "Indexes speed up reads but slow down writes because the index must be maintained."
    },
    new QuizQuestion
    {
        Id = 45,
        Topic = "SqlServer",
        Question = "Which columns should you index?",
        Options = new List<string> {
            "Columns you frequently filter or sort by",
            "All columns",
            "Only primary keys",
            "Only foreign keys"
        },
        CorrectAnswer = 0,
        Explanation = "Index columns you frequently use in WHERE clauses and ORDER BY."
    },
    new QuizQuestion
    {
        Id = 46,
        Topic = "SqlServer",
        Question = "What is a composite index?",
        Options = new List<string> {
            "An index on multiple columns",
            "An index on one column",
            "An index that is always unique",
            "An index on a view"
        },
        CorrectAnswer = 0,
        Explanation = "A composite index is an index on multiple columns."
    },
    new QuizQuestion
    {
        Id = 47,
        Topic = "SqlServer",
        Question = "Does a PRIMARY KEY have an index automatically?",
        Options = new List<string> {
            "Yes, SQL Server creates one automatically",
            "No, you must create one manually",
            "Only for VARCHAR columns",
            "Only for INT columns"
        },
        CorrectAnswer = 0,
        Explanation = "SQL Server automatically creates a clustered index on PRIMARY KEY columns."
    },

    // ===== LESSON 10: Transactions (6 Questions) =====
    new QuizQuestion
    {
        Id = 48,
        Topic = "SqlServer",
        Question = "What is a transaction?",
        Options = new List<string> {
            "A group of statements that all succeed or fail together",
            "A single statement",
            "A type of index",
            "A view"
        },
        CorrectAnswer = 0,
        Explanation = "A transaction groups multiple statements so they all succeed or all fail together."
    },
    new QuizQuestion
    {
        Id = 49,
        Topic = "SqlServer",
        Question = "What does COMMIT do?",
        Options = new List<string> {
            "Saves the transaction permanently",
            "Undoes the transaction",
            "Cancels the transaction",
            "Pauses the transaction"
        },
        CorrectAnswer = 0,
        Explanation = "COMMIT saves the transaction permanently to the database."
    },
    new QuizQuestion
    {
        Id = 50,
        Topic = "SqlServer",
        Question = "What does ROLLBACK do?",
        Options = new List<string> {
            "Undoes all changes in the transaction",
            "Saves the transaction",
            "Pauses the transaction",
            "Starts a new transaction"
        },
        CorrectAnswer = 0,
        Explanation = "ROLLBACK undoes all changes made in the current transaction."
    },
    new QuizQuestion
    {
        Id = 51,
        Topic = "SqlServer",
        Question = "What does the 'A' in ACID stand for?",
        Options = new List<string> {
            "Atomicity",
            "Availability",
            "Accuracy",
            "Authenticity"
        },
        CorrectAnswer = 0,
        Explanation = "Atomicity means all statements in a transaction succeed or none do."
    },
    new QuizQuestion
    {
        Id = 52,
        Topic = "SqlServer",
        Question = "What does the 'D' in ACID stand for?",
        Options = new List<string> {
            "Durability",
            "Data",
            "Database",
            "Default"
        },
        CorrectAnswer = 0,
        Explanation = "Durability means once a transaction is committed, changes survive a crash."
    },
    new QuizQuestion
    {
        Id = 53,
        Topic = "SqlServer",
        Question = "What should you use to handle errors in a transaction?",
        Options = new List<string> {
            "TRY-CATCH with ROLLBACK",
            "Ignore errors",
            "COMMIT on error",
            "DELETE on error"
        },
        CorrectAnswer = 0,
        Explanation = "Use TRY-CATCH with ROLLBACK in the CATCH block to handle errors in a transaction."
    }
};





        // ================================================================
        // SEO - LESSON 1: SEO Fundamentals
        // ================================================================
        _quizzes["Seo_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo_Lesson1",
        Question = "What does SEO stand for?",
        Options = new List<string> {
            "Search Engine Optimization",
            "Site Engine Optimization",
            "Search Engine Organization",
            "System Enhancement Operation"
        },
        CorrectAnswer = 0,
        Explanation = "SEO stands for Search Engine Optimization - the practice of improving your website to increase its visibility in search engines."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo_Lesson1",
        Question = "What are the main pillars of SEO?",
        Options = new List<string> {
            "On-Page, Off-Page, Technical, Content",
            "Title, Description, Keywords",
            "HTML, CSS, JavaScript",
            "Google, Bing, Yahoo"
        },
        CorrectAnswer = 0,
        Explanation = "The four main pillars of SEO are On-Page SEO, Off-Page SEO, Technical SEO, and Content SEO."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo_Lesson1",
        Question = "What is On-Page SEO?",
        Options = new List<string> {
            "Optimizing content and HTML elements on your website",
            "Building backlinks from other websites",
            "Optimizing server performance",
            "Creating social media posts"
        },
        CorrectAnswer = 0,
        Explanation = "On-Page SEO involves optimizing content and HTML elements on your website like titles, headings, and content."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo_Lesson1",
        Question = "What is Off-Page SEO?",
        Options = new List<string> {
            "Actions taken outside your website to improve rankings",
            "Optimizing your website content",
            "Improving website speed",
            "Creating meta tags"
        },
        CorrectAnswer = 0,
        Explanation = "Off-Page SEO includes actions taken outside your website like building backlinks and social media presence."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo_Lesson1",
        Question = "Why is SEO important?",
        Options = new List<string> {
            "Increases organic traffic and brand visibility",
            "Makes websites load faster",
            "Creates better images",
            "Writes better code"
        },
        CorrectAnswer = 0,
        Explanation = "SEO increases organic traffic, improves brand visibility, builds trust, and is cost-effective marketing."
    }
};

        // ================================================================
        // SEO - LESSON 2: Meta Tags, Title & Description
        // ================================================================
        _quizzes["Seo_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo_Lesson2",
        Question = "What is the recommended length for a title tag?",
        Options = new List<string> {
            "30-40 characters",
            "50-60 characters",
            "70-80 characters",
            "100+ characters"
        },
        CorrectAnswer = 1,
        Explanation = "Title tags should be 50-60 characters to display properly in search results."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo_Lesson2",
        Question = "What is the recommended length for a meta description?",
        Options = new List<string> {
            "50-100 characters",
            "150-160 characters",
            "200-250 characters",
            "300+ characters"
        },
        CorrectAnswer = 1,
        Explanation = "Meta descriptions should be 150-160 characters to display properly in search results."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo_Lesson2",
        Question = "What is the purpose of a meta description?",
        Options = new List<string> {
            "To describe the page content and improve CTR",
            "To hide keywords from users",
            "To make the page load faster",
            "To style the page"
        },
        CorrectAnswer = 0,
        Explanation = "Meta descriptions describe page content and improve click-through rates (CTR)."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo_Lesson2",
        Question = "What is a canonical tag used for?",
        Options = new List<string> {
            "To prevent duplicate content issues",
            "To add keywords to a page",
            "To improve page speed",
            "To create backlinks"
        },
        CorrectAnswer = 0,
        Explanation = "Canonical tags tell search engines which URL is the preferred version to prevent duplicate content issues."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo_Lesson2",
        Question = "What is the purpose of Open Graph tags?",
        Options = new List<string> {
            "To control how content appears when shared on social media",
            "To improve page speed",
            "To add keywords to a page",
            "To create backlinks"
        },
        CorrectAnswer = 0,
        Explanation = "Open Graph tags control how your content appears when shared on social media platforms."
    }
};

        // ================================================================
        // SEO - LESSON 3: Sitemap and Robots.txt
        // ================================================================
        _quizzes["Seo_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo_Lesson3",
        Question = "What is a sitemap?",
        Options = new List<string> {
            "An XML file that lists all pages on your website",
            "A map of your physical office",
            "A list of all your images",
            "A CSS file"
        },
        CorrectAnswer = 0,
        Explanation = "A sitemap is an XML file that lists all the pages on your website to help search engines crawl and index them."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo_Lesson3",
        Question = "What is Robots.txt used for?",
        Options = new List<string> {
            "To tell search engines which pages to crawl and which to avoid",
            "To tell robots how to style pages",
            "To create a sitemap",
            "To improve page speed"
        },
        CorrectAnswer = 0,
        Explanation = "Robots.txt tells search engines which pages to crawl and which to avoid."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo_Lesson3",
        Question = "Where should you place your sitemap URL in Robots.txt?",
        Options = new List<string> {
            "At the bottom of Robots.txt",
            "In the HTML head",
            "In the CSS file",
            "In the JavaScript file"
        },
        CorrectAnswer = 0,
        Explanation = "You should place your sitemap URL at the bottom of your Robots.txt file."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo_Lesson3",
        Question = "What does 'Allow' do in Robots.txt?",
        Options = new List<string> {
            "Tells search engines which pages they can crawl",
            "Tells search engines which pages to ignore",
            "Tells search engines to index all pages",
            "Tells search engines to delete pages"
        },
        CorrectAnswer = 0,
        Explanation = "The 'Allow' directive tells search engines which pages they can crawl."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo_Lesson3",
        Question = "What does 'Disallow' do in Robots.txt?",
        Options = new List<string> {
            "Tells search engines which pages they should not crawl",
            "Tells search engines which pages they can crawl",
            "Tells search engines to create a sitemap",
            "Tells search engines to delete pages"
        },
        CorrectAnswer = 0,
        Explanation = "The 'Disallow' directive tells search engines which pages they should not crawl."
    }
};

        // ================================================================
        // SEO - LESSON 4: Semantic HTML & Headings
        // ================================================================
        _quizzes["Seo_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo_Lesson4",
        Question = "What is semantic HTML?",
        Options = new List<string> {
            "HTML elements that convey meaning about their content",
            "HTML that is written in a specific style",
            "HTML that includes CSS",
            "HTML that includes JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "Semantic HTML uses HTML elements that convey meaning about the content they contain."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo_Lesson4",
        Question = "Which element represents the main navigation of a page?",
        Options = new List<string> {
            "<nav>",
            "<header>",
            "<main>",
            "<footer>"
        },
        CorrectAnswer = 0,
        Explanation = "The <nav> element represents the main navigation of a page."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo_Lesson4",
        Question = "How many H1 tags should a page have?",
        Options = new List<string> {
            "Only one H1 per page",
            "As many as needed",
            "One per section",
            "None is fine"
        },
        CorrectAnswer = 0,
        Explanation = "Each page should have only one H1 tag for proper heading structure."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo_Lesson4",
        Question = "Why is semantic HTML important for SEO?",
        Options = new List<string> {
            "Helps search engines understand content structure",
            "Makes pages load faster",
            "Creates backlinks",
            "Adds keywords"
        },
        CorrectAnswer = 0,
        Explanation = "Semantic HTML helps search engines understand content structure and improves accessibility."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo_Lesson4",
        Question = "Which element represents the main content area of a page?",
        Options = new List<string> {
            "<main>",
            "<header>",
            "<nav>",
            "<footer>"
        },
        CorrectAnswer = 0,
        Explanation = "The <main> element represents the main content area of a page."
    }
};

        // ================================================================
        // SEO - LESSON 5: Page Speed & Core Web Vitals
        // ================================================================
        _quizzes["Seo_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo_Lesson5",
        Question = "What is Largest Contentful Paint (LCP)?",
        Options = new List<string> {
            "Measures loading performance",
            "Measures interactivity",
            "Measures visual stability",
            "Measures page size"
        },
        CorrectAnswer = 0,
        Explanation = "LCP measures loading performance and should be under 2.5 seconds."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo_Lesson5",
        Question = "What is First Input Delay (FID)?",
        Options = new List<string> {
            "Measures interactivity",
            "Measures loading performance",
            "Measures visual stability",
            "Measures page size"
        },
        CorrectAnswer = 0,
        Explanation = "FID measures interactivity and should be under 100 milliseconds."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo_Lesson5",
        Question = "What is Cumulative Layout Shift (CLS)?",
        Options = new List<string> {
            "Measures visual stability",
            "Measures loading performance",
            "Measures interactivity",
            "Measures page size"
        },
        CorrectAnswer = 0,
        Explanation = "CLS measures visual stability and should be under 0.1."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo_Lesson5",
        Question = "What tool does Google provide to measure page speed?",
        Options = new List<string> {
            "PageSpeed Insights",
            "Google Analytics",
            "Google Ads",
            "Google Trends"
        },
        CorrectAnswer = 0,
        Explanation = "PageSpeed Insights is Google's tool for measuring page speed and Core Web Vitals."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo_Lesson5",
        Question = "What is a good LCP score?",
        Options = new List<string> {
            "Under 2.5 seconds",
            "Under 5 seconds",
            "Under 10 seconds",
            "Under 1 second"
        },
        CorrectAnswer = 0,
        Explanation = "A good LCP score is under 2.5 seconds."
    }
};

        // ================================================================
        // SEO - LESSON 6: Google Search Console
        // ================================================================
        _quizzes["Seo_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo_Lesson6",
        Question = "What is Google Search Console?",
        Options = new List<string> {
            "A free tool to monitor your site's presence in Google search",
            "A paid advertising tool",
            "A social media management tool",
            "A web hosting service"
        },
        CorrectAnswer = 0,
        Explanation = "Google Search Console is a free tool that helps you monitor and maintain your site's presence in Google search results."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo_Lesson6",
        Question = "What can you do in Google Search Console?",
        Options = new List<string> {
            "Submit sitemaps and monitor performance",
            "Create websites",
            "Design graphics",
            "Write code"
        },
        CorrectAnswer = 0,
        Explanation = "You can submit sitemaps, monitor performance, check coverage, and view Core Web Vitals data."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo_Lesson6",
        Question = "What does CTR stand for in Search Console?",
        Options = new List<string> {
            "Click-Through Rate",
            "Content Type Ratio",
            "Code Test Review",
            "Create Track Response"
        },
        CorrectAnswer = 0,
        Explanation = "CTR stands for Click-Through Rate - the percentage of people who click on your result."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo_Lesson6",
        Question = "Where can you check Core Web Vitals in Search Console?",
        Options = new List<string> {
            "Experience → Core Web Vitals",
            "Performance → Core Web Vitals",
            "Coverage → Core Web Vitals",
            "Settings → Core Web Vitals"
        },
        CorrectAnswer = 0,
        Explanation = "You can check Core Web Vitals under Experience → Core Web Vitals in Search Console."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo_Lesson6",
        Question = "Why should you verify your site in Search Console?",
        Options = new List<string> {
            "To access data about your site's performance",
            "To get a free domain",
            "To create social media accounts",
            "To design your website"
        },
        CorrectAnswer = 0,
        Explanation = "Verifying your site in Search Console allows you to access data about your site's performance in search results."
    }
};

        // ================================================================
        // SEO - FULL SECTION (All 30 Questions)
        // ================================================================
        _quizzes["Seo"] = new List<QuizQuestion>
{
    // ===== LESSON 1: SEO Fundamentals (5 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "Seo",
        Question = "What does SEO stand for?",
        Options = new List<string> {
            "Search Engine Optimization",
            "Site Engine Optimization",
            "Search Engine Organization",
            "System Enhancement Operation"
        },
        CorrectAnswer = 0,
        Explanation = "SEO stands for Search Engine Optimization - the practice of improving your website to increase its visibility in search engines."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Seo",
        Question = "What are the main pillars of SEO?",
        Options = new List<string> {
            "On-Page, Off-Page, Technical, Content",
            "Title, Description, Keywords",
            "HTML, CSS, JavaScript",
            "Google, Bing, Yahoo"
        },
        CorrectAnswer = 0,
        Explanation = "The four main pillars of SEO are On-Page SEO, Off-Page SEO, Technical SEO, and Content SEO."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Seo",
        Question = "What is On-Page SEO?",
        Options = new List<string> {
            "Optimizing content and HTML elements on your website",
            "Building backlinks from other websites",
            "Optimizing server performance",
            "Creating social media posts"
        },
        CorrectAnswer = 0,
        Explanation = "On-Page SEO involves optimizing content and HTML elements on your website like titles, headings, and content."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Seo",
        Question = "What is Off-Page SEO?",
        Options = new List<string> {
            "Actions taken outside your website to improve rankings",
            "Optimizing your website content",
            "Improving website speed",
            "Creating meta tags"
        },
        CorrectAnswer = 0,
        Explanation = "Off-Page SEO includes actions taken outside your website like building backlinks and social media presence."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Seo",
        Question = "Why is SEO important?",
        Options = new List<string> {
            "Increases organic traffic and brand visibility",
            "Makes websites load faster",
            "Creates better images",
            "Writes better code"
        },
        CorrectAnswer = 0,
        Explanation = "SEO increases organic traffic, improves brand visibility, builds trust, and is cost-effective marketing."
    },

    // ===== LESSON 2: Meta Tags, Title & Description (5 Questions) =====
    new QuizQuestion
    {
        Id = 6,
        Topic = "Seo",
        Question = "What is the recommended length for a title tag?",
        Options = new List<string> {
            "30-40 characters",
            "50-60 characters",
            "70-80 characters",
            "100+ characters"
        },
        CorrectAnswer = 1,
        Explanation = "Title tags should be 50-60 characters to display properly in search results."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Seo",
        Question = "What is the recommended length for a meta description?",
        Options = new List<string> {
            "50-100 characters",
            "150-160 characters",
            "200-250 characters",
            "300+ characters"
        },
        CorrectAnswer = 1,
        Explanation = "Meta descriptions should be 150-160 characters to display properly in search results."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "Seo",
        Question = "What is the purpose of a meta description?",
        Options = new List<string> {
            "To describe the page content and improve CTR",
            "To hide keywords from users",
            "To make the page load faster",
            "To style the page"
        },
        CorrectAnswer = 0,
        Explanation = "Meta descriptions describe page content and improve click-through rates (CTR)."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "Seo",
        Question = "What is a canonical tag used for?",
        Options = new List<string> {
            "To prevent duplicate content issues",
            "To add keywords to a page",
            "To improve page speed",
            "To create backlinks"
        },
        CorrectAnswer = 0,
        Explanation = "Canonical tags tell search engines which URL is the preferred version to prevent duplicate content issues."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "Seo",
        Question = "What is the purpose of Open Graph tags?",
        Options = new List<string> {
            "To control how content appears when shared on social media",
            "To improve page speed",
            "To add keywords to a page",
            "To create backlinks"
        },
        CorrectAnswer = 0,
        Explanation = "Open Graph tags control how your content appears when shared on social media platforms."
    },

    // ===== LESSON 3: Sitemap and Robots.txt (5 Questions) =====
    new QuizQuestion
    {
        Id = 11,
        Topic = "Seo",
        Question = "What is a sitemap?",
        Options = new List<string> {
            "An XML file that lists all pages on your website",
            "A map of your physical office",
            "A list of all your images",
            "A CSS file"
        },
        CorrectAnswer = 0,
        Explanation = "A sitemap is an XML file that lists all the pages on your website to help search engines crawl and index them."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "Seo",
        Question = "What is Robots.txt used for?",
        Options = new List<string> {
            "To tell search engines which pages to crawl and which to avoid",
            "To tell robots how to style pages",
            "To create a sitemap",
            "To improve page speed"
        },
        CorrectAnswer = 0,
        Explanation = "Robots.txt tells search engines which pages to crawl and which to avoid."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "Seo",
        Question = "Where should you place your sitemap URL in Robots.txt?",
        Options = new List<string> {
            "At the bottom of Robots.txt",
            "In the HTML head",
            "In the CSS file",
            "In the JavaScript file"
        },
        CorrectAnswer = 0,
        Explanation = "You should place your sitemap URL at the bottom of your Robots.txt file."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "Seo",
        Question = "What does 'Allow' do in Robots.txt?",
        Options = new List<string> {
            "Tells search engines which pages they can crawl",
            "Tells search engines which pages to ignore",
            "Tells search engines to index all pages",
            "Tells search engines to delete pages"
        },
        CorrectAnswer = 0,
        Explanation = "The 'Allow' directive tells search engines which pages they can crawl."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "Seo",
        Question = "What does 'Disallow' do in Robots.txt?",
        Options = new List<string> {
            "Tells search engines which pages they should not crawl",
            "Tells search engines which pages they can crawl",
            "Tells search engines to create a sitemap",
            "Tells search engines to delete pages"
        },
        CorrectAnswer = 0,
        Explanation = "The 'Disallow' directive tells search engines which pages they should not crawl."
    },

    // ===== LESSON 4: Semantic HTML & Headings (5 Questions) =====
    new QuizQuestion
    {
        Id = 16,
        Topic = "Seo",
        Question = "What is semantic HTML?",
        Options = new List<string> {
            "HTML elements that convey meaning about their content",
            "HTML that is written in a specific style",
            "HTML that includes CSS",
            "HTML that includes JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "Semantic HTML uses HTML elements that convey meaning about the content they contain."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "Seo",
        Question = "Which element represents the main navigation of a page?",
        Options = new List<string> {
            "<nav>",
            "<header>",
            "<main>",
            "<footer>"
        },
        CorrectAnswer = 0,
        Explanation = "The <nav> element represents the main navigation of a page."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "Seo",
        Question = "How many H1 tags should a page have?",
        Options = new List<string> {
            "Only one H1 per page",
            "As many as needed",
            "One per section",
            "None is fine"
        },
        CorrectAnswer = 0,
        Explanation = "Each page should have only one H1 tag for proper heading structure."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "Seo",
        Question = "Why is semantic HTML important for SEO?",
        Options = new List<string> {
            "Helps search engines understand content structure",
            "Makes pages load faster",
            "Creates backlinks",
            "Adds keywords"
        },
        CorrectAnswer = 0,
        Explanation = "Semantic HTML helps search engines understand content structure and improves accessibility."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "Seo",
        Question = "Which element represents the main content area of a page?",
        Options = new List<string> {
            "<main>",
            "<header>",
            "<nav>",
            "<footer>"
        },
        CorrectAnswer = 0,
        Explanation = "The <main> element represents the main content area of a page."
    },

    // ===== LESSON 5: Page Speed & Core Web Vitals (5 Questions) =====
    new QuizQuestion
    {
        Id = 21,
        Topic = "Seo",
        Question = "What is Largest Contentful Paint (LCP)?",
        Options = new List<string> {
            "Measures loading performance",
            "Measures interactivity",
            "Measures visual stability",
            "Measures page size"
        },
        CorrectAnswer = 0,
        Explanation = "LCP measures loading performance and should be under 2.5 seconds."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "Seo",
        Question = "What is First Input Delay (FID)?",
        Options = new List<string> {
            "Measures interactivity",
            "Measures loading performance",
            "Measures visual stability",
            "Measures page size"
        },
        CorrectAnswer = 0,
        Explanation = "FID measures interactivity and should be under 100 milliseconds."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "Seo",
        Question = "What is Cumulative Layout Shift (CLS)?",
        Options = new List<string> {
            "Measures visual stability",
            "Measures loading performance",
            "Measures interactivity",
            "Measures page size"
        },
        CorrectAnswer = 0,
        Explanation = "CLS measures visual stability and should be under 0.1."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "Seo",
        Question = "What tool does Google provide to measure page speed?",
        Options = new List<string> {
            "PageSpeed Insights",
            "Google Analytics",
            "Google Ads",
            "Google Trends"
        },
        CorrectAnswer = 0,
        Explanation = "PageSpeed Insights is Google's tool for measuring page speed and Core Web Vitals."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "Seo",
        Question = "What is a good LCP score?",
        Options = new List<string> {
            "Under 2.5 seconds",
            "Under 5 seconds",
            "Under 10 seconds",
            "Under 1 second"
        },
        CorrectAnswer = 0,
        Explanation = "A good LCP score is under 2.5 seconds."
    },

    // ===== LESSON 6: Google Search Console (5 Questions) =====
    new QuizQuestion
    {
        Id = 26,
        Topic = "Seo",
        Question = "What is Google Search Console?",
        Options = new List<string> {
            "A free tool to monitor your site's presence in Google search",
            "A paid advertising tool",
            "A social media management tool",
            "A web hosting service"
        },
        CorrectAnswer = 0,
        Explanation = "Google Search Console is a free tool that helps you monitor and maintain your site's presence in Google search results."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "Seo",
        Question = "What can you do in Google Search Console?",
        Options = new List<string> {
            "Submit sitemaps and monitor performance",
            "Create websites",
            "Design graphics",
            "Write code"
        },
        CorrectAnswer = 0,
        Explanation = "You can submit sitemaps, monitor performance, check coverage, and view Core Web Vitals data."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "Seo",
        Question = "What does CTR stand for in Search Console?",
        Options = new List<string> {
            "Click-Through Rate",
            "Content Type Ratio",
            "Code Test Review",
            "Create Track Response"
        },
        CorrectAnswer = 0,
        Explanation = "CTR stands for Click-Through Rate - the percentage of people who click on your result."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "Seo",
        Question = "Where can you check Core Web Vitals in Search Console?",
        Options = new List<string> {
            "Experience → Core Web Vitals",
            "Performance → Core Web Vitals",
            "Coverage → Core Web Vitals",
            "Settings → Core Web Vitals"
        },
        CorrectAnswer = 0,
        Explanation = "You can check Core Web Vitals under Experience → Core Web Vitals in Search Console."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "Seo",
        Question = "Why should you verify your site in Search Console?",
        Options = new List<string> {
            "To access data about your site's performance",
            "To get a free domain",
            "To create social media accounts",
            "To design your website"
        },
        CorrectAnswer = 0,
        Explanation = "Verifying your site in Search Console allows you to access data about your site's performance in search results."
    }
};
        // ================================================================
        // SECURITY - LESSON 1: HTTPS and Certificates
        // ================================================================
        _quizzes["Security_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security_Lesson1",
        Question = "Why is HTTPS important for websites?",
        Options = new List<string> {
            "It encrypts data between client and server",
            "It prevents man-in-the-middle attacks",
            "It builds user trust",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "HTTPS encrypts data, prevents man-in-the-middle attacks, builds user trust, and is required for SEO."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security_Lesson1",
        Question = "What does HSTS stand for?",
        Options = new List<string> {
            "HTTP Strict Transport Security",
            "HTTP Secure Transfer System",
            "Hypertext Secure Transport Service",
            "HTTP Standard Transfer Security"
        },
        CorrectAnswer = 0,
        Explanation = "HSTS stands for HTTP Strict Transport Security, which forces browsers to use HTTPS."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security_Lesson1",
        Question = "Which service provides free SSL certificates?",
        Options = new List<string> {
            "Let's Encrypt",
            "SSL.com",
            "Verisign",
            "Symantec"
        },
        CorrectAnswer = 0,
        Explanation = "Let's Encrypt provides free SSL/TLS certificates automatically."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security_Lesson1",
        Question = "What does app.UseHttpsRedirection() do?",
        Options = new List<string> {
            "Redirects HTTP to HTTPS",
            "Redirects HTTPS to HTTP",
            "Disables HTTPS",
            "Creates a certificate"
        },
        CorrectAnswer = 0,
        Explanation = "app.UseHttpsRedirection() redirects all HTTP requests to HTTPS."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security_Lesson1",
        Question = "Which Azure feature provides free SSL certificates?",
        Options = new List<string> {
            "App Service Managed Certificate",
            "Azure Key Vault",
            "Azure Active Directory",
            "Azure Functions"
        },
        CorrectAnswer = 0,
        Explanation = "Azure App Service Managed Certificate provides free SSL certificates for your domains."
    }
};

        // ================================================================
        // SECURITY - LESSON 2: Authentication & Identity
        // ================================================================
        _quizzes["Security_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security_Lesson2",
        Question = "What is ASP.NET Core Identity?",
        Options = new List<string> {
            "A membership system for authentication and authorization",
            "A database system",
            "A web framework",
            "A cloud service"
        },
        CorrectAnswer = 0,
        Explanation = "ASP.NET Core Identity is a membership system for adding authentication and authorization to your application."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security_Lesson2",
        Question = "What is the purpose of UserManager in ASP.NET Core Identity?",
        Options = new List<string> {
            "To manage user creation and password operations",
            "To manage database connections",
            "To manage HTTP requests",
            "To manage file uploads"
        },
        CorrectAnswer = 0,
        Explanation = "UserManager is used to manage user creation, password operations, and other user-related tasks."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security_Lesson2",
        Question = "What does the SignInManager do?",
        Options = new List<string> {
            "Handles user sign-in and sign-out",
            "Manages database queries",
            "Handles HTTP responses",
            "Manages file storage"
        },
        CorrectAnswer = 0,
        Explanation = "SignInManager handles user sign-in, sign-out, and authentication cookie management."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security_Lesson2",
        Question = "Which attribute is used to restrict access based on roles?",
        Options = new List<string> {
            "[Authorize]",
            "[Authenticate]",
            "[AllowAnonymous]",
            "[Role]"
        },
        CorrectAnswer = 0,
        Explanation = "[Authorize(Roles = 'Admin')] restricts access to users with the specified role."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security_Lesson2",
        Question = "What is the purpose of password hashing in Identity?",
        Options = new List<string> {
            "To securely store passwords",
            "To make passwords shorter",
            "To display passwords in plain text",
            "To delete passwords"
        },
        CorrectAnswer = 0,
        Explanation = "Password hashing securely stores passwords so they cannot be read even if the database is compromised."
    }
};

        // ================================================================
        // SECURITY - LESSON 3: SQL Injection Prevention
        // ================================================================
        _quizzes["Security_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security_Lesson3",
        Question = "What is SQL Injection?",
        Options = new List<string> {
            "A type of database backup",
            "A security vulnerability where malicious SQL code is injected",
            "A database optimization technique",
            "A SQL query optimization"
        },
        CorrectAnswer = 1,
        Explanation = "SQL Injection is a security vulnerability where an attacker injects malicious SQL code into a query through user input."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security_Lesson3",
        Question = "How can you prevent SQL Injection in C#?",
        Options = new List<string> {
            "By using parameterized queries",
            "By using string concatenation",
            "By using dynamic SQL",
            "By using hard-coded values"
        },
        CorrectAnswer = 0,
        Explanation = "Using parameterized queries (or an ORM) prevents SQL injection by separating SQL code from data."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security_Lesson3",
        Question = "Which method in ADO.NET prevents SQL injection?",
        Options = new List<string> {
            "Using SqlCommand with parameters",
            "Using string concatenation",
            "Using dynamic SQL",
            "Using inline queries"
        },
        CorrectAnswer = 0,
        Explanation = "SqlCommand with parameters safely separates SQL code from user input, preventing injection."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security_Lesson3",
        Question = "Does Entity Framework Core prevent SQL Injection?",
        Options = new List<string> {
            "Yes, it automatically parameterizes queries",
            "No, it is vulnerable",
            "Only with stored procedures",
            "Only in development"
        },
        CorrectAnswer = 0,
        Explanation = "EF Core automatically parameterizes LINQ queries, preventing SQL injection."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security_Lesson3",
        Question = "What is a best practice for validating user input?",
        Options = new List<string> {
            "Validate and sanitize all user input",
            "Accept all input without validation",
            "Only validate numbers",
            "Only validate emails"
        },
        CorrectAnswer = 0,
        Explanation = "Always validate and sanitize all user input to prevent injection attacks."
    }
};

        // ================================================================
        // SECURITY - LESSON 4: XSS & CSRF Protection
        // ================================================================
        _quizzes["Security_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security_Lesson4",
        Question = "What is Cross-Site Scripting (XSS)?",
        Options = new List<string> {
            "Malicious scripts injected into trusted websites",
            "A type of database backup",
            "A network protocol",
            "A CSS framework"
        },
        CorrectAnswer = 0,
        Explanation = "XSS occurs when malicious scripts are injected into trusted websites."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security_Lesson4",
        Question = "How does Razor Pages prevent XSS?",
        Options = new List<string> {
            "By automatically encoding output",
            "By deleting scripts",
            "By blocking JavaScript",
            "By disabling HTML"
        },
        CorrectAnswer = 0,
        Explanation = "Razor Pages automatically HTML-encodes output, preventing XSS attacks."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security_Lesson4",
        Question = "What is Cross-Site Request Forgery (CSRF)?",
        Options = new List<string> {
            "Tricking a user into performing unwanted actions",
            "A type of virus",
            "A network attack",
            "A database attack"
        },
        CorrectAnswer = 0,
        Explanation = "CSRF tricks a user into performing unwanted actions on a website where they're authenticated."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security_Lesson4",
        Question = "How does ASP.NET Core prevent CSRF?",
        Options = new List<string> {
            "Using anti-forgery tokens",
            "Using passwords",
            "Using email verification",
            "Using cookies"
        },
        CorrectAnswer = 0,
        Explanation = "ASP.NET Core uses anti-forgery tokens (__RequestVerificationToken) to prevent CSRF attacks."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security_Lesson4",
        Question = "What does the [ValidateAntiForgeryToken] attribute do?",
        Options = new List<string> {
            "Validates the anti-forgery token in POST requests",
            "Validates user login",
            "Validates email addresses",
            "Validates passwords"
        },
        CorrectAnswer = 0,
        Explanation = "[ValidateAntiForgeryToken] validates the anti-forgery token to prevent CSRF attacks."
    }
};

        // ================================================================
        // SECURITY - LESSON 5: Security Headers
        // ================================================================
        _quizzes["Security_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security_Lesson5",
        Question = "What are security headers?",
        Options = new List<string> {
            "HTTP response headers that instruct browsers on secure behavior",
            "Database headers",
            "CSS headers",
            "JavaScript headers"
        },
        CorrectAnswer = 0,
        Explanation = "Security headers are HTTP response headers that tell browsers how to behave securely."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security_Lesson5",
        Question = "What does the Content-Security-Policy (CSP) header do?",
        Options = new List<string> {
            "Specifies allowed content sources",
            "Blocks all content",
            "Allows all content",
            "Disables CSS"
        },
        CorrectAnswer = 0,
        Explanation = "CSP specifies which content sources (scripts, styles, images) are allowed to load."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security_Lesson5",
        Question = "What does X-Frame-Options: DENY do?",
        Options = new List<string> {
            "Prevents the page from being displayed in frames",
            "Allows the page in all frames",
            "Redirects to HTTPS",
            "Enables JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "X-Frame-Options: DENY prevents clickjacking attacks by blocking the page from being displayed in frames."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security_Lesson5",
        Question = "What is the purpose of X-Content-Type-Options: nosniff?",
        Options = new List<string> {
            "Prevents MIME type sniffing",
            "Allows MIME type sniffing",
            "Disables CSS",
            "Enables JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "X-Content-Type-Options: nosniff prevents browsers from MIME-type sniffing, reducing attack vectors."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security_Lesson5",
        Question = "What does the Strict-Transport-Security header do?",
        Options = new List<string> {
            "Forces browsers to use HTTPS",
            "Allows HTTP only",
            "Redirects to HTTP",
            "Disables SSL"
        },
        CorrectAnswer = 0,
        Explanation = "HSTS forces browsers to always use HTTPS for the specified domain and subdomains."
    }
};

        // ================================================================
        // SECURITY - LESSON 6: Secrets Management
        // ================================================================
        _quizzes["Security_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security_Lesson6",
        Question = "What are secrets in application development?",
        Options = new List<string> {
            "Sensitive data like passwords and API keys",
            "Public data",
            "Log files",
            "Cache data"
        },
        CorrectAnswer = 0,
        Explanation = "Secrets are sensitive data like passwords, API keys, connection strings, and certificates."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security_Lesson6",
        Question = "What is User Secrets in ASP.NET Core?",
        Options = new List<string> {
            "A development-only secret storage",
            "A production secret storage",
            "A database storage",
            "A file storage"
        },
        CorrectAnswer = 0,
        Explanation = "User Secrets is a development-only feature for storing sensitive data outside the project folder."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security_Lesson6",
        Question = "What is Azure Key Vault?",
        Options = new List<string> {
            "A cloud service for storing secrets securely",
            "A web framework",
            "A database system",
            "A file storage system"
        },
        CorrectAnswer = 0,
        Explanation = "Azure Key Vault is a cloud service for securely storing and accessing secrets."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security_Lesson6",
        Question = "Which command sets a User Secret in .NET?",
        Options = new List<string> {
            "dotnet user-secrets set 'key' 'value'",
            "dotnet secret set 'key' 'value'",
            "dotnet add secret 'key' 'value'",
            "dotnet config secret 'key' 'value'"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet user-secrets set' command sets a user secret."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security_Lesson6",
        Question = "What is a best practice for managing secrets?",
        Options = new List<string> {
            "Never store secrets in code or configuration files",
            "Store secrets in appsettings.json",
            "Store secrets in comments",
            "Store secrets in logs"
        },
        CorrectAnswer = 0,
        Explanation = "Never store secrets in code or configuration files. Use environment variables, user secrets, or secure vault services."
    }
};

        // ================================================================
        // SECURITY - FULL SECTION (All 30 Questions)
        // ================================================================
        _quizzes["Security"] = new List<QuizQuestion>
{
    // ===== LESSON 1: HTTPS and Certificates (5 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "Security",
        Question = "Why is HTTPS important for websites?",
        Options = new List<string> {
            "It encrypts data between client and server",
            "It prevents man-in-the-middle attacks",
            "It builds user trust",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "HTTPS encrypts data, prevents man-in-the-middle attacks, builds user trust, and is required for SEO."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Security",
        Question = "What does HSTS stand for?",
        Options = new List<string> {
            "HTTP Strict Transport Security",
            "HTTP Secure Transfer System",
            "Hypertext Secure Transport Service",
            "HTTP Standard Transfer Security"
        },
        CorrectAnswer = 0,
        Explanation = "HSTS stands for HTTP Strict Transport Security, which forces browsers to use HTTPS."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Security",
        Question = "Which service provides free SSL certificates?",
        Options = new List<string> {
            "Let's Encrypt",
            "SSL.com",
            "Verisign",
            "Symantec"
        },
        CorrectAnswer = 0,
        Explanation = "Let's Encrypt provides free SSL/TLS certificates automatically."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Security",
        Question = "What does app.UseHttpsRedirection() do?",
        Options = new List<string> {
            "Redirects HTTP to HTTPS",
            "Redirects HTTPS to HTTP",
            "Disables HTTPS",
            "Creates a certificate"
        },
        CorrectAnswer = 0,
        Explanation = "app.UseHttpsRedirection() redirects all HTTP requests to HTTPS."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Security",
        Question = "Which Azure feature provides free SSL certificates?",
        Options = new List<string> {
            "App Service Managed Certificate",
            "Azure Key Vault",
            "Azure Active Directory",
            "Azure Functions"
        },
        CorrectAnswer = 0,
        Explanation = "Azure App Service Managed Certificate provides free SSL certificates for your domains."
    },

    // ===== LESSON 2: Authentication & Identity (5 Questions) =====
    new QuizQuestion
    {
        Id = 6,
        Topic = "Security",
        Question = "What is ASP.NET Core Identity?",
        Options = new List<string> {
            "A membership system for authentication and authorization",
            "A database system",
            "A web framework",
            "A cloud service"
        },
        CorrectAnswer = 0,
        Explanation = "ASP.NET Core Identity is a membership system for adding authentication and authorization to your application."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Security",
        Question = "What is the purpose of UserManager in ASP.NET Core Identity?",
        Options = new List<string> {
            "To manage user creation and password operations",
            "To manage database connections",
            "To manage HTTP requests",
            "To manage file uploads"
        },
        CorrectAnswer = 0,
        Explanation = "UserManager is used to manage user creation, password operations, and other user-related tasks."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "Security",
        Question = "What does the SignInManager do?",
        Options = new List<string> {
            "Handles user sign-in and sign-out",
            "Manages database queries",
            "Handles HTTP responses",
            "Manages file storage"
        },
        CorrectAnswer = 0,
        Explanation = "SignInManager handles user sign-in, sign-out, and authentication cookie management."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "Security",
        Question = "Which attribute is used to restrict access based on roles?",
        Options = new List<string> {
            "[Authorize]",
            "[Authenticate]",
            "[AllowAnonymous]",
            "[Role]"
        },
        CorrectAnswer = 0,
        Explanation = "[Authorize(Roles = 'Admin')] restricts access to users with the specified role."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "Security",
        Question = "What is the purpose of password hashing in Identity?",
        Options = new List<string> {
            "To securely store passwords",
            "To make passwords shorter",
            "To display passwords in plain text",
            "To delete passwords"
        },
        CorrectAnswer = 0,
        Explanation = "Password hashing securely stores passwords so they cannot be read even if the database is compromised."
    },

    // ===== LESSON 3: SQL Injection Prevention (5 Questions) =====
    new QuizQuestion
    {
        Id = 11,
        Topic = "Security",
        Question = "What is SQL Injection?",
        Options = new List<string> {
            "A type of database backup",
            "A security vulnerability where malicious SQL code is injected",
            "A database optimization technique",
            "A SQL query optimization"
        },
        CorrectAnswer = 1,
        Explanation = "SQL Injection is a security vulnerability where an attacker injects malicious SQL code into a query through user input."
    },
    new QuizQuestion
    {
        Id = 12,
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
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "Security",
        Question = "Which method in ADO.NET prevents SQL injection?",
        Options = new List<string> {
            "Using SqlCommand with parameters",
            "Using string concatenation",
            "Using dynamic SQL",
            "Using inline queries"
        },
        CorrectAnswer = 0,
        Explanation = "SqlCommand with parameters safely separates SQL code from user input, preventing injection."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "Security",
        Question = "Does Entity Framework Core prevent SQL Injection?",
        Options = new List<string> {
            "Yes, it automatically parameterizes queries",
            "No, it is vulnerable",
            "Only with stored procedures",
            "Only in development"
        },
        CorrectAnswer = 0,
        Explanation = "EF Core automatically parameterizes LINQ queries, preventing SQL injection."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "Security",
        Question = "What is a best practice for validating user input?",
        Options = new List<string> {
            "Validate and sanitize all user input",
            "Accept all input without validation",
            "Only validate numbers",
            "Only validate emails"
        },
        CorrectAnswer = 0,
        Explanation = "Always validate and sanitize all user input to prevent injection attacks."
    },

    // ===== LESSON 4: XSS & CSRF Protection (5 Questions) =====
    new QuizQuestion
    {
        Id = 16,
        Topic = "Security",
        Question = "What is Cross-Site Scripting (XSS)?",
        Options = new List<string> {
            "Malicious scripts injected into trusted websites",
            "A type of database backup",
            "A network protocol",
            "A CSS framework"
        },
        CorrectAnswer = 0,
        Explanation = "XSS occurs when malicious scripts are injected into trusted websites."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "Security",
        Question = "How does Razor Pages prevent XSS?",
        Options = new List<string> {
            "By automatically encoding output",
            "By deleting scripts",
            "By blocking JavaScript",
            "By disabling HTML"
        },
        CorrectAnswer = 0,
        Explanation = "Razor Pages automatically HTML-encodes output, preventing XSS attacks."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "Security",
        Question = "What is Cross-Site Request Forgery (CSRF)?",
        Options = new List<string> {
            "Tricking a user into performing unwanted actions",
            "A type of virus",
            "A network attack",
            "A database attack"
        },
        CorrectAnswer = 0,
        Explanation = "CSRF tricks a user into performing unwanted actions on a website where they're authenticated."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "Security",
        Question = "How does ASP.NET Core prevent CSRF?",
        Options = new List<string> {
            "Using anti-forgery tokens",
            "Using passwords",
            "Using email verification",
            "Using cookies"
        },
        CorrectAnswer = 0,
        Explanation = "ASP.NET Core uses anti-forgery tokens (__RequestVerificationToken) to prevent CSRF attacks."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "Security",
        Question = "What does the [ValidateAntiForgeryToken] attribute do?",
        Options = new List<string> {
            "Validates the anti-forgery token in POST requests",
            "Validates user login",
            "Validates email addresses",
            "Validates passwords"
        },
        CorrectAnswer = 0,
        Explanation = "[ValidateAntiForgeryToken] validates the anti-forgery token to prevent CSRF attacks."
    },

    // ===== LESSON 5: Security Headers (5 Questions) =====
    new QuizQuestion
    {
        Id = 21,
        Topic = "Security",
        Question = "What are security headers?",
        Options = new List<string> {
            "HTTP response headers that instruct browsers on secure behavior",
            "Database headers",
            "CSS headers",
            "JavaScript headers"
        },
        CorrectAnswer = 0,
        Explanation = "Security headers are HTTP response headers that tell browsers how to behave securely."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "Security",
        Question = "What does the Content-Security-Policy (CSP) header do?",
        Options = new List<string> {
            "Specifies allowed content sources",
            "Blocks all content",
            "Allows all content",
            "Disables CSS"
        },
        CorrectAnswer = 0,
        Explanation = "CSP specifies which content sources (scripts, styles, images) are allowed to load."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "Security",
        Question = "What does X-Frame-Options: DENY do?",
        Options = new List<string> {
            "Prevents the page from being displayed in frames",
            "Allows the page in all frames",
            "Redirects to HTTPS",
            "Enables JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "X-Frame-Options: DENY prevents clickjacking attacks by blocking the page from being displayed in frames."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "Security",
        Question = "What is the purpose of X-Content-Type-Options: nosniff?",
        Options = new List<string> {
            "Prevents MIME type sniffing",
            "Allows MIME type sniffing",
            "Disables CSS",
            "Enables JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "X-Content-Type-Options: nosniff prevents browsers from MIME-type sniffing, reducing attack vectors."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "Security",
        Question = "What does the Strict-Transport-Security header do?",
        Options = new List<string> {
            "Forces browsers to use HTTPS",
            "Allows HTTP only",
            "Redirects to HTTP",
            "Disables SSL"
        },
        CorrectAnswer = 0,
        Explanation = "HSTS forces browsers to always use HTTPS for the specified domain and subdomains."
    },

    // ===== LESSON 6: Secrets Management (5 Questions) =====
    new QuizQuestion
    {
        Id = 26,
        Topic = "Security",
        Question = "What are secrets in application development?",
        Options = new List<string> {
            "Sensitive data like passwords and API keys",
            "Public data",
            "Log files",
            "Cache data"
        },
        CorrectAnswer = 0,
        Explanation = "Secrets are sensitive data like passwords, API keys, connection strings, and certificates."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "Security",
        Question = "What is User Secrets in ASP.NET Core?",
        Options = new List<string> {
            "A development-only secret storage",
            "A production secret storage",
            "A database storage",
            "A file storage"
        },
        CorrectAnswer = 0,
        Explanation = "User Secrets is a development-only feature for storing sensitive data outside the project folder."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "Security",
        Question = "What is Azure Key Vault?",
        Options = new List<string> {
            "A cloud service for storing secrets securely",
            "A web framework",
            "A database system",
            "A file storage system"
        },
        CorrectAnswer = 0,
        Explanation = "Azure Key Vault is a cloud service for securely storing and accessing secrets."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "Security",
        Question = "Which command sets a User Secret in .NET?",
        Options = new List<string> {
            "dotnet user-secrets set 'key' 'value'",
            "dotnet secret set 'key' 'value'",
            "dotnet add secret 'key' 'value'",
            "dotnet config secret 'key' 'value'"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet user-secrets set' command sets a user secret."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "Security",
        Question = "What is a best practice for managing secrets?",
        Options = new List<string> {
            "Never store secrets in code or configuration files",
            "Store secrets in appsettings.json",
            "Store secrets in comments",
            "Store secrets in logs"
        },
        CorrectAnswer = 0,
        Explanation = "Never store secrets in code or configuration files. Use environment variables, user secrets, or secure vault services."
    }
};





        // ================================================================
        // RDLC REPORTS - LESSON 1: What Is RDLC
        // ================================================================
        _quizzes["RdlcReports_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RdlcReports_Lesson1",
        Question = "What does RDLC stand for?",
        Options = new List<string> {
            "Report Definition Language Client-side",
            "Report Design Language Client-side",
            "Report Definition Language Central",
            "Report Display Language Client-side"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC stands for Report Definition Language Client-side. It is a file format used to create reports in .NET applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RdlcReports_Lesson1",
        Question = "What is RDLC used for?",
        Options = new List<string> {
            "Creating databases",
            "Creating professional reports in .NET applications",
            "Building websites",
            "Making mobile apps"
        },
        CorrectAnswer = 1,
        Explanation = "RDLC is used to create professional, printable reports in .NET applications like Windows Forms."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RdlcReports_Lesson1",
        Question = "What is the difference between RDLC and RDL?",
        Options = new List<string> {
            "RDLC runs on your computer, RDL runs on a server",
            "RDLC runs on a server, RDL runs on your computer",
            "They are the same thing",
            "RDLC is for web, RDL is for desktop"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC runs on your computer (client-side) with local processing. RDL runs on a server with SQL Server Reporting Services."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RdlcReports_Lesson1",
        Question = "What can you do with RDLC reports?",
        Options = new List<string> {
            "Show data in tables and charts",
            "Export to PDF and Excel",
            "Print reports directly",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "RDLC reports can show data in tables and charts, export to PDF and Excel, and print directly from your application."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RdlcReports_Lesson1",
        Question = "Which type of application is RDLC best for?",
        Options = new List<string> {
            "Web applications",
            "Desktop applications (Windows Forms)",
            "Mobile applications",
            "Console applications"
        },
        CorrectAnswer = 1,
        Explanation = "RDLC is best for desktop applications (Windows Forms) where you need to show and print reports."
    }
};
        // ================================================================
        // RDLC REPORTS - LESSON 2: Creating Dataset
        // ================================================================
        _quizzes["RdlcReports_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RdlcReports_Lesson2",
        Question = "What is a dataset in RDLC?",
        Options = new List<string> {
            "A container that holds your report data",
            "A type of report",
            "A database table",
            "A visual control"
        },
        CorrectAnswer = 0,
        Explanation = "A dataset is a container that holds your data for the report. It defines what columns you have and what type of data they hold."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RdlcReports_Lesson2",
        Question = "What file extension is used for a typed dataset?",
        Options = new List<string> {
            ".rdlc",
            ".xsd",
            ".cs",
            ".sql"
        },
        CorrectAnswer = 1,
        Explanation = "A typed dataset uses the .xsd file extension (XML Schema Definition)."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RdlcReports_Lesson2",
        Question = "How do you add a new DataTable to a dataset?",
        Options = new List<string> {
            "Right-click the designer → Add → DataTable",
            "Write code only",
            "Add a new file",
            "Copy from another dataset"
        },
        CorrectAnswer = 0,
        Explanation = "You can add a new DataTable by right-clicking on the designer and selecting Add → DataTable."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RdlcReports_Lesson2",
        Question = "What is the purpose of a DataAdapter?",
        Options = new List<string> {
            "To fill a dataset with data from a database",
            "To design the report layout",
            "To create the report file",
            "To format the report"
        },
        CorrectAnswer = 0,
        Explanation = "A DataAdapter is used to fill a DataSet with data from a database."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RdlcReports_Lesson2",
        Question = "How do you add data to a DataTable in code?",
        Options = new List<string> {
            "Using table.Rows.Add()",
            "Using table.AddRow()",
            "Using table.Insert()",
            "Using table.CreateRow()"
        },
        CorrectAnswer = 0,
        Explanation = "You add data to a DataTable using the Rows.Add() method."
    }
};
        // ================================================================
        // RDLC REPORTS - LESSON 3: Designing Report
        // ================================================================
        _quizzes["RdlcReports_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RdlcReports_Lesson3",
        Question = "What file extension is used for an RDLC report?",
        Options = new List<string> {
            ".rdlc",
            ".rdl",
            ".rpt",
            ".report"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC report files use the .rdlc file extension."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RdlcReports_Lesson3",
        Question = "What control is used to display tabular data in a report?",
        Options = new List<string> {
            "Label",
            "TextBox",
            "Table",
            "List"
        },
        CorrectAnswer = 2,
        Explanation = "The Table control is used to display tabular data in an RDLC report."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RdlcReports_Lesson3",
        Question = "How do you reference a field from your dataset in the report?",
        Options = new List<string> {
            "=Fields!FieldName.Value",
            "=Data!FieldName.Value",
            "=FieldName.Value",
            "=Values.FieldName"
        },
        CorrectAnswer = 0,
        Explanation = "You reference a field using the syntax =Fields!FieldName.Value."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RdlcReports_Lesson3",
        Question = "Where do you find the Report Data panel in Visual Studio?",
        Options = new List<string> {
            "View → Report Data",
            "Tools → Report Data",
            "Project → Report Data",
            "Debug → Report Data"
        },
        CorrectAnswer = 0,
        Explanation = "The Report Data panel is found under View → Report Data in Visual Studio."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RdlcReports_Lesson3",
        Question = "How do you format a price as currency in an RDLC report?",
        Options = new List<string> {
            "=Format(Fields!Price.Value, 'C')",
            "=Fields!Price.Value.ToString('C')",
            "=Currency(Fields!Price.Value)",
            "=FormatCurrency(Fields!Price.Value)"
        },
        CorrectAnswer = 0,
        Explanation = "You format a price as currency using =Format(Fields!Price.Value, 'C')."
    }
};
        // ================================================================
        // RDLC REPORTS - LESSON 4: Binding Report to Form
        // ================================================================
        _quizzes["RdlcReports_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RdlcReports_Lesson4",
        Question = "What control is used to display RDLC reports in Windows Forms?",
        Options = new List<string> {
            "ReportViewer",
            "DataGridView",
            "ListView",
            "GridView"
        },
        CorrectAnswer = 0,
        Explanation = "The ReportViewer control is used to display RDLC reports in Windows Forms."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RdlcReports_Lesson4",
        Question = "What NuGet package do you need for the ReportViewer control?",
        Options = new List<string> {
            "Microsoft.ReportingServices.ReportViewerControl.WinForms",
            "Microsoft.ReportViewer",
            "ReportViewer.WinForms",
            "Microsoft.Reporting.WinForms"
        },
        CorrectAnswer = 0,
        Explanation = "You need the Microsoft.ReportingServices.ReportViewerControl.WinForms NuGet package."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RdlcReports_Lesson4",
        Question = "What is the processing mode for RDLC reports?",
        Options = new List<string> {
            "ProcessingMode.Local",
            "ProcessingMode.Server",
            "ProcessingMode.Client",
            "ProcessingMode.Online"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC reports use ProcessingMode.Local because they are processed on the client-side."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RdlcReports_Lesson4",
        Question = "How do you load an RDLC report in code?",
        Options = new List<string> {
            "reportViewer.LocalReport.ReportPath = 'Report.rdlc'",
            "reportViewer.ReportPath = 'Report.rdlc'",
            "reportViewer.LoadReport('Report.rdlc')",
            "reportViewer.OpenReport('Report.rdlc')"
        },
        CorrectAnswer = 0,
        Explanation = "You load an RDLC report using reportViewer.LocalReport.ReportPath = 'Report.rdlc'."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RdlcReports_Lesson4",
        Question = "What method refreshes the report display?",
        Options = new List<string> {
            "reportViewer.RefreshReport()",
            "reportViewer.Refresh()",
            "reportViewer.Update()",
            "reportViewer.Reload()"
        },
        CorrectAnswer = 0,
        Explanation = "The RefreshReport() method refreshes the report display."
    }
};

        // ================================================================
        // RDLC REPORTS - LESSON 5: Full Report Project with SQL
        // ================================================================
        _quizzes["RdlcReports_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RdlcReports_Lesson5",
        Question = "What is a foreign key used for in a database?",
        Options = new List<string> {
            "To link one table to another",
            "To create a primary key",
            "To create a new table",
            "To delete data"
        },
        CorrectAnswer = 0,
        Explanation = "A foreign key is used to link one table to another, creating a relationship between them."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RdlcReports_Lesson5",
        Question = "What command creates a new table in SQL Server?",
        Options = new List<string> {
            "CREATE TABLE",
            "NEW TABLE",
            "INSERT TABLE",
            "ADD TABLE"
        },
        CorrectAnswer = 0,
        Explanation = "The CREATE TABLE command is used to create a new table in SQL Server."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RdlcReports_Lesson5",
        Question = "What is the purpose of IDENTITY in SQL Server?",
        Options = new List<string> {
            "To automatically generate unique numbers",
            "To create a new table",
            "To delete data",
            "To add a foreign key"
        },
        CorrectAnswer = 0,
        Explanation = "IDENTITY is used to automatically generate unique numbers for a column, like an ID."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RdlcReports_Lesson5",
        Question = "How do you export a report to PDF?",
        Options = new List<string> {
            "Using LocalReport.Render('PDF')",
            "Using reportViewer.ExportPDF()",
            "Using File.Save()",
            "Using PrintToPDF()"
        },
        CorrectAnswer = 0,
        Explanation = "You export to PDF using LocalReport.Render('PDF') which returns a byte array."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RdlcReports_Lesson5",
        Question = "What is the benefit of using a service class for reports?",
        Options = new List<string> {
            "It keeps your code organized and reusable",
            "It makes the code run faster",
            "It uses less memory",
            "It automatically creates reports"
        },
        CorrectAnswer = 0,
        Explanation = "A service class keeps your report-related code organized and reusable across your application."
    }
};

        // ================================================================
        // RDLC REPORTS - FULL SECTION (All 25 Questions)
        // ================================================================
        _quizzes["RdlcReports"] = new List<QuizQuestion>
{
    // ===== LESSON 1: What Is RDLC (5 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "RdlcReports",
        Question = "What does RDLC stand for?",
        Options = new List<string> {
            "Report Definition Language Client-side",
            "Report Design Language Client-side",
            "Report Definition Language Central",
            "Report Display Language Client-side"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC stands for Report Definition Language Client-side. It is a file format used to create reports in .NET applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RdlcReports",
        Question = "What is RDLC used for?",
        Options = new List<string> {
            "Creating databases",
            "Creating professional reports in .NET applications",
            "Building websites",
            "Making mobile apps"
        },
        CorrectAnswer = 1,
        Explanation = "RDLC is used to create professional, printable reports in .NET applications like Windows Forms."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RdlcReports",
        Question = "What is the difference between RDLC and RDL?",
        Options = new List<string> {
            "RDLC runs on your computer, RDL runs on a server",
            "RDLC runs on a server, RDL runs on your computer",
            "They are the same thing",
            "RDLC is for web, RDL is for desktop"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC runs on your computer (client-side) with local processing. RDL runs on a server with SQL Server Reporting Services."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RdlcReports",
        Question = "What can you do with RDLC reports?",
        Options = new List<string> {
            "Show data in tables and charts",
            "Export to PDF and Excel",
            "Print reports directly",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "RDLC reports can show data in tables and charts, export to PDF and Excel, and print directly from your application."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RdlcReports",
        Question = "Which type of application is RDLC best for?",
        Options = new List<string> {
            "Web applications",
            "Desktop applications (Windows Forms)",
            "Mobile applications",
            "Console applications"
        },
        CorrectAnswer = 1,
        Explanation = "RDLC is best for desktop applications (Windows Forms) where you need to show and print reports."
    },

    // ===== LESSON 2: Creating Dataset (5 Questions) =====
    new QuizQuestion
    {
        Id = 6,
        Topic = "RdlcReports",
        Question = "What is a dataset in RDLC?",
        Options = new List<string> {
            "A container that holds your report data",
            "A type of report",
            "A database table",
            "A visual control"
        },
        CorrectAnswer = 0,
        Explanation = "A dataset is a container that holds your data for the report. It defines what columns you have and what type of data they hold."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "RdlcReports",
        Question = "What file extension is used for a typed dataset?",
        Options = new List<string> {
            ".rdlc",
            ".xsd",
            ".cs",
            ".sql"
        },
        CorrectAnswer = 1,
        Explanation = "A typed dataset uses the .xsd file extension (XML Schema Definition)."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "RdlcReports",
        Question = "How do you add a new DataTable to a dataset?",
        Options = new List<string> {
            "Right-click the designer → Add → DataTable",
            "Write code only",
            "Add a new file",
            "Copy from another dataset"
        },
        CorrectAnswer = 0,
        Explanation = "You can add a new DataTable by right-clicking on the designer and selecting Add → DataTable."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "RdlcReports",
        Question = "What is the purpose of a DataAdapter?",
        Options = new List<string> {
            "To fill a dataset with data from a database",
            "To design the report layout",
            "To create the report file",
            "To format the report"
        },
        CorrectAnswer = 0,
        Explanation = "A DataAdapter is used to fill a DataSet with data from a database."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "RdlcReports",
        Question = "How do you add data to a DataTable in code?",
        Options = new List<string> {
            "Using table.Rows.Add()",
            "Using table.AddRow()",
            "Using table.Insert()",
            "Using table.CreateRow()"
        },
        CorrectAnswer = 0,
        Explanation = "You add data to a DataTable using the Rows.Add() method."
    },

    // ===== LESSON 3: Designing Report (5 Questions) =====
    new QuizQuestion
    {
        Id = 11,
        Topic = "RdlcReports",
        Question = "What file extension is used for an RDLC report?",
        Options = new List<string> {
            ".rdlc",
            ".rdl",
            ".rpt",
            ".report"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC report files use the .rdlc file extension."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "RdlcReports",
        Question = "What control is used to display tabular data in a report?",
        Options = new List<string> {
            "Label",
            "TextBox",
            "Table",
            "List"
        },
        CorrectAnswer = 2,
        Explanation = "The Table control is used to display tabular data in an RDLC report."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "RdlcReports",
        Question = "How do you reference a field from your dataset in the report?",
        Options = new List<string> {
            "=Fields!FieldName.Value",
            "=Data!FieldName.Value",
            "=FieldName.Value",
            "=Values.FieldName"
        },
        CorrectAnswer = 0,
        Explanation = "You reference a field using the syntax =Fields!FieldName.Value."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "RdlcReports",
        Question = "Where do you find the Report Data panel in Visual Studio?",
        Options = new List<string> {
            "View → Report Data",
            "Tools → Report Data",
            "Project → Report Data",
            "Debug → Report Data"
        },
        CorrectAnswer = 0,
        Explanation = "The Report Data panel is found under View → Report Data in Visual Studio."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "RdlcReports",
        Question = "How do you format a price as currency in an RDLC report?",
        Options = new List<string> {
            "=Format(Fields!Price.Value, 'C')",
            "=Fields!Price.Value.ToString('C')",
            "=Currency(Fields!Price.Value)",
            "=FormatCurrency(Fields!Price.Value)"
        },
        CorrectAnswer = 0,
        Explanation = "You format a price as currency using =Format(Fields!Price.Value, 'C')."
    },

    // ===== LESSON 4: Binding Report to Form (5 Questions) =====
    new QuizQuestion
    {
        Id = 16,
        Topic = "RdlcReports",
        Question = "What control is used to display RDLC reports in Windows Forms?",
        Options = new List<string> {
            "ReportViewer",
            "DataGridView",
            "ListView",
            "GridView"
        },
        CorrectAnswer = 0,
        Explanation = "The ReportViewer control is used to display RDLC reports in Windows Forms."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "RdlcReports",
        Question = "What NuGet package do you need for the ReportViewer control?",
        Options = new List<string> {
            "Microsoft.ReportingServices.ReportViewerControl.WinForms",
            "Microsoft.ReportViewer",
            "ReportViewer.WinForms",
            "Microsoft.Reporting.WinForms"
        },
        CorrectAnswer = 0,
        Explanation = "You need the Microsoft.ReportingServices.ReportViewerControl.WinForms NuGet package."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "RdlcReports",
        Question = "What is the processing mode for RDLC reports?",
        Options = new List<string> {
            "ProcessingMode.Local",
            "ProcessingMode.Server",
            "ProcessingMode.Client",
            "ProcessingMode.Online"
        },
        CorrectAnswer = 0,
        Explanation = "RDLC reports use ProcessingMode.Local because they are processed on the client-side."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "RdlcReports",
        Question = "How do you load an RDLC report in code?",
        Options = new List<string> {
            "reportViewer.LocalReport.ReportPath = 'Report.rdlc'",
            "reportViewer.ReportPath = 'Report.rdlc'",
            "reportViewer.LoadReport('Report.rdlc')",
            "reportViewer.OpenReport('Report.rdlc')"
        },
        CorrectAnswer = 0,
        Explanation = "You load an RDLC report using reportViewer.LocalReport.ReportPath = 'Report.rdlc'."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "RdlcReports",
        Question = "What method refreshes the report display?",
        Options = new List<string> {
            "reportViewer.RefreshReport()",
            "reportViewer.Refresh()",
            "reportViewer.Update()",
            "reportViewer.Reload()"
        },
        CorrectAnswer = 0,
        Explanation = "The RefreshReport() method refreshes the report display."
    },

    // ===== LESSON 5: Full Report Project with SQL (5 Questions) =====
    new QuizQuestion
    {
        Id = 21,
        Topic = "RdlcReports",
        Question = "What is a foreign key used for in a database?",
        Options = new List<string> {
            "To link one table to another",
            "To create a primary key",
            "To create a new table",
            "To delete data"
        },
        CorrectAnswer = 0,
        Explanation = "A foreign key is used to link one table to another, creating a relationship between them."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "RdlcReports",
        Question = "What command creates a new table in SQL Server?",
        Options = new List<string> {
            "CREATE TABLE",
            "NEW TABLE",
            "INSERT TABLE",
            "ADD TABLE"
        },
        CorrectAnswer = 0,
        Explanation = "The CREATE TABLE command is used to create a new table in SQL Server."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "RdlcReports",
        Question = "What is the purpose of IDENTITY in SQL Server?",
        Options = new List<string> {
            "To automatically generate unique numbers",
            "To create a new table",
            "To delete data",
            "To add a foreign key"
        },
        CorrectAnswer = 0,
        Explanation = "IDENTITY is used to automatically generate unique numbers for a column, like an ID."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "RdlcReports",
        Question = "How do you export a report to PDF?",
        Options = new List<string> {
            "Using LocalReport.Render('PDF')",
            "Using reportViewer.ExportPDF()",
            "Using File.Save()",
            "Using PrintToPDF()"
        },
        CorrectAnswer = 0,
        Explanation = "You export to PDF using LocalReport.Render('PDF') which returns a byte array."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "RdlcReports",
        Question = "What is the benefit of using a service class for reports?",
        Options = new List<string> {
            "It keeps your code organized and reusable",
            "It makes the code run faster",
            "It uses less memory",
            "It automatically creates reports"
        },
        CorrectAnswer = 0,
        Explanation = "A service class keeps your report-related code organized and reusable across your application."
    }
};



        // ================================================================
        // RAZOR PAGES - LESSON 1: MVC vs Razor Pages
        // ================================================================
        _quizzes["RazorPages_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson1",
        Question = "What does MVC stand for?",
        Options = new List<string> {
            "Model-View-Controller",
            "Model-View-Component",
            "Module-View-Controller",
            "Model-Variable-Controller"
        },
        CorrectAnswer = 0,
        Explanation = "MVC stands for Model-View-Controller, a design pattern for building web applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson1",
        Question = "What is the main difference between MVC and Razor Pages?",
        Options = new List<string> {
            "Razor Pages is page-focused, MVC is controller-focused",
            "MVC is page-focused, Razor Pages is controller-focused",
            "They are exactly the same",
            "MVC uses C#, Razor Pages uses JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "Razor Pages is page-focused where each page has its own model, while MVC is controller-focused with separate controllers."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson1",
        Question = "When should you use Razor Pages over MVC?",
        Options = new List<string> {
            "For complex applications with large teams",
            "For page-focused applications and smaller projects",
            "For building REST APIs",
            "For all types of applications"
        },
        CorrectAnswer = 1,
        Explanation = "Razor Pages is ideal for page-focused applications, simpler projects, and learning ASP.NET Core."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson1",
        Question = "What are the three components of the MVC pattern?",
        Options = new List<string> {
            "Model, View, Controller",
            "Model, View, Component",
            "Module, View, Controller",
            "Model, Variable, Controller"
        },
        CorrectAnswer = 0,
        Explanation = "The three components of MVC are Model (data), View (UI), and Controller (request handling)."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson1",
        Question = "Which approach is typically simpler for beginners?",
        Options = new List<string> {
            "MVC",
            "Razor Pages",
            "Both are equally complex",
            "Neither is suitable for beginners"
        },
        CorrectAnswer = 1,
        Explanation = "Razor Pages is simpler for beginners because each page has its own model and view in one logical unit."
    }
};

        // ================================================================
        // RAZOR PAGES - LESSON 2: PageModel and Routing
        // ================================================================
        _quizzes["RazorPages_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson2",
        Question = "What is the PageModel in Razor Pages?",
        Options = new List<string> {
            "The HTML template",
            "The code-behind file for a Razor Page",
            "The database model",
            "The CSS stylesheet"
        },
        CorrectAnswer = 1,
        Explanation = "The PageModel is the code-behind file that contains the logic for a Razor Page."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson2",
        Question = "How do you define a custom route in Razor Pages?",
        Options = new List<string> {
            "Using the @page directive with a route template",
            "Using the [Route] attribute on the PageModel",
            "Using the MapRoute method",
            "Using the route.config file"
        },
        CorrectAnswer = 0,
        Explanation = "The @page directive with a route template defines custom routes, e.g., @page \"{id:int}\"."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson2",
        Question = "What is the default routing convention in Razor Pages?",
        Options = new List<string> {
            "/Pages/PageName",
            "/PageName",
            "The folder structure determines the URL path",
            "Custom routes must always be defined"
        },
        CorrectAnswer = 2,
        Explanation = "In Razor Pages, the folder structure determines the URL path by default."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson2",
        Question = "Which route constraint ensures a parameter is a valid integer?",
        Options = new List<string> {
            "{id:int}",
            "{id:integer}",
            "{id:num}",
            "{id:number}"
        },
        CorrectAnswer = 0,
        Explanation = "The {id:int} route constraint ensures the parameter is a valid integer."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson2",
        Question = "How do you access a route parameter in the PageModel?",
        Options = new List<string> {
            "As a property decorated with [BindProperty]",
            "As a parameter in the OnGet method",
            "Using the Request object",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Route parameters can be accessed as properties with [BindProperty], as method parameters, or via the Request object."
    }
};

        // ================================================================
        // RAZOR PAGES - LESSON 3: Tag Helpers
        // ================================================================
        _quizzes["RazorPages_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson3",
        Question = "What are Tag Helpers in ASP.NET Core?",
        Options = new List<string> {
            "Server-side components that participate in HTML rendering",
            "Client-side JavaScript libraries",
            "CSS frameworks",
            "Database helpers"
        },
        CorrectAnswer = 0,
        Explanation = "Tag Helpers are server-side components that participate in HTML rendering, providing a more HTML-friendly way to generate dynamic content."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson3",
        Question = "Which Tag Helper creates a link to another page?",
        Options = new List<string> {
            "Anchor Tag Helper (asp-page)",
            "Link Tag Helper",
            "Route Tag Helper",
            "Navigation Tag Helper"
        },
        CorrectAnswer = 0,
        Explanation = "The Anchor Tag Helper with asp-page attribute creates a link to another Razor Page."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson3",
        Question = "What does the asp-for Tag Helper do?",
        Options = new List<string> {
            "Generates HTML based on the model property",
            "Creates a link to a page",
            "Validates form input",
            "Styles HTML elements"
        },
        CorrectAnswer = 0,
        Explanation = "The asp-for Tag Helper generates HTML for a model property, including appropriate input types and value binding."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson3",
        Question = "What is the purpose of the asp-validation-summary Tag Helper?",
        Options = new List<string> {
            "Displays a summary of validation errors",
            "Validates a single field",
            "Styles the form",
            "Creates a validation list"
        },
        CorrectAnswer = 0,
        Explanation = "The asp-validation-summary Tag Helper displays a summary of all validation errors in the model."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson3",
        Question = "Can you create custom Tag Helpers in ASP.NET Core?",
        Options = new List<string> {
            "No, only built-in Tag Helpers are available",
            "Yes, by inheriting from TagHelper class",
            "Only in MVC applications",
            "Only for form validation"
        },
        CorrectAnswer = 1,
        Explanation = "You can create custom Tag Helpers by inheriting from the TagHelper class and overriding the Process method."
    }
};

        // ================================================================
        // RAZOR PAGES - LESSON 4: Forms and Model Binding
        // ================================================================
        _quizzes["RazorPages_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson4",
        Question = "What is model binding in ASP.NET Core?",
        Options = new List<string> {
            "Automatically mapping HTTP request data to C# objects",
            "Creating database models",
            "Styling HTML elements",
            "Validating user input"
        },
        CorrectAnswer = 0,
        Explanation = "Model binding automatically maps HTTP request data (form, query string, route data) to C# objects."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson4",
        Question = "Which attribute is used to bind a property to form data?",
        Options = new List<string> {
            "[BindProperty]",
            "[FormData]",
            "[RequestData]",
            "[MapProperty]"
        },
        CorrectAnswer = 0,
        Explanation = "The [BindProperty] attribute is used to bind a property to form data in a PageModel."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson4",
        Question = "What is the Post-Redirect-Get (PRG) pattern?",
        Options = new List<string> {
            "Redirecting to another page after a POST to prevent duplicate submissions",
            "Getting data before posting",
            "Posting data to multiple pages",
            "Redirecting all POST requests"
        },
        CorrectAnswer = 0,
        Explanation = "The Post-Redirect-Get pattern redirects to another page after a POST to prevent duplicate form submissions."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson4",
        Question = "How do you handle form submission in Razor Pages?",
        Options = new List<string> {
            "Using OnPost method in the PageModel",
            "Using OnSubmit method",
            "Using HandlePost method",
            "Using FormHandler attribute"
        },
        CorrectAnswer = 0,
        Explanation = "Form submission is handled by the OnPost method in the PageModel."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson4",
        Question = "What is the purpose of the [BindProperty] attribute?",
        Options = new List<string> {
            "To bind model properties to request data",
            "To create database tables",
            "To style HTML elements",
            "To validate input"
        },
        CorrectAnswer = 0,
        Explanation = "[BindProperty] tells ASP.NET Core to bind the property to request data from forms, query strings, or route data."
    }
};

        // ================================================================
        // RAZOR PAGES - LESSON 5: Validation & Data Annotations
        // ================================================================
        _quizzes["RazorPages_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson5",
        Question = "What are Data Annotations in ASP.NET Core?",
        Options = new List<string> {
            "Attributes used for validation and metadata",
            "CSS classes for styling",
            "JavaScript functions",
            "Database migrations"
        },
        CorrectAnswer = 0,
        Explanation = "Data Annotations are attributes used for validation rules and metadata on model properties."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson5",
        Question = "Which attribute marks a property as required?",
        Options = new List<string> {
            "[Required]",
            "[Mandatory]",
            "[NotNull]",
            "[Must]"
        },
        CorrectAnswer = 0,
        Explanation = "The [Required] attribute marks a property as required for validation."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson5",
        Question = "How do you specify a custom error message for validation?",
        Options = new List<string> {
            "Using the ErrorMessage property of the validation attribute",
            "Using a separate error file",
            "Using the ModelState",
            "Using ViewData"
        },
        CorrectAnswer = 0,
        Explanation = "Validation attributes have an ErrorMessage property for custom error messages."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson5",
        Question = "What does ModelState.IsValid check?",
        Options = new List<string> {
            "Whether the model passes all validation rules",
            "Whether the model is null",
            "Whether the database is valid",
            "Whether the view is valid"
        },
        CorrectAnswer = 0,
        Explanation = "ModelState.IsValid checks if the model passes all validation rules defined by Data Annotations."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson5",
        Question = "Can you create custom validation attributes?",
        Options = new List<string> {
            "No, only built-in attributes are allowed",
            "Yes, by inheriting from ValidationAttribute",
            "Only for specific data types",
            "Only in MVC applications"
        },
        CorrectAnswer = 1,
        Explanation = "You can create custom validation attributes by inheriting from ValidationAttribute and overriding the IsValid method."
    }
};


        // ================================================================
        // RAZOR PAGES - LESSON 6: Partials and Layouts
        // ================================================================
        _quizzes["RazorPages_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson6",
        Question = "What is a Layout in Razor Pages?",
        Options = new List<string> {
            "A template that provides a consistent structure across pages",
            "A database schema",
            "A CSS file",
            "A JavaScript file"
        },
        CorrectAnswer = 0,
        Explanation = "A Layout is a template that provides a consistent structure (header, footer, navigation) across pages."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson6",
        Question = "What is the purpose of @RenderBody() in a Layout?",
        Options = new List<string> {
            "Renders the content of the current page",
            "Renders the header",
            "Renders the footer",
            "Renders the navigation"
        },
        CorrectAnswer = 0,
        Explanation = "@RenderBody() renders the content of the current page inside the Layout."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson6",
        Question = "How do you specify which Layout a page should use?",
        Options = new List<string> {
            "Using the Layout property in the page",
            "Using the _ViewStart.cshtml file",
            "Using the [Layout] attribute",
            "Both A and B"
        },
        CorrectAnswer = 3,
        Explanation = "A page can specify its Layout using the Layout property or via the _ViewStart.cshtml file."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson6",
        Question = "What is a Partial View in Razor Pages?",
        Options = new List<string> {
            "A reusable UI component",
            "A complete page",
            "A database view",
            "A CSS class"
        },
        CorrectAnswer = 0,
        Explanation = "A Partial View is a reusable UI component that can be included in multiple pages."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson6",
        Question = "How do you include a Partial View in a Razor Page?",
        Options = new List<string> {
            "Using @await Html.PartialAsync()",
            "Using @await Html.RenderPartialAsync()",
            "Using the <partial> Tag Helper",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Partials can be included using PartialAsync, RenderPartialAsync, or the <partial> Tag Helper."
    }
};

        // ================================================================
        // RAZOR PAGES - LESSON 7: Dependency Injection
        // ================================================================
        _quizzes["RazorPages_Lesson7"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson7",
        Question = "What is Dependency Injection (DI)?",
        Options = new List<string> {
            "A pattern where objects receive dependencies from an external source",
            "A pattern where objects create their own dependencies",
            "A database pattern",
            "A UI pattern"
        },
        CorrectAnswer = 0,
        Explanation = "Dependency Injection is a pattern where objects receive their dependencies from an external source rather than creating them internally."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson7",
        Question = "Which service lifetime creates a new instance every time it's requested?",
        Options = new List<string> {
            "Singleton",
            "Scoped",
            "Transient",
            "PerRequest"
        },
        CorrectAnswer = 2,
        Explanation = "Transient creates a new instance every time the service is requested."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson7",
        Question = "Which service lifetime creates one instance per HTTP request?",
        Options = new List<string> {
            "Singleton",
            "Scoped",
            "Transient",
            "PerRequest"
        },
        CorrectAnswer = 1,
        Explanation = "Scoped creates one instance per HTTP request/scope."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson7",
        Question = "Which service lifetime creates one instance for the entire application lifetime?",
        Options = new List<string> {
            "Singleton",
            "Scoped",
            "Transient",
            "PerRequest"
        },
        CorrectAnswer = 0,
        Explanation = "Singleton creates one instance for the entire application lifetime."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson7",
        Question = "How do you register a service in ASP.NET Core?",
        Options = new List<string> {
            "Using builder.Services in Program.cs",
            "Using the [Inject] attribute",
            "Using the Startup.cs file",
            "Using the appsettings.json file"
        },
        CorrectAnswer = 0,
        Explanation = "Services are registered using builder.Services in Program.cs with methods like AddScoped, AddTransient, or AddSingleton."
    }
};

        // ================================================================
        // RAZOR PAGES - LESSON 8: Full CRUD Project
        // ================================================================
        _quizzes["RazorPages_Lesson8"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages_Lesson8",
        Question = "What does CRUD stand for?",
        Options = new List<string> {
            "Create, Read, Update, Delete",
            "Create, Review, Update, Delete",
            "Code, Run, Update, Deploy",
            "Create, Read, Update, Display"
        },
        CorrectAnswer = 0,
        Explanation = "CRUD stands for Create, Read, Update, Delete - the four basic operations for persistent storage."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages_Lesson8",
        Question = "Which method is used to add a new entity to the database in EF Core?",
        Options = new List<string> {
            "Add()",
            "Insert()",
            "Create()",
            "Save()"
        },
        CorrectAnswer = 0,
        Explanation = "The Add() method is used to add a new entity to the DbContext before calling SaveChangesAsync."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages_Lesson8",
        Question = "What is the purpose of EntityState.Modified?",
        Options = new List<string> {
            "To mark an entity as modified for updating",
            "To mark an entity as new",
            "To delete an entity",
            "To detach an entity"
        },
        CorrectAnswer = 0,
        Explanation = "EntityState.Modified marks an entity as modified so EF Core knows to update it when SaveChanges is called."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages_Lesson8",
        Question = "How do you delete an entity in EF Core?",
        Options = new List<string> {
            "Remove()",
            "Delete()",
            "Erase()",
            "Drop()"
        },
        CorrectAnswer = 0,
        Explanation = "The Remove() method is used to mark an entity for deletion before calling SaveChangesAsync."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages_Lesson8",
        Question = "What is the purpose of Include() in EF Core?",
        Options = new List<string> {
            "To load related data (eager loading)",
            "To add a new entity",
            "To delete an entity",
            "To update an entity"
        },
        CorrectAnswer = 0,
        Explanation = "Include() is used for eager loading, to load related data from other tables in a single query."
    }
};

        // ================================================================
        // RAZOR PAGES - FULL SECTION (All 40 Questions)
        // ================================================================
        _quizzes["RazorPages"] = new List<QuizQuestion>
{
    // ===== LESSON 1: MVC vs Razor Pages (5 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "RazorPages",
        Question = "What does MVC stand for?",
        Options = new List<string> {
            "Model-View-Controller",
            "Model-View-Component",
            "Module-View-Controller",
            "Model-Variable-Controller"
        },
        CorrectAnswer = 0,
        Explanation = "MVC stands for Model-View-Controller, a design pattern for building web applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "RazorPages",
        Question = "What is the main difference between MVC and Razor Pages?",
        Options = new List<string> {
            "Razor Pages is page-focused, MVC is controller-focused",
            "MVC is page-focused, Razor Pages is controller-focused",
            "They are exactly the same",
            "MVC uses C#, Razor Pages uses JavaScript"
        },
        CorrectAnswer = 0,
        Explanation = "Razor Pages is page-focused where each page has its own model, while MVC is controller-focused with separate controllers."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "RazorPages",
        Question = "When should you use Razor Pages over MVC?",
        Options = new List<string> {
            "For complex applications with large teams",
            "For page-focused applications and smaller projects",
            "For building REST APIs",
            "For all types of applications"
        },
        CorrectAnswer = 1,
        Explanation = "Razor Pages is ideal for page-focused applications, simpler projects, and learning ASP.NET Core."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "RazorPages",
        Question = "What are the three components of the MVC pattern?",
        Options = new List<string> {
            "Model, View, Controller",
            "Model, View, Component",
            "Module, View, Controller",
            "Model, Variable, Controller"
        },
        CorrectAnswer = 0,
        Explanation = "The three components of MVC are Model (data), View (UI), and Controller (request handling)."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "RazorPages",
        Question = "Which approach is typically simpler for beginners?",
        Options = new List<string> {
            "MVC",
            "Razor Pages",
            "Both are equally complex",
            "Neither is suitable for beginners"
        },
        CorrectAnswer = 1,
        Explanation = "Razor Pages is simpler for beginners because each page has its own model and view in one logical unit."
    },

    // ===== LESSON 2: PageModel and Routing (5 Questions) =====
    new QuizQuestion
    {
        Id = 6,
        Topic = "RazorPages",
        Question = "What is the PageModel in Razor Pages?",
        Options = new List<string> {
            "The HTML template",
            "The code-behind file for a Razor Page",
            "The database model",
            "The CSS stylesheet"
        },
        CorrectAnswer = 1,
        Explanation = "The PageModel is the code-behind file that contains the logic for a Razor Page."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "RazorPages",
        Question = "How do you define a custom route in Razor Pages?",
        Options = new List<string> {
            "Using the @page directive with a route template",
            "Using the [Route] attribute on the PageModel",
            "Using the MapRoute method",
            "Using the route.config file"
        },
        CorrectAnswer = 0,
        Explanation = "The @page directive with a route template defines custom routes, e.g., @page \"{id:int}\"."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "RazorPages",
        Question = "What is the default routing convention in Razor Pages?",
        Options = new List<string> {
            "/Pages/PageName",
            "/PageName",
            "The folder structure determines the URL path",
            "Custom routes must always be defined"
        },
        CorrectAnswer = 2,
        Explanation = "In Razor Pages, the folder structure determines the URL path by default."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "RazorPages",
        Question = "Which route constraint ensures a parameter is a valid integer?",
        Options = new List<string> {
            "{id:int}",
            "{id:integer}",
            "{id:num}",
            "{id:number}"
        },
        CorrectAnswer = 0,
        Explanation = "The {id:int} route constraint ensures the parameter is a valid integer."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "RazorPages",
        Question = "How do you access a route parameter in the PageModel?",
        Options = new List<string> {
            "As a property decorated with [BindProperty]",
            "As a parameter in the OnGet method",
            "Using the Request object",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Route parameters can be accessed as properties with [BindProperty], as method parameters, or via the Request object."
    },

    // ===== LESSON 3: Tag Helpers (5 Questions) =====
    new QuizQuestion
    {
        Id = 11,
        Topic = "RazorPages",
        Question = "What are Tag Helpers in ASP.NET Core?",
        Options = new List<string> {
            "Server-side components that participate in HTML rendering",
            "Client-side JavaScript libraries",
            "CSS frameworks",
            "Database helpers"
        },
        CorrectAnswer = 0,
        Explanation = "Tag Helpers are server-side components that participate in HTML rendering, providing a more HTML-friendly way to generate dynamic content."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "RazorPages",
        Question = "Which Tag Helper creates a link to another page?",
        Options = new List<string> {
            "Anchor Tag Helper (asp-page)",
            "Link Tag Helper",
            "Route Tag Helper",
            "Navigation Tag Helper"
        },
        CorrectAnswer = 0,
        Explanation = "The Anchor Tag Helper with asp-page attribute creates a link to another Razor Page."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "RazorPages",
        Question = "What does the asp-for Tag Helper do?",
        Options = new List<string> {
            "Generates HTML based on the model property",
            "Creates a link to a page",
            "Validates form input",
            "Styles HTML elements"
        },
        CorrectAnswer = 0,
        Explanation = "The asp-for Tag Helper generates HTML for a model property, including appropriate input types and value binding."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "RazorPages",
        Question = "What is the purpose of the asp-validation-summary Tag Helper?",
        Options = new List<string> {
            "Displays a summary of validation errors",
            "Validates a single field",
            "Styles the form",
            "Creates a validation list"
        },
        CorrectAnswer = 0,
        Explanation = "The asp-validation-summary Tag Helper displays a summary of all validation errors in the model."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "RazorPages",
        Question = "Can you create custom Tag Helpers in ASP.NET Core?",
        Options = new List<string> {
            "No, only built-in Tag Helpers are available",
            "Yes, by inheriting from TagHelper class",
            "Only in MVC applications",
            "Only for form validation"
        },
        CorrectAnswer = 1,
        Explanation = "You can create custom Tag Helpers by inheriting from the TagHelper class and overriding the Process method."
    },

    // ===== LESSON 4: Forms and Model Binding (5 Questions) =====
    new QuizQuestion
    {
        Id = 16,
        Topic = "RazorPages",
        Question = "What is model binding in ASP.NET Core?",
        Options = new List<string> {
            "Automatically mapping HTTP request data to C# objects",
            "Creating database models",
            "Styling HTML elements",
            "Validating user input"
        },
        CorrectAnswer = 0,
        Explanation = "Model binding automatically maps HTTP request data (form, query string, route data) to C# objects."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "RazorPages",
        Question = "Which attribute is used to bind a property to form data?",
        Options = new List<string> {
            "[BindProperty]",
            "[FormData]",
            "[RequestData]",
            "[MapProperty]"
        },
        CorrectAnswer = 0,
        Explanation = "The [BindProperty] attribute is used to bind a property to form data in a PageModel."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "RazorPages",
        Question = "What is the Post-Redirect-Get (PRG) pattern?",
        Options = new List<string> {
            "Redirecting to another page after a POST to prevent duplicate submissions",
            "Getting data before posting",
            "Posting data to multiple pages",
            "Redirecting all POST requests"
        },
        CorrectAnswer = 0,
        Explanation = "The Post-Redirect-Get pattern redirects to another page after a POST to prevent duplicate form submissions."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "RazorPages",
        Question = "How do you handle form submission in Razor Pages?",
        Options = new List<string> {
            "Using OnPost method in the PageModel",
            "Using OnSubmit method",
            "Using HandlePost method",
            "Using FormHandler attribute"
        },
        CorrectAnswer = 0,
        Explanation = "Form submission is handled by the OnPost method in the PageModel."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "RazorPages",
        Question = "What is the purpose of the [BindProperty] attribute?",
        Options = new List<string> {
            "To bind model properties to request data",
            "To create database tables",
            "To style HTML elements",
            "To validate input"
        },
        CorrectAnswer = 0,
        Explanation = "[BindProperty] tells ASP.NET Core to bind the property to request data from forms, query strings, or route data."
    },

    // ===== LESSON 5: Validation & Data Annotations (5 Questions) =====
    new QuizQuestion
    {
        Id = 21,
        Topic = "RazorPages",
        Question = "What are Data Annotations in ASP.NET Core?",
        Options = new List<string> {
            "Attributes used for validation and metadata",
            "CSS classes for styling",
            "JavaScript functions",
            "Database migrations"
        },
        CorrectAnswer = 0,
        Explanation = "Data Annotations are attributes used for validation rules and metadata on model properties."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "RazorPages",
        Question = "Which attribute marks a property as required?",
        Options = new List<string> {
            "[Required]",
            "[Mandatory]",
            "[NotNull]",
            "[Must]"
        },
        CorrectAnswer = 0,
        Explanation = "The [Required] attribute marks a property as required for validation."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "RazorPages",
        Question = "How do you specify a custom error message for validation?",
        Options = new List<string> {
            "Using the ErrorMessage property of the validation attribute",
            "Using a separate error file",
            "Using the ModelState",
            "Using ViewData"
        },
        CorrectAnswer = 0,
        Explanation = "Validation attributes have an ErrorMessage property for custom error messages."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "RazorPages",
        Question = "What does ModelState.IsValid check?",
        Options = new List<string> {
            "Whether the model passes all validation rules",
            "Whether the model is null",
            "Whether the database is valid",
            "Whether the view is valid"
        },
        CorrectAnswer = 0,
        Explanation = "ModelState.IsValid checks if the model passes all validation rules defined by Data Annotations."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "RazorPages",
        Question = "Can you create custom validation attributes?",
        Options = new List<string> {
            "No, only built-in attributes are allowed",
            "Yes, by inheriting from ValidationAttribute",
            "Only for specific data types",
            "Only in MVC applications"
        },
        CorrectAnswer = 1,
        Explanation = "You can create custom validation attributes by inheriting from ValidationAttribute and overriding the IsValid method."
    },

    // ===== LESSON 6: Partials and Layouts (5 Questions) =====
    new QuizQuestion
    {
        Id = 26,
        Topic = "RazorPages",
        Question = "What is a Layout in Razor Pages?",
        Options = new List<string> {
            "A template that provides a consistent structure across pages",
            "A database schema",
            "A CSS file",
            "A JavaScript file"
        },
        CorrectAnswer = 0,
        Explanation = "A Layout is a template that provides a consistent structure (header, footer, navigation) across pages."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "RazorPages",
        Question = "What is the purpose of @RenderBody() in a Layout?",
        Options = new List<string> {
            "Renders the content of the current page",
            "Renders the header",
            "Renders the footer",
            "Renders the navigation"
        },
        CorrectAnswer = 0,
        Explanation = "@RenderBody() renders the content of the current page inside the Layout."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "RazorPages",
        Question = "How do you specify which Layout a page should use?",
        Options = new List<string> {
            "Using the Layout property in the page",
            "Using the _ViewStart.cshtml file",
            "Using the [Layout] attribute",
            "Both A and B"
        },
        CorrectAnswer = 3,
        Explanation = "A page can specify its Layout using the Layout property or via the _ViewStart.cshtml file."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "RazorPages",
        Question = "What is a Partial View in Razor Pages?",
        Options = new List<string> {
            "A reusable UI component",
            "A complete page",
            "A database view",
            "A CSS class"
        },
        CorrectAnswer = 0,
        Explanation = "A Partial View is a reusable UI component that can be included in multiple pages."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "RazorPages",
        Question = "How do you include a Partial View in a Razor Page?",
        Options = new List<string> {
            "Using @await Html.PartialAsync()",
            "Using @await Html.RenderPartialAsync()",
            "Using the <partial> Tag Helper",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Partials can be included using PartialAsync, RenderPartialAsync, or the <partial> Tag Helper."
    },

    // ===== LESSON 7: Dependency Injection (5 Questions) =====
    new QuizQuestion
    {
        Id = 31,
        Topic = "RazorPages",
        Question = "What is Dependency Injection (DI)?",
        Options = new List<string> {
            "A pattern where objects receive dependencies from an external source",
            "A pattern where objects create their own dependencies",
            "A database pattern",
            "A UI pattern"
        },
        CorrectAnswer = 0,
        Explanation = "Dependency Injection is a pattern where objects receive their dependencies from an external source rather than creating them internally."
    },
    new QuizQuestion
    {
        Id = 32,
        Topic = "RazorPages",
        Question = "Which service lifetime creates a new instance every time it's requested?",
        Options = new List<string> {
            "Singleton",
            "Scoped",
            "Transient",
            "PerRequest"
        },
        CorrectAnswer = 2,
        Explanation = "Transient creates a new instance every time the service is requested."
    },
    new QuizQuestion
    {
        Id = 33,
        Topic = "RazorPages",
        Question = "Which service lifetime creates one instance per HTTP request?",
        Options = new List<string> {
            "Singleton",
            "Scoped",
            "Transient",
            "PerRequest"
        },
        CorrectAnswer = 1,
        Explanation = "Scoped creates one instance per HTTP request/scope."
    },
    new QuizQuestion
    {
        Id = 34,
        Topic = "RazorPages",
        Question = "Which service lifetime creates one instance for the entire application lifetime?",
        Options = new List<string> {
            "Singleton",
            "Scoped",
            "Transient",
            "PerRequest"
        },
        CorrectAnswer = 0,
        Explanation = "Singleton creates one instance for the entire application lifetime."
    },
    new QuizQuestion
    {
        Id = 35,
        Topic = "RazorPages",
        Question = "How do you register a service in ASP.NET Core?",
        Options = new List<string> {
            "Using builder.Services in Program.cs",
            "Using the [Inject] attribute",
            "Using the Startup.cs file",
            "Using the appsettings.json file"
        },
        CorrectAnswer = 0,
        Explanation = "Services are registered using builder.Services in Program.cs with methods like AddScoped, AddTransient, or AddSingleton."
    },

    // ===== LESSON 8: Full CRUD Project (5 Questions) =====
    new QuizQuestion
    {
        Id = 36,
        Topic = "RazorPages",
        Question = "What does CRUD stand for?",
        Options = new List<string> {
            "Create, Read, Update, Delete",
            "Create, Review, Update, Delete",
            "Code, Run, Update, Deploy",
            "Create, Read, Update, Display"
        },
        CorrectAnswer = 0,
        Explanation = "CRUD stands for Create, Read, Update, Delete - the four basic operations for persistent storage."
    },
    new QuizQuestion
    {
        Id = 37,
        Topic = "RazorPages",
        Question = "Which method is used to add a new entity to the database in EF Core?",
        Options = new List<string> {
            "Add()",
            "Insert()",
            "Create()",
            "Save()"
        },
        CorrectAnswer = 0,
        Explanation = "The Add() method is used to add a new entity to the DbContext before calling SaveChangesAsync."
    },
    new QuizQuestion
    {
        Id = 38,
        Topic = "RazorPages",
        Question = "What is the purpose of EntityState.Modified?",
        Options = new List<string> {
            "To mark an entity as modified for updating",
            "To mark an entity as new",
            "To delete an entity",
            "To detach an entity"
        },
        CorrectAnswer = 0,
        Explanation = "EntityState.Modified marks an entity as modified so EF Core knows to update it when SaveChanges is called."
    },
    new QuizQuestion
    {
        Id = 39,
        Topic = "RazorPages",
        Question = "How do you delete an entity in EF Core?",
        Options = new List<string> {
            "Remove()",
            "Delete()",
            "Erase()",
            "Drop()"
        },
        CorrectAnswer = 0,
        Explanation = "The Remove() method is used to mark an entity for deletion before calling SaveChangesAsync."
    },
    new QuizQuestion
    {
        Id = 40,
        Topic = "RazorPages",
        Question = "What is the purpose of Include() in EF Core?",
        Options = new List<string> {
            "To load related data (eager loading)",
            "To add a new entity",
            "To delete an entity",
            "To update an entity"
        },
        CorrectAnswer = 0,
        Explanation = "Include() is used for eager loading, to load related data from other tables in a single query."
    }
};

        // ================================================================
        // PROJECT WORKFLOW - LESSON 1: Understanding Requirements
        // ================================================================
        _quizzes["ProjectWorkflow_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ProjectWorkflow_Lesson1",
        Question = "What are functional requirements?",
        Options = new List<string> {
            "How the system should perform",
            "What the system should do",
            "System security requirements",
            "System scalability requirements"
        },
        CorrectAnswer = 1,
        Explanation = "Functional requirements define what the system should do, including user authentication, data input, business logic, and reporting."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ProjectWorkflow_Lesson1",
        Question = "What are non-functional requirements?",
        Options = new List<string> {
            "What the system should do",
            "How the system should perform",
            "User interface requirements",
            "Database requirements"
        },
        CorrectAnswer = 1,
        Explanation = "Non-functional requirements define how the system should perform, including performance, security, scalability, and availability."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ProjectWorkflow_Lesson1",
        Question = "What does MoSCoW stand for in requirement prioritization?",
        Options = new List<string> {
            "Must have, Should have, Could have, Won't have",
            "Major, Minor, Critical, Optional",
            "Mandatory, Standard, Conditional, Optional",
            "Most, Some, Can, Won't"
        },
        CorrectAnswer = 0,
        Explanation = "MoSCoW stands for Must have, Should have, Could have, and Won't have - used to prioritize requirements."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ProjectWorkflow_Lesson1",
        Question = "What is scope creep in project management?",
        Options = new List<string> {
            "Adding features without proper evaluation",
            "Reducing project scope",
            "Following project scope",
            "Removing unnecessary features"
        },
        CorrectAnswer = 0,
        Explanation = "Scope creep occurs when new features are added to a project without proper evaluation, often causing delays and budget overruns."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ProjectWorkflow_Lesson1",
        Question = "What is a user story?",
        Options = new List<string> {
            "A technical specification",
            "A requirement written from an end-user perspective",
            "A database schema",
            "A code comment"
        },
        CorrectAnswer = 1,
        Explanation = "A user story is a requirement written from an end-user perspective, typically following the format: 'As a [user], I want [feature], so that [benefit].'"
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ProjectWorkflow_Lesson1",
        Question = "What are acceptance criteria in requirements?",
        Options = new List<string> {
            "The definition of done for a user story",
            "The project budget",
            "The project timeline",
            "The team members assigned"
        },
        CorrectAnswer = 0,
        Explanation = "Acceptance criteria define the conditions that must be met for a user story to be considered complete."
    }
};

        // ================================================================
        // PROJECT WORKFLOW - LESSON 2: Planning and Architecture
        // ================================================================
        _quizzes["ProjectWorkflow_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ProjectWorkflow_Lesson2",
        Question = "What is the purpose of project planning?",
        Options = new List<string> {
            "To reduce risks and save time",
            "To make the project more complex",
            "To delay the project",
            "To increase costs"
        },
        CorrectAnswer = 0,
        Explanation = "Project planning reduces risks, saves time, and ensures a successful outcome by defining scope, timeline, and resources."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ProjectWorkflow_Lesson2",
        Question = "What are the typical layers in a layered architecture?",
        Options = new List<string> {
            "UI, Business Logic, Data Access, Database",
            "Frontend, Backend, Database",
            "Client, Server, Database",
            "Presentation, Application, Infrastructure"
        },
        CorrectAnswer = 0,
        Explanation = "A typical layered (N-Tier) architecture includes Presentation Layer (UI), Business Logic Layer, Data Access Layer, and Database Layer."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ProjectWorkflow_Lesson2",
        Question = "What is Clean Architecture?",
        Options = new List<string> {
            "An architecture that separates domain, application, infrastructure, and presentation",
            "An architecture that only uses one layer",
            "An architecture without any layers",
            "An architecture that only focuses on the database"
        },
        CorrectAnswer = 0,
        Explanation = "Clean Architecture organizes code into Domain, Application, Infrastructure, and Presentation layers, with dependencies pointing inward."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ProjectWorkflow_Lesson2",
        Question = "What should you consider when selecting technology for a project?",
        Options = new List<string> {
            "Project requirements, team expertise, scalability, community support, cost",
            "Only the cost",
            "Only the team expertise",
            "Only the project requirements"
        },
        CorrectAnswer = 0,
        Explanation = "Technology selection should consider project requirements, team expertise, scalability needs, community support, and cost."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ProjectWorkflow_Lesson2",
        Question = "What is the purpose of an Entity-Relationship (ER) diagram?",
        Options = new List<string> {
            "To visualize database entities and their relationships",
            "To create user interfaces",
            "To write code",
            "To test applications"
        },
        CorrectAnswer = 0,
        Explanation = "An ER diagram visualizes database entities (tables) and their relationships, helping design the database schema."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ProjectWorkflow_Lesson2",
        Question = "Which HTTP method is used to create a new resource in a REST API?",
        Options = new List<string> {
            "GET",
            "POST",
            "PUT",
            "DELETE"
        },
        CorrectAnswer = 1,
        Explanation = "POST is used to create a new resource in a REST API."
    }
};

        // ================================================================
        // PROJECT WORKFLOW - LESSON 3: Git Branching Strategy
        // ================================================================
        _quizzes["ProjectWorkflow_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ProjectWorkflow_Lesson3",
        Question = "What is the purpose of a Git branching strategy?",
        Options = new List<string> {
            "To complicate the development process",
            "To enable team collaboration and stable releases",
            "To delete branches",
            "To slow down development"
        },
        CorrectAnswer = 1,
        Explanation = "A Git branching strategy enables team collaboration, stable releases, and an efficient development workflow."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ProjectWorkflow_Lesson3",
        Question = "What is Git Flow?",
        Options = new List<string> {
            "A simple branching strategy with only main branch",
            "A branching strategy with main, develop, feature, release, and hotfix branches",
            "A strategy that doesn't use branches",
            "A strategy only for bug fixes"
        },
        CorrectAnswer = 1,
        Explanation = "Git Flow uses main (production), develop (integration), feature/*, release/*, and hotfix/* branches."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ProjectWorkflow_Lesson3",
        Question = "What is GitHub Flow?",
        Options = new List<string> {
            "A complex branching strategy",
            "A simpler branching strategy with only main and feature branches",
            "A strategy that doesn't use pull requests",
            "A strategy only for releases"
        },
        CorrectAnswer = 1,
        Explanation = "GitHub Flow is a simpler strategy using main and feature/* branches with pull requests for code review."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ProjectWorkflow_Lesson3",
        Question = "What is a Pull Request?",
        Options = new List<string> {
            "A request to delete a branch",
            "A request to merge code changes",
            "A request to create a new repository",
            "A request to push changes"
        },
        CorrectAnswer = 1,
        Explanation = "A Pull Request is a request to merge code changes from one branch into another, typically used for code review."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ProjectWorkflow_Lesson3",
        Question = "What is a merge conflict in Git?",
        Options = new List<string> {
            "When Git automatically merges changes",
            "When changes in different branches conflict with each other",
            "When a branch is deleted",
            "When a commit is pushed"
        },
        CorrectAnswer = 1,
        Explanation = "A merge conflict occurs when changes in different branches conflict with each other and need manual resolution."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ProjectWorkflow_Lesson3",
        Question = "Which command creates a new branch and switches to it in Git?",
        Options = new List<string> {
            "git branch new-branch",
            "git checkout -b new-branch",
            "git switch -c new-branch",
            "Both B and C"
        },
        CorrectAnswer = 3,
        Explanation = "Both 'git checkout -b' and 'git switch -c' create a new branch and switch to it."
    }
};

        // ================================================================
        // PROJECT WORKFLOW - LESSON 4: Coding Standards
        // ================================================================
        _quizzes["ProjectWorkflow_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ProjectWorkflow_Lesson4",
        Question = "Why are coding standards important?",
        Options = new List<string> {
            "To make code less readable",
            "To ensure readable, maintainable, and consistent code",
            "To slow down development",
            "To make code reviews harder"
        },
        CorrectAnswer = 1,
        Explanation = "Coding standards ensure readable, maintainable, and consistent code, making it easier to review and onboard new developers."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ProjectWorkflow_Lesson4",
        Question = "What naming convention is used for classes in C#?",
        Options = new List<string> {
            "camelCase",
            "PascalCase",
            "snake_case",
            "UPPER_CASE"
        },
        CorrectAnswer = 1,
        Explanation = "Classes in C# use PascalCase naming convention (e.g., UserService, ProductController)."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ProjectWorkflow_Lesson4",
        Question = "What naming convention is used for private fields in C#?",
        Options = new List<string> {
            "_camelCase",
            "PascalCase",
            "camelCase",
            "UPPER_CASE"
        },
        CorrectAnswer = 0,
        Explanation = "Private fields in C# typically use _camelCase naming convention (e.g., _logger, _userRepository)."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ProjectWorkflow_Lesson4",
        Question = "What does the Single Responsibility Principle state?",
        Options = new List<string> {
            "A class should have multiple responsibilities",
            "A class should have only one reason to change",
            "A class should not have any responsibilities",
            "A class should be responsible for everything"
        },
        CorrectAnswer = 1,
        Explanation = "The Single Responsibility Principle states that a class should have only one reason to change - one responsibility."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ProjectWorkflow_Lesson4",
        Question = "What is a guard clause?",
        Options = new List<string> {
            "A clause that validates inputs at the start of a method",
            "A clause that catches exceptions",
            "A clause that returns early",
            "A clause that logs errors"
        },
        CorrectAnswer = 0,
        Explanation = "A guard clause validates inputs and checks conditions at the start of a method, returning early if conditions aren't met."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ProjectWorkflow_Lesson4",
        Question = "What should you review during a code review?",
        Options = new List<string> {
            "Only the code style",
            "Functionality, standards, security, performance, test coverage, and documentation",
            "Only the functionality",
            "Only the performance"
        },
        CorrectAnswer = 1,
        Explanation = "Code reviews should check functionality, coding standards, security, performance, test coverage, and documentation."
    }
};

        // ================================================================
        // PROJECT WORKFLOW - LESSON 5: Testing and Delivering
        // ================================================================
        _quizzes["ProjectWorkflow_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ProjectWorkflow_Lesson5",
        Question = "What is Unit Testing?",
        Options = new List<string> {
            "Testing the entire application",
            "Testing individual components in isolation",
            "Testing the user interface",
            "Testing the database"
        },
        CorrectAnswer = 1,
        Explanation = "Unit testing verifies that individual components (methods, classes) behave correctly in isolation."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ProjectWorkflow_Lesson5",
        Question = "What is the TDD cycle?",
        Options = new List<string> {
            "Write code, test, deploy",
            "Write a failing test, write code to make it pass, refactor",
            "Design, code, test",
            "Plan, code, test"
        },
        CorrectAnswer = 1,
        Explanation = "TDD follows the Red-Green-Refactor cycle: write a failing test (Red), write code to make it pass (Green), then refactor."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ProjectWorkflow_Lesson5",
        Question = "What is Integration Testing?",
        Options = new List<string> {
            "Testing individual units",
            "Testing how components work together",
            "Testing the user interface",
            "Testing performance"
        },
        CorrectAnswer = 1,
        Explanation = "Integration testing verifies how different components work together correctly."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ProjectWorkflow_Lesson5",
        Question = "What is Continuous Integration (CI)?",
        Options = new List<string> {
            "Manual testing before deployment",
            "Automatically building and testing code on every push",
            "Deploying code to production",
            "Writing code continuously"
        },
        CorrectAnswer = 1,
        Explanation = "CI automatically builds and tests code on every push, catching issues early."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ProjectWorkflow_Lesson5",
        Question = "What is Blue-Green Deployment?",
        Options = new List<string> {
            "Deploying to production directly",
            "Using two identical environments for zero-downtime deployment",
            "Deploying to a single server",
            "Deploying to development only"
        },
        CorrectAnswer = 1,
        Explanation = "Blue-Green Deployment uses two identical environments (Blue and Green) to enable zero-downtime deployments."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ProjectWorkflow_Lesson5",
        Question = "What is Canary Deployment?",
        Options = new List<string> {
            "Deploying all at once",
            "Gradually rolling out a change to a small subset of users first",
            "Deploying only to test environment",
            "Deploying without testing"
        },
        CorrectAnswer = 1,
        Explanation = "Canary Deployment gradually rolls out changes to a small subset of users first, reducing risk."
    }
};


        // ================================================================
        // PROJECT WORKFLOW - FULL SECTION (All 30 Questions)
        // ================================================================
        _quizzes["ProjectWorkflow"] = new List<QuizQuestion>
{
    // ===== LESSON 1: Understanding Requirements (6 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "ProjectWorkflow",
        Question = "What are functional requirements?",
        Options = new List<string> {
            "How the system should perform",
            "What the system should do",
            "System security requirements",
            "System scalability requirements"
        },
        CorrectAnswer = 1,
        Explanation = "Functional requirements define what the system should do, including user authentication, data input, business logic, and reporting."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ProjectWorkflow",
        Question = "What are non-functional requirements?",
        Options = new List<string> {
            "What the system should do",
            "How the system should perform",
            "User interface requirements",
            "Database requirements"
        },
        CorrectAnswer = 1,
        Explanation = "Non-functional requirements define how the system should perform, including performance, security, scalability, and availability."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ProjectWorkflow",
        Question = "What does MoSCoW stand for in requirement prioritization?",
        Options = new List<string> {
            "Must have, Should have, Could have, Won't have",
            "Major, Minor, Critical, Optional",
            "Mandatory, Standard, Conditional, Optional",
            "Most, Some, Can, Won't"
        },
        CorrectAnswer = 0,
        Explanation = "MoSCoW stands for Must have, Should have, Could have, and Won't have - used to prioritize requirements."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ProjectWorkflow",
        Question = "What is scope creep in project management?",
        Options = new List<string> {
            "Adding features without proper evaluation",
            "Reducing project scope",
            "Following project scope",
            "Removing unnecessary features"
        },
        CorrectAnswer = 0,
        Explanation = "Scope creep occurs when new features are added to a project without proper evaluation, often causing delays and budget overruns."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ProjectWorkflow",
        Question = "What is a user story?",
        Options = new List<string> {
            "A technical specification",
            "A requirement written from an end-user perspective",
            "A database schema",
            "A code comment"
        },
        CorrectAnswer = 1,
        Explanation = "A user story is a requirement written from an end-user perspective, typically following the format: 'As a [user], I want [feature], so that [benefit].'"
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ProjectWorkflow",
        Question = "What are acceptance criteria in requirements?",
        Options = new List<string> {
            "The definition of done for a user story",
            "The project budget",
            "The project timeline",
            "The team members assigned"
        },
        CorrectAnswer = 0,
        Explanation = "Acceptance criteria define the conditions that must be met for a user story to be considered complete."
    },

    // ===== LESSON 2: Planning and Architecture (6 Questions) =====
    new QuizQuestion
    {
        Id = 7,
        Topic = "ProjectWorkflow",
        Question = "What is the purpose of project planning?",
        Options = new List<string> {
            "To reduce risks and save time",
            "To make the project more complex",
            "To delay the project",
            "To increase costs"
        },
        CorrectAnswer = 0,
        Explanation = "Project planning reduces risks, saves time, and ensures a successful outcome by defining scope, timeline, and resources."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "ProjectWorkflow",
        Question = "What are the typical layers in a layered architecture?",
        Options = new List<string> {
            "UI, Business Logic, Data Access, Database",
            "Frontend, Backend, Database",
            "Client, Server, Database",
            "Presentation, Application, Infrastructure"
        },
        CorrectAnswer = 0,
        Explanation = "A typical layered (N-Tier) architecture includes Presentation Layer (UI), Business Logic Layer, Data Access Layer, and Database Layer."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "ProjectWorkflow",
        Question = "What is Clean Architecture?",
        Options = new List<string> {
            "An architecture that separates domain, application, infrastructure, and presentation",
            "An architecture that only uses one layer",
            "An architecture without any layers",
            "An architecture that only focuses on the database"
        },
        CorrectAnswer = 0,
        Explanation = "Clean Architecture organizes code into Domain, Application, Infrastructure, and Presentation layers, with dependencies pointing inward."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "ProjectWorkflow",
        Question = "What should you consider when selecting technology for a project?",
        Options = new List<string> {
            "Project requirements, team expertise, scalability, community support, cost",
            "Only the cost",
            "Only the team expertise",
            "Only the project requirements"
        },
        CorrectAnswer = 0,
        Explanation = "Technology selection should consider project requirements, team expertise, scalability needs, community support, and cost."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "ProjectWorkflow",
        Question = "What is the purpose of an Entity-Relationship (ER) diagram?",
        Options = new List<string> {
            "To visualize database entities and their relationships",
            "To create user interfaces",
            "To write code",
            "To test applications"
        },
        CorrectAnswer = 0,
        Explanation = "An ER diagram visualizes database entities (tables) and their relationships, helping design the database schema."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "ProjectWorkflow",
        Question = "Which HTTP method is used to create a new resource in a REST API?",
        Options = new List<string> {
            "GET",
            "POST",
            "PUT",
            "DELETE"
        },
        CorrectAnswer = 1,
        Explanation = "POST is used to create a new resource in a REST API."
    },

    // ===== LESSON 3: Git Branching Strategy (6 Questions) =====
    new QuizQuestion
    {
        Id = 13,
        Topic = "ProjectWorkflow",
        Question = "What is the purpose of a Git branching strategy?",
        Options = new List<string> {
            "To complicate the development process",
            "To enable team collaboration and stable releases",
            "To delete branches",
            "To slow down development"
        },
        CorrectAnswer = 1,
        Explanation = "A Git branching strategy enables team collaboration, stable releases, and an efficient development workflow."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "ProjectWorkflow",
        Question = "What is Git Flow?",
        Options = new List<string> {
            "A simple branching strategy with only main branch",
            "A branching strategy with main, develop, feature, release, and hotfix branches",
            "A strategy that doesn't use branches",
            "A strategy only for bug fixes"
        },
        CorrectAnswer = 1,
        Explanation = "Git Flow uses main (production), develop (integration), feature/*, release/*, and hotfix/* branches."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "ProjectWorkflow",
        Question = "What is GitHub Flow?",
        Options = new List<string> {
            "A complex branching strategy",
            "A simpler branching strategy with only main and feature branches",
            "A strategy that doesn't use pull requests",
            "A strategy only for releases"
        },
        CorrectAnswer = 1,
        Explanation = "GitHub Flow is a simpler strategy using main and feature/* branches with pull requests for code review."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "ProjectWorkflow",
        Question = "What is a Pull Request?",
        Options = new List<string> {
            "A request to delete a branch",
            "A request to merge code changes",
            "A request to create a new repository",
            "A request to push changes"
        },
        CorrectAnswer = 1,
        Explanation = "A Pull Request is a request to merge code changes from one branch into another, typically used for code review."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "ProjectWorkflow",
        Question = "What is a merge conflict in Git?",
        Options = new List<string> {
            "When Git automatically merges changes",
            "When changes in different branches conflict with each other",
            "When a branch is deleted",
            "When a commit is pushed"
        },
        CorrectAnswer = 1,
        Explanation = "A merge conflict occurs when changes in different branches conflict with each other and need manual resolution."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "ProjectWorkflow",
        Question = "Which command creates a new branch and switches to it in Git?",
        Options = new List<string> {
            "git branch new-branch",
            "git checkout -b new-branch",
            "git switch -c new-branch",
            "Both B and C"
        },
        CorrectAnswer = 3,
        Explanation = "Both 'git checkout -b' and 'git switch -c' create a new branch and switch to it."
    },

    // ===== LESSON 4: Coding Standards (6 Questions) =====
    new QuizQuestion
    {
        Id = 19,
        Topic = "ProjectWorkflow",
        Question = "Why are coding standards important?",
        Options = new List<string> {
            "To make code less readable",
            "To ensure readable, maintainable, and consistent code",
            "To slow down development",
            "To make code reviews harder"
        },
        CorrectAnswer = 1,
        Explanation = "Coding standards ensure readable, maintainable, and consistent code, making it easier to review and onboard new developers."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "ProjectWorkflow",
        Question = "What naming convention is used for classes in C#?",
        Options = new List<string> {
            "camelCase",
            "PascalCase",
            "snake_case",
            "UPPER_CASE"
        },
        CorrectAnswer = 1,
        Explanation = "Classes in C# use PascalCase naming convention (e.g., UserService, ProductController)."
    },
    new QuizQuestion
    {
        Id = 21,
        Topic = "ProjectWorkflow",
        Question = "What naming convention is used for private fields in C#?",
        Options = new List<string> {
            "_camelCase",
            "PascalCase",
            "camelCase",
            "UPPER_CASE"
        },
        CorrectAnswer = 0,
        Explanation = "Private fields in C# typically use _camelCase naming convention (e.g., _logger, _userRepository)."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "ProjectWorkflow",
        Question = "What does the Single Responsibility Principle state?",
        Options = new List<string> {
            "A class should have multiple responsibilities",
            "A class should have only one reason to change",
            "A class should not have any responsibilities",
            "A class should be responsible for everything"
        },
        CorrectAnswer = 1,
        Explanation = "The Single Responsibility Principle states that a class should have only one reason to change - one responsibility."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "ProjectWorkflow",
        Question = "What is a guard clause?",
        Options = new List<string> {
            "A clause that validates inputs at the start of a method",
            "A clause that catches exceptions",
            "A clause that returns early",
            "A clause that logs errors"
        },
        CorrectAnswer = 0,
        Explanation = "A guard clause validates inputs and checks conditions at the start of a method, returning early if conditions aren't met."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "ProjectWorkflow",
        Question = "What should you review during a code review?",
        Options = new List<string> {
            "Only the code style",
            "Functionality, standards, security, performance, test coverage, and documentation",
            "Only the functionality",
            "Only the performance"
        },
        CorrectAnswer = 1,
        Explanation = "Code reviews should check functionality, coding standards, security, performance, test coverage, and documentation."
    },

    // ===== LESSON 5: Testing and Delivering (6 Questions) =====
    new QuizQuestion
    {
        Id = 25,
        Topic = "ProjectWorkflow",
        Question = "What is Unit Testing?",
        Options = new List<string> {
            "Testing the entire application",
            "Testing individual components in isolation",
            "Testing the user interface",
            "Testing the database"
        },
        CorrectAnswer = 1,
        Explanation = "Unit testing verifies that individual components (methods, classes) behave correctly in isolation."
    },
    new QuizQuestion
    {
        Id = 26,
        Topic = "ProjectWorkflow",
        Question = "What is the TDD cycle?",
        Options = new List<string> {
            "Write code, test, deploy",
            "Write a failing test, write code to make it pass, refactor",
            "Design, code, test",
            "Plan, code, test"
        },
        CorrectAnswer = 1,
        Explanation = "TDD follows the Red-Green-Refactor cycle: write a failing test (Red), write code to make it pass (Green), then refactor."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "ProjectWorkflow",
        Question = "What is Integration Testing?",
        Options = new List<string> {
            "Testing individual units",
            "Testing how components work together",
            "Testing the user interface",
            "Testing performance"
        },
        CorrectAnswer = 1,
        Explanation = "Integration testing verifies how different components work together correctly."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "ProjectWorkflow",
        Question = "What is Continuous Integration (CI)?",
        Options = new List<string> {
            "Manual testing before deployment",
            "Automatically building and testing code on every push",
            "Deploying code to production",
            "Writing code continuously"
        },
        CorrectAnswer = 1,
        Explanation = "CI automatically builds and tests code on every push, catching issues early."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "ProjectWorkflow",
        Question = "What is Blue-Green Deployment?",
        Options = new List<string> {
            "Deploying to production directly",
            "Using two identical environments for zero-downtime deployment",
            "Deploying to a single server",
            "Deploying to development only"
        },
        CorrectAnswer = 1,
        Explanation = "Blue-Green Deployment uses two identical environments (Blue and Green) to enable zero-downtime deployments."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "ProjectWorkflow",
        Question = "What is Canary Deployment?",
        Options = new List<string> {
            "Deploying all at once",
            "Gradually rolling out a change to a small subset of users first",
            "Deploying only to test environment",
            "Deploying without testing"
        },
        CorrectAnswer = 1,
        Explanation = "Canary Deployment gradually rolls out changes to a small subset of users first, reducing risk."
    }
};

        // ================================================================
        // GETTING STARTED - LESSON 1: Installing Visual Studio
        // ================================================================
        _quizzes["GettingStarted_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "GettingStarted_Lesson1",
        Question = "What is Visual Studio?",
        Options = new List<string> {
            "A lightweight code editor",
            "A full-featured IDE for C# development",
            "A web browser",
            "A database management tool"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio is a full-featured Integrated Development Environment (IDE) for C# development."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "GettingStarted_Lesson1",
        Question = "What is the free edition of Visual Studio called?",
        Options = new List<string> {
            "Visual Studio Free",
            "Visual Studio Community",
            "Visual Studio Express",
            "Visual Studio Basic"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio Community is the free edition of Visual Studio for individuals and open-source work."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "GettingStarted_Lesson1",
        Question = "Where can you download Visual Studio Community?",
        Options = new List<string> {
            "visualstudio.microsoft.com/downloads",
            "github.com",
            "microsoft.com",
            "codeplex.com"
        },
        CorrectAnswer = 0,
        Explanation = "Visual Studio Community can be downloaded from visualstudio.microsoft.com/downloads."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "GettingStarted_Lesson1",
        Question = "Which edition of Visual Studio is completely free for individuals?",
        Options = new List<string> {
            "Visual Studio Professional",
            "Visual Studio Enterprise",
            "Visual Studio Community",
            "Visual Studio Code"
        },
        CorrectAnswer = 2,
        Explanation = "Visual Studio Community is completely free for individuals and open-source projects."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "GettingStarted_Lesson1",
        Question = "What is the purpose of a workload in Visual Studio?",
        Options = new List<string> {
            "A bundle of tools for specific development types",
            "A programming language",
            "A project template",
            "A database"
        },
        CorrectAnswer = 0,
        Explanation = "A workload is a bundle of tools, libraries, and templates for specific types of development."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "GettingStarted_Lesson1",
        Question = "What is the latest version of Visual Studio recommended for this course?",
        Options = new List<string> {
            "Visual Studio 2017",
            "Visual Studio 2019",
            "Visual Studio 2022",
            "Visual Studio Code"
        },
        CorrectAnswer = 2,
        Explanation = "Visual Studio 2022 is the latest version recommended for this course."
    }
};

        // ================================================================
        // GETTING STARTED - LESSON 2: Choosing the Right Workloads
        // ================================================================
        _quizzes["GettingStarted_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "GettingStarted_Lesson2",
        Question = "Which workload is required for Razor Pages and web development?",
        Options = new List<string> {
            ".NET desktop development",
            "ASP.NET and web development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 1,
        Explanation = "ASP.NET and web development workload is required for Razor Pages, web APIs, and web development."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "GettingStarted_Lesson2",
        Question = "Which workload is required for Console Apps and Windows Forms?",
        Options = new List<string> {
            "ASP.NET and web development",
            ".NET desktop development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 1,
        Explanation = ".NET desktop development workload is required for Console Applications and Windows Forms."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "GettingStarted_Lesson2",
        Question = "Which workload is required for .NET MAUI mobile and desktop development?",
        Options = new List<string> {
            "ASP.NET and web development",
            ".NET desktop development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 2,
        Explanation = ".NET Multi-platform App UI development workload is required for .NET MAUI mobile and desktop apps."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "GettingStarted_Lesson2",
        Question = "What is the purpose of a workload in Visual Studio?",
        Options = new List<string> {
            "To select a theme",
            "To install specific tools for development types",
            "To create a new project",
            "To configure Git"
        },
        CorrectAnswer = 1,
        Explanation = "Workloads install specific tools, libraries, and templates for different types of development."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "GettingStarted_Lesson2",
        Question = "Which workload is optional but adds SQL Server Data Tools support?",
        Options = new List<string> {
            "ASP.NET and web development",
            ".NET desktop development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 3,
        Explanation = "Data storage and processing is optional but adds SQL Server Data Tools support inside Visual Studio."
    }
};

        // ================================================================
        // GETTING STARTED - LESSON 3: Installing SQL Server Express & SSMS
        // ================================================================
        _quizzes["GettingStarted_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "GettingStarted_Lesson3",
        Question = "What is SQL Server Express?",
        Options = new List<string> {
            "A web server",
            "A free version of SQL Server",
            "A development IDE",
            "A version control system"
        },
        CorrectAnswer = 1,
        Explanation = "SQL Server Express is the free version of Microsoft SQL Server."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "GettingStarted_Lesson3",
        Question = "What does SSMS stand for?",
        Options = new List<string> {
            "SQL Server Management System",
            "SQL Server Management Studio",
            "SQL Server Monitoring System",
            "Standard SQL Management Server"
        },
        CorrectAnswer = 1,
        Explanation = "SSMS stands for SQL Server Management Studio, the visual tool for managing SQL Server."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "GettingStarted_Lesson3",
        Question = "What is the default instance name for SQL Server Express?",
        Options = new List<string> {
            "localhost\\MSSQL",
            "localhost\\SQLEXPRESS",
            "localhost\\SQLSERVER",
            "localhost\\MSSQLSERVER"
        },
        CorrectAnswer = 1,
        Explanation = "SQL Server Express typically uses the instance name localhost\\SQLEXPRESS."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "GettingStarted_Lesson3",
        Question = "What authentication method is recommended for local development?",
        Options = new List<string> {
            "SQL Server Authentication",
            "Windows Authentication",
            "Mixed Mode",
            "None"
        },
        CorrectAnswer = 1,
        Explanation = "Windows Authentication is recommended for local development as it uses your Windows credentials."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "GettingStarted_Lesson3",
        Question = "What are the system databases in SQL Server?",
        Options = new List<string> {
            "master, model, msdb, tempdb",
            "user1, user2, user3, user4",
            "system1, system2, system3, system4",
            "data1, data2, data3, data4"
        },
        CorrectAnswer = 0,
        Explanation = "The system databases are master, model, msdb, and tempdb."
    }
};
        // ================================================================
        // GETTING STARTED - LESSON 4: Installing Git
        // ================================================================
        _quizzes["GettingStarted_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "GettingStarted_Lesson4",
        Question = "What is Git?",
        Options = new List<string> {
            "A programming language",
            "A version control system",
            "A web framework",
            "A database"
        },
        CorrectAnswer = 1,
        Explanation = "Git is a distributed version control system used to track changes in source code."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "GettingStarted_Lesson4",
        Question = "Where can you download Git?",
        Options = new List<string> {
            "github.com",
            "git-scm.com",
            "microsoft.com",
            "visualstudio.com"
        },
        CorrectAnswer = 1,
        Explanation = "Git can be downloaded from git-scm.com."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "GettingStarted_Lesson4",
        Question = "What command configures your Git username?",
        Options = new List<string> {
            "git config --global user.name",
            "git set --global user.name",
            "git user --name",
            "git name --set"
        },
        CorrectAnswer = 0,
        Explanation = "The command 'git config --global user.name' sets your Git username globally."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "GettingStarted_Lesson4",
        Question = "What command verifies Git installation?",
        Options = new List<string> {
            "git --version",
            "git check",
            "git verify",
            "git status"
        },
        CorrectAnswer = 0,
        Explanation = "The 'git --version' command displays the installed Git version to verify installation."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "GettingStarted_Lesson4",
        Question = "What is the default branch name in modern Git?",
        Options = new List<string> {
            "master",
            "main",
            "default",
            "primary"
        },
        CorrectAnswer = 1,
        Explanation = "The default branch name in modern Git is 'main'."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "GettingStarted_Lesson4",
        Question = "Why do you need Git for development?",
        Options = new List<string> {
            "To track changes and collaborate",
            "To compile code",
            "To debug applications",
            "To deploy applications"
        },
        CorrectAnswer = 0,
        Explanation = "Git is used to track changes to code, collaborate with teams, and manage different versions of your code."
    }
};


        // ================================================================
        // GETTING STARTED - FULL SECTION (All 22 Questions)
        // ================================================================
        _quizzes["GettingStarted"] = new List<QuizQuestion>
{
    // ===== LESSON 1: Installing Visual Studio (6 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "GettingStarted",
        Question = "What is Visual Studio?",
        Options = new List<string> {
            "A lightweight code editor",
            "A full-featured IDE for C# development",
            "A web browser",
            "A database management tool"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio is a full-featured Integrated Development Environment (IDE) for C# development."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "GettingStarted",
        Question = "What is the free edition of Visual Studio called?",
        Options = new List<string> {
            "Visual Studio Free",
            "Visual Studio Community",
            "Visual Studio Express",
            "Visual Studio Basic"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio Community is the free edition of Visual Studio for individuals and open-source work."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "GettingStarted",
        Question = "Where can you download Visual Studio Community?",
        Options = new List<string> {
            "visualstudio.microsoft.com/downloads",
            "github.com",
            "microsoft.com",
            "codeplex.com"
        },
        CorrectAnswer = 0,
        Explanation = "Visual Studio Community can be downloaded from visualstudio.microsoft.com/downloads."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "GettingStarted",
        Question = "Which edition of Visual Studio is completely free for individuals?",
        Options = new List<string> {
            "Visual Studio Professional",
            "Visual Studio Enterprise",
            "Visual Studio Community",
            "Visual Studio Code"
        },
        CorrectAnswer = 2,
        Explanation = "Visual Studio Community is completely free for individuals and open-source projects."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "GettingStarted",
        Question = "What is the purpose of a workload in Visual Studio?",
        Options = new List<string> {
            "A bundle of tools for specific development types",
            "A programming language",
            "A project template",
            "A database"
        },
        CorrectAnswer = 0,
        Explanation = "A workload is a bundle of tools, libraries, and templates for specific types of development."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "GettingStarted",
        Question = "What is the latest version of Visual Studio recommended for this course?",
        Options = new List<string> {
            "Visual Studio 2017",
            "Visual Studio 2019",
            "Visual Studio 2022",
            "Visual Studio Code"
        },
        CorrectAnswer = 2,
        Explanation = "Visual Studio 2022 is the latest version recommended for this course."
    },

    // ===== LESSON 2: Choosing the Right Workloads (5 Questions) =====
    new QuizQuestion
    {
        Id = 7,
        Topic = "GettingStarted",
        Question = "Which workload is required for Razor Pages and web development?",
        Options = new List<string> {
            ".NET desktop development",
            "ASP.NET and web development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 1,
        Explanation = "ASP.NET and web development workload is required for Razor Pages, web APIs, and web development."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "GettingStarted",
        Question = "Which workload is required for Console Apps and Windows Forms?",
        Options = new List<string> {
            "ASP.NET and web development",
            ".NET desktop development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 1,
        Explanation = ".NET desktop development workload is required for Console Applications and Windows Forms."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "GettingStarted",
        Question = "Which workload is required for .NET MAUI mobile and desktop development?",
        Options = new List<string> {
            "ASP.NET and web development",
            ".NET desktop development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 2,
        Explanation = ".NET Multi-platform App UI development workload is required for .NET MAUI mobile and desktop apps."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "GettingStarted",
        Question = "What is the purpose of a workload in Visual Studio?",
        Options = new List<string> {
            "To select a theme",
            "To install specific tools for development types",
            "To create a new project",
            "To configure Git"
        },
        CorrectAnswer = 1,
        Explanation = "Workloads install specific tools, libraries, and templates for different types of development."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "GettingStarted",
        Question = "Which workload is optional but adds SQL Server Data Tools support?",
        Options = new List<string> {
            "ASP.NET and web development",
            ".NET desktop development",
            ".NET Multi-platform App UI development",
            "Data storage and processing"
        },
        CorrectAnswer = 3,
        Explanation = "Data storage and processing is optional but adds SQL Server Data Tools support inside Visual Studio."
    },

    // ===== LESSON 3: Installing SQL Server Express & SSMS (5 Questions) =====
    new QuizQuestion
    {
        Id = 12,
        Topic = "GettingStarted",
        Question = "What is SQL Server Express?",
        Options = new List<string> {
            "A web server",
            "A free version of SQL Server",
            "A development IDE",
            "A version control system"
        },
        CorrectAnswer = 1,
        Explanation = "SQL Server Express is the free version of Microsoft SQL Server."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "GettingStarted",
        Question = "What does SSMS stand for?",
        Options = new List<string> {
            "SQL Server Management System",
            "SQL Server Management Studio",
            "SQL Server Monitoring System",
            "Standard SQL Management Server"
        },
        CorrectAnswer = 1,
        Explanation = "SSMS stands for SQL Server Management Studio, the visual tool for managing SQL Server."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "GettingStarted",
        Question = "What is the default instance name for SQL Server Express?",
        Options = new List<string> {
            "localhost\\MSSQL",
            "localhost\\SQLEXPRESS",
            "localhost\\SQLSERVER",
            "localhost\\MSSQLSERVER"
        },
        CorrectAnswer = 1,
        Explanation = "SQL Server Express typically uses the instance name localhost\\SQLEXPRESS."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "GettingStarted",
        Question = "What authentication method is recommended for local development?",
        Options = new List<string> {
            "SQL Server Authentication",
            "Windows Authentication",
            "Mixed Mode",
            "None"
        },
        CorrectAnswer = 1,
        Explanation = "Windows Authentication is recommended for local development as it uses your Windows credentials."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "GettingStarted",
        Question = "What are the system databases in SQL Server?",
        Options = new List<string> {
            "master, model, msdb, tempdb",
            "user1, user2, user3, user4",
            "system1, system2, system3, system4",
            "data1, data2, data3, data4"
        },
        CorrectAnswer = 0,
        Explanation = "The system databases are master, model, msdb, and tempdb."
    },

    // ===== LESSON 4: Installing Git (6 Questions) =====
    new QuizQuestion
    {
        Id = 17,
        Topic = "GettingStarted",
        Question = "What is Git?",
        Options = new List<string> {
            "A programming language",
            "A version control system",
            "A web framework",
            "A database"
        },
        CorrectAnswer = 1,
        Explanation = "Git is a distributed version control system used to track changes in source code."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "GettingStarted",
        Question = "Where can you download Git?",
        Options = new List<string> {
            "github.com",
            "git-scm.com",
            "microsoft.com",
            "visualstudio.com"
        },
        CorrectAnswer = 1,
        Explanation = "Git can be downloaded from git-scm.com."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "GettingStarted",
        Question = "What command configures your Git username?",
        Options = new List<string> {
            "git config --global user.name",
            "git set --global user.name",
            "git user --name",
            "git name --set"
        },
        CorrectAnswer = 0,
        Explanation = "The command 'git config --global user.name' sets your Git username globally."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "GettingStarted",
        Question = "What command verifies Git installation?",
        Options = new List<string> {
            "git --version",
            "git check",
            "git verify",
            "git status"
        },
        CorrectAnswer = 0,
        Explanation = "The 'git --version' command displays the installed Git version to verify installation."
    },
    new QuizQuestion
    {
        Id = 21,
        Topic = "GettingStarted",
        Question = "What is the default branch name in modern Git?",
        Options = new List<string> {
            "master",
            "main",
            "default",
            "primary"
        },
        CorrectAnswer = 1,
        Explanation = "The default branch name in modern Git is 'main'."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "GettingStarted",
        Question = "Why do you need Git for development?",
        Options = new List<string> {
            "To track changes and collaborate",
            "To compile code",
            "To debug applications",
            "To deploy applications"
        },
        CorrectAnswer = 0,
        Explanation = "Git is used to track changes to code, collaborate with teams, and manage different versions of your code."
    }
};



        // ================================================================
        // EXTRA TOPICS - LESSON 1: Git & GitHub
        // ================================================================
        _quizzes["ExtraTopics_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics_Lesson1",
        Question = "What is Git?",
        Options = new List<string> {
            "A programming language",
            "A version control system",
            "A web framework",
            "A database"
        },
        CorrectAnswer = 1,
        Explanation = "Git is a distributed version control system used to track changes in source code."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics_Lesson1",
        Question = "What command initializes a new Git repository?",
        Options = new List<string> {
            "git start",
            "git init",
            "git new",
            "git create"
        },
        CorrectAnswer = 1,
        Explanation = "The 'git init' command initializes a new Git repository in the current directory."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics_Lesson1",
        Question = "What is the purpose of a .gitignore file?",
        Options = new List<string> {
            "To ignore all files",
            "To specify which files Git should not track",
            "To ignore Git commands",
            "To delete files"
        },
        CorrectAnswer = 1,
        Explanation = "A .gitignore file specifies which files and directories Git should ignore and not track."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics_Lesson1",
        Question = "What does 'git add .' do?",
        Options = new List<string> {
            "Adds all files to the repository",
            "Stages all changes for commit",
            "Deletes all files",
            "Creates a new branch"
        },
        CorrectAnswer = 1,
        Explanation = "The 'git add .' command stages all changes in the current directory for the next commit."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics_Lesson1",
        Question = "What is a Pull Request?",
        Options = new List<string> {
            "A request to pull changes from GitHub",
            "A request to merge code changes",
            "A request to delete a branch",
            "A request to create a new repository"
        },
        CorrectAnswer = 1,
        Explanation = "A Pull Request is a request to merge code changes from one branch into another."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics_Lesson1",
        Question = "What command creates a new branch in Git?",
        Options = new List<string> {
            "git branch new",
            "git checkout -b",
            "git branch -c",
            "git new-branch"
        },
        CorrectAnswer = 1,
        Explanation = "The 'git checkout -b' command creates and switches to a new branch."
    }
};

        // ================================================================
        // EXTRA TOPICS - LESSON 2: Unit Testing with xUnit
        // ================================================================
        _quizzes["ExtraTopics_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics_Lesson2",
        Question = "What is the purpose of unit testing?",
        Options = new List<string> {
            "To test the entire application",
            "To verify individual code units behave correctly",
            "To test the database",
            "To test the user interface"
        },
        CorrectAnswer = 1,
        Explanation = "Unit testing verifies that individual units of code (methods, classes) behave correctly."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics_Lesson2",
        Question = "What does the AAA pattern stand for in testing?",
        Options = new List<string> {
            "Arrange, Act, Assert",
            "Action, Analyze, Assert",
            "Arrange, Assert, Act",
            "Act, Arrange, Assert"
        },
        CorrectAnswer = 0,
        Explanation = "AAA stands for Arrange (setup), Act (execute), and Assert (verify)."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics_Lesson2",
        Question = "What is the difference between [Fact] and [Theory] in xUnit?",
        Options = new List<string> {
            "[Fact] is for single tests, [Theory] is for data-driven tests",
            "[Theory] is for single tests, [Fact] is for data-driven tests",
            "They are the same",
            "[Fact] is for async tests only"
        },
        CorrectAnswer = 0,
        Explanation = "[Fact] is used for individual tests, while [Theory] is used for data-driven tests with multiple inputs."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics_Lesson2",
        Question = "Which command runs unit tests in .NET?",
        Options = new List<string> {
            "dotnet run tests",
            "dotnet test",
            "dotnet build tests",
            "dotnet execute tests"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet test' command runs all unit tests in the project."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics_Lesson2",
        Question = "What is the purpose of Assert in unit testing?",
        Options = new List<string> {
            "To arrange the test data",
            "To verify the expected result",
            "To execute the code",
            "To setup the test"
        },
        CorrectAnswer = 1,
        Explanation = "Assert is used to verify that the actual result matches the expected result."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics_Lesson2",
        Question = "How do you test that a method throws an exception in xUnit?",
        Options = new List<string> {
            "Using try-catch",
            "Using Assert.Throws",
            "Using ExceptionAssert",
            "Using throws keyword"
        },
        CorrectAnswer = 1,
        Explanation = "Assert.Throws is used in xUnit to verify that a method throws a specific exception."
    }
};

        // ================================================================
        // EXTRA TOPICS - LESSON 3: Design Patterns
        // ================================================================
        _quizzes["ExtraTopics_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics_Lesson3",
        Question = "What is the Singleton pattern?",
        Options = new List<string> {
            "A pattern that ensures only one instance of a class exists",
            "A pattern that creates multiple instances",
            "A pattern for database access",
            "A pattern for UI design"
        },
        CorrectAnswer = 0,
        Explanation = "The Singleton pattern ensures that a class has only one instance and provides a global access point to it."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics_Lesson3",
        Question = "What is the purpose of the Factory pattern?",
        Options = new List<string> {
            "To create objects without specifying the exact class",
            "To destroy objects",
            "To manage object lifecycle",
            "To optimize performance"
        },
        CorrectAnswer = 0,
        Explanation = "The Factory pattern centralizes object creation, allowing you to create objects without specifying the exact class."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics_Lesson3",
        Question = "What is the Repository pattern used for?",
        Options = new List<string> {
            "To separate data access logic from business logic",
            "To store configuration",
            "To manage user sessions",
            "To handle errors"
        },
        CorrectAnswer = 0,
        Explanation = "The Repository pattern separates data access logic from business logic, making the code more maintainable."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics_Lesson3",
        Question = "What is Dependency Injection?",
        Options = new List<string> {
            "A pattern where objects receive their dependencies from an external source",
            "A pattern where objects create their own dependencies",
            "A pattern for database access",
            "A pattern for UI design"
        },
        CorrectAnswer = 0,
        Explanation = "Dependency Injection is a pattern where objects receive their dependencies from an external source rather than creating them internally."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics_Lesson3",
        Question = "What is the Strategy pattern?",
        Options = new List<string> {
            "A pattern that allows swapping behavior at runtime",
            "A pattern for database access",
            "A pattern for UI design",
            "A pattern for error handling"
        },
        CorrectAnswer = 0,
        Explanation = "The Strategy pattern allows you to swap algorithms or behaviors at runtime by encapsulating them in separate classes."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics_Lesson3",
        Question = "Which pattern is commonly used with Dependency Injection?",
        Options = new List<string> {
            "Singleton",
            "Factory",
            "Repository",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Singleton, Factory, and Repository patterns all work well with Dependency Injection."
    }
};

        // ================================================================
        // EXTRA TOPICS - LESSON 4: Async/Await Deep Dive
        // ================================================================
        _quizzes["ExtraTopics_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics_Lesson4",
        Question = "What is the purpose of async/await in C#?",
        Options = new List<string> {
            "To make code run faster",
            "To handle asynchronous operations without blocking threads",
            "To simplify error handling",
            "To improve memory management"
        },
        CorrectAnswer = 1,
        Explanation = "async/await allows you to write asynchronous code that doesn't block threads during I/O operations."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics_Lesson4",
        Question = "What type does an async method typically return?",
        Options = new List<string> {
            "void",
            "Task",
            "Task<T>",
            "Either B or C"
        },
        CorrectAnswer = 3,
        Explanation = "Async methods typically return Task (for no return value) or Task<T> (for a return value)."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics_Lesson4",
        Question = "What does the await keyword do?",
        Options = new List<string> {
            "Blocks the thread",
            "Suspends execution until the awaited task completes",
            "Creates a new thread",
            "Cancels the operation"
        },
        CorrectAnswer = 1,
        Explanation = "The await keyword suspends execution of the current method until the awaited task completes."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics_Lesson4",
        Question = "What is Task.WhenAll used for?",
        Options = new List<string> {
            "To run tasks sequentially",
            "To run multiple tasks in parallel",
            "To cancel tasks",
            "To handle errors in tasks"
        },
        CorrectAnswer = 1,
        Explanation = "Task.WhenAll allows you to run multiple tasks in parallel and wait for all of them to complete."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics_Lesson4",
        Question = "What is the difference between Result and await on a Task?",
        Options = new List<string> {
            "Result blocks, await doesn't",
            "await blocks, Result doesn't",
            "They are the same",
            "Result is faster than await"
        },
        CorrectAnswer = 0,
        Explanation = "Using .Result blocks the thread until the task completes, while await suspends the method without blocking the thread."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics_Lesson4",
        Question = "How do you handle exceptions in async methods?",
        Options = new List<string> {
            "Using try-catch blocks",
            "Using the catch keyword",
            "Using Exception Handling",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Exceptions in async methods are handled using try-catch blocks, just like synchronous methods."
    }
};

        // ================================================================
        // EXTRA TOPICS - LESSON 5: REST APIs with Web API
        // ================================================================
        _quizzes["ExtraTopics_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics_Lesson5",
        Question = "What does REST stand for?",
        Options = new List<string> {
            "Representational State Transfer",
            "Representative State Transfer",
            "Restful State Transfer",
            "Response State Transfer"
        },
        CorrectAnswer = 0,
        Explanation = "REST stands for Representational State Transfer, an architectural style for designing networked applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics_Lesson5",
        Question = "What HTTP method is used to retrieve data in a REST API?",
        Options = new List<string> {
            "POST",
            "GET",
            "PUT",
            "DELETE"
        },
        CorrectAnswer = 1,
        Explanation = "GET is used to retrieve data from a REST API."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics_Lesson5",
        Question = "What HTTP method is used to create new data in a REST API?",
        Options = new List<string> {
            "GET",
            "POST",
            "PUT",
            "DELETE"
        },
        CorrectAnswer = 1,
        Explanation = "POST is used to create new data in a REST API."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics_Lesson5",
        Question = "What is the purpose of the [ApiController] attribute?",
        Options = new List<string> {
            "To enable automatic model validation",
            "To disable model validation",
            "To enable CORS",
            "To disable authentication"
        },
        CorrectAnswer = 0,
        Explanation = "The [ApiController] attribute enables automatic model validation and other API-specific behaviors."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics_Lesson5",
        Question = "What does the [Route] attribute do?",
        Options = new List<string> {
            "Defines the URL route for a controller or action",
            "Defines the HTTP method",
            "Defines the response format",
            "Defines the authentication method"
        },
        CorrectAnswer = 0,
        Explanation = "The [Route] attribute defines the URL route for a controller or action method."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics_Lesson5",
        Question = "What status code does CreatedAtAction return?",
        Options = new List<string> {
            "200 OK",
            "201 Created",
            "204 No Content",
            "404 Not Found"
        },
        CorrectAnswer = 1,
        Explanation = "CreatedAtAction returns a 201 Created status code with a location header pointing to the newly created resource."
    }
};

        // ================================================================
        // EXTRA TOPICS - LESSON 6: NuGet Packages
        // ================================================================
        _quizzes["ExtraTopics_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics_Lesson6",
        Question = "What is NuGet?",
        Options = new List<string> {
            "A programming language",
            "A package manager for .NET",
            "A web framework",
            "A database"
        },
        CorrectAnswer = 1,
        Explanation = "NuGet is the official package manager for .NET, used to install and manage libraries."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics_Lesson6",
        Question = "What command installs a NuGet package using the .NET CLI?",
        Options = new List<string> {
            "dotnet install package",
            "dotnet add package",
            "dotnet get package",
            "dotnet new package"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet add package' command installs a NuGet package."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics_Lesson6",
        Question = "What command installs a NuGet package using Package Manager Console?",
        Options = new List<string> {
            "Install-Package",
            "Add-Package",
            "Get-Package",
            "New-Package"
        },
        CorrectAnswer = 0,
        Explanation = "Install-Package is the Package Manager Console command for installing NuGet packages."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics_Lesson6",
        Question = "Where are installed NuGet packages listed?",
        Options = new List<string> {
            "In the .csproj file",
            "In the appsettings.json file",
            "In the Program.cs file",
            "In the Git ignore file"
        },
        CorrectAnswer = 0,
        Explanation = "Installed NuGet packages are listed as PackageReference items in the .csproj file."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics_Lesson6",
        Question = "What is Newtonsoft.Json used for?",
        Options = new List<string> {
            "JSON serialization and deserialization",
            "Database access",
            "Logging",
            "Testing"
        },
        CorrectAnswer = 0,
        Explanation = "Newtonsoft.Json is a popular library for JSON serialization and deserialization."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics_Lesson6",
        Question = "What should you consider before installing a NuGet package?",
        Options = new List<string> {
            "The publisher's reputation",
            "The download count",
            "The license",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Always verify the publisher, download count, and license before installing a NuGet package."
    }
};


        // ================================================================
        // EXTRA TOPICS - FULL SECTION (All 36 Questions)
        // ================================================================
        _quizzes["ExtraTopics"] = new List<QuizQuestion>
{
    // ===== LESSON 1: Git & GitHub (6 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "ExtraTopics",
        Question = "What is Git?",
        Options = new List<string> {
            "A programming language",
            "A version control system",
            "A web framework",
            "A database"
        },
        CorrectAnswer = 1,
        Explanation = "Git is a distributed version control system used to track changes in source code."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "ExtraTopics",
        Question = "What command initializes a new Git repository?",
        Options = new List<string> {
            "git start",
            "git init",
            "git new",
            "git create"
        },
        CorrectAnswer = 1,
        Explanation = "The 'git init' command initializes a new Git repository in the current directory."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "ExtraTopics",
        Question = "What is the purpose of a .gitignore file?",
        Options = new List<string> {
            "To ignore all files",
            "To specify which files Git should not track",
            "To ignore Git commands",
            "To delete files"
        },
        CorrectAnswer = 1,
        Explanation = "A .gitignore file specifies which files and directories Git should ignore and not track."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "ExtraTopics",
        Question = "What does 'git add .' do?",
        Options = new List<string> {
            "Adds all files to the repository",
            "Stages all changes for commit",
            "Deletes all files",
            "Creates a new branch"
        },
        CorrectAnswer = 1,
        Explanation = "The 'git add .' command stages all changes in the current directory for the next commit."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "ExtraTopics",
        Question = "What is a Pull Request?",
        Options = new List<string> {
            "A request to pull changes from GitHub",
            "A request to merge code changes",
            "A request to delete a branch",
            "A request to create a new repository"
        },
        CorrectAnswer = 1,
        Explanation = "A Pull Request is a request to merge code changes from one branch into another."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "ExtraTopics",
        Question = "What command creates a new branch in Git?",
        Options = new List<string> {
            "git branch new",
            "git checkout -b",
            "git branch -c",
            "git new-branch"
        },
        CorrectAnswer = 1,
        Explanation = "The 'git checkout -b' command creates and switches to a new branch."
    },

    // ===== LESSON 2: Unit Testing with xUnit (6 Questions) =====
    new QuizQuestion
    {
        Id = 7,
        Topic = "ExtraTopics",
        Question = "What is the purpose of unit testing?",
        Options = new List<string> {
            "To test the entire application",
            "To verify individual code units behave correctly",
            "To test the database",
            "To test the user interface"
        },
        CorrectAnswer = 1,
        Explanation = "Unit testing verifies that individual units of code (methods, classes) behave correctly."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "ExtraTopics",
        Question = "What does the AAA pattern stand for in testing?",
        Options = new List<string> {
            "Arrange, Act, Assert",
            "Action, Analyze, Assert",
            "Arrange, Assert, Act",
            "Act, Arrange, Assert"
        },
        CorrectAnswer = 0,
        Explanation = "AAA stands for Arrange (setup), Act (execute), and Assert (verify)."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "ExtraTopics",
        Question = "What is the difference between [Fact] and [Theory] in xUnit?",
        Options = new List<string> {
            "[Fact] is for single tests, [Theory] is for data-driven tests",
            "[Theory] is for single tests, [Fact] is for data-driven tests",
            "They are the same",
            "[Fact] is for async tests only"
        },
        CorrectAnswer = 0,
        Explanation = "[Fact] is used for individual tests, while [Theory] is used for data-driven tests with multiple inputs."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "ExtraTopics",
        Question = "Which command runs unit tests in .NET?",
        Options = new List<string> {
            "dotnet run tests",
            "dotnet test",
            "dotnet build tests",
            "dotnet execute tests"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet test' command runs all unit tests in the project."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "ExtraTopics",
        Question = "What is the purpose of Assert in unit testing?",
        Options = new List<string> {
            "To arrange the test data",
            "To verify the expected result",
            "To execute the code",
            "To setup the test"
        },
        CorrectAnswer = 1,
        Explanation = "Assert is used to verify that the actual result matches the expected result."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "ExtraTopics",
        Question = "How do you test that a method throws an exception in xUnit?",
        Options = new List<string> {
            "Using try-catch",
            "Using Assert.Throws",
            "Using ExceptionAssert",
            "Using throws keyword"
        },
        CorrectAnswer = 1,
        Explanation = "Assert.Throws is used in xUnit to verify that a method throws a specific exception."
    },

    // ===== LESSON 3: Design Patterns (6 Questions) =====
    new QuizQuestion
    {
        Id = 13,
        Topic = "ExtraTopics",
        Question = "What is the Singleton pattern?",
        Options = new List<string> {
            "A pattern that ensures only one instance of a class exists",
            "A pattern that creates multiple instances",
            "A pattern for database access",
            "A pattern for UI design"
        },
        CorrectAnswer = 0,
        Explanation = "The Singleton pattern ensures that a class has only one instance and provides a global access point to it."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "ExtraTopics",
        Question = "What is the purpose of the Factory pattern?",
        Options = new List<string> {
            "To create objects without specifying the exact class",
            "To destroy objects",
            "To manage object lifecycle",
            "To optimize performance"
        },
        CorrectAnswer = 0,
        Explanation = "The Factory pattern centralizes object creation, allowing you to create objects without specifying the exact class."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "ExtraTopics",
        Question = "What is the Repository pattern used for?",
        Options = new List<string> {
            "To separate data access logic from business logic",
            "To store configuration",
            "To manage user sessions",
            "To handle errors"
        },
        CorrectAnswer = 0,
        Explanation = "The Repository pattern separates data access logic from business logic, making the code more maintainable."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "ExtraTopics",
        Question = "What is Dependency Injection?",
        Options = new List<string> {
            "A pattern where objects receive their dependencies from an external source",
            "A pattern where objects create their own dependencies",
            "A pattern for database access",
            "A pattern for UI design"
        },
        CorrectAnswer = 0,
        Explanation = "Dependency Injection is a pattern where objects receive their dependencies from an external source rather than creating them internally."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "ExtraTopics",
        Question = "What is the Strategy pattern?",
        Options = new List<string> {
            "A pattern that allows swapping behavior at runtime",
            "A pattern for database access",
            "A pattern for UI design",
            "A pattern for error handling"
        },
        CorrectAnswer = 0,
        Explanation = "The Strategy pattern allows you to swap algorithms or behaviors at runtime by encapsulating them in separate classes."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "ExtraTopics",
        Question = "Which pattern is commonly used with Dependency Injection?",
        Options = new List<string> {
            "Singleton",
            "Factory",
            "Repository",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Singleton, Factory, and Repository patterns all work well with Dependency Injection."
    },

    // ===== LESSON 4: Async/Await Deep Dive (6 Questions) =====
    new QuizQuestion
    {
        Id = 19,
        Topic = "ExtraTopics",
        Question = "What is the purpose of async/await in C#?",
        Options = new List<string> {
            "To make code run faster",
            "To handle asynchronous operations without blocking threads",
            "To simplify error handling",
            "To improve memory management"
        },
        CorrectAnswer = 1,
        Explanation = "async/await allows you to write asynchronous code that doesn't block threads during I/O operations."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "ExtraTopics",
        Question = "What type does an async method typically return?",
        Options = new List<string> {
            "void",
            "Task",
            "Task<T>",
            "Either B or C"
        },
        CorrectAnswer = 3,
        Explanation = "Async methods typically return Task (for no return value) or Task<T> (for a return value)."
    },
    new QuizQuestion
    {
        Id = 21,
        Topic = "ExtraTopics",
        Question = "What does the await keyword do?",
        Options = new List<string> {
            "Blocks the thread",
            "Suspends execution until the awaited task completes",
            "Creates a new thread",
            "Cancels the operation"
        },
        CorrectAnswer = 1,
        Explanation = "The await keyword suspends execution of the current method until the awaited task completes."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "ExtraTopics",
        Question = "What is Task.WhenAll used for?",
        Options = new List<string> {
            "To run tasks sequentially",
            "To run multiple tasks in parallel",
            "To cancel tasks",
            "To handle errors in tasks"
        },
        CorrectAnswer = 1,
        Explanation = "Task.WhenAll allows you to run multiple tasks in parallel and wait for all of them to complete."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "ExtraTopics",
        Question = "What is the difference between Result and await on a Task?",
        Options = new List<string> {
            "Result blocks, await doesn't",
            "await blocks, Result doesn't",
            "They are the same",
            "Result is faster than await"
        },
        CorrectAnswer = 0,
        Explanation = "Using .Result blocks the thread until the task completes, while await suspends the method without blocking the thread."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "ExtraTopics",
        Question = "How do you handle exceptions in async methods?",
        Options = new List<string> {
            "Using try-catch blocks",
            "Using the catch keyword",
            "Using Exception Handling",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Exceptions in async methods are handled using try-catch blocks, just like synchronous methods."
    },

    // ===== LESSON 5: REST APIs with Web API (6 Questions) =====
    new QuizQuestion
    {
        Id = 25,
        Topic = "ExtraTopics",
        Question = "What does REST stand for?",
        Options = new List<string> {
            "Representational State Transfer",
            "Representative State Transfer",
            "Restful State Transfer",
            "Response State Transfer"
        },
        CorrectAnswer = 0,
        Explanation = "REST stands for Representational State Transfer, an architectural style for designing networked applications."
    },
    new QuizQuestion
    {
        Id = 26,
        Topic = "ExtraTopics",
        Question = "What HTTP method is used to retrieve data in a REST API?",
        Options = new List<string> {
            "POST",
            "GET",
            "PUT",
            "DELETE"
        },
        CorrectAnswer = 1,
        Explanation = "GET is used to retrieve data from a REST API."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "ExtraTopics",
        Question = "What HTTP method is used to create new data in a REST API?",
        Options = new List<string> {
            "GET",
            "POST",
            "PUT",
            "DELETE"
        },
        CorrectAnswer = 1,
        Explanation = "POST is used to create new data in a REST API."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "ExtraTopics",
        Question = "What is the purpose of the [ApiController] attribute?",
        Options = new List<string> {
            "To enable automatic model validation",
            "To disable model validation",
            "To enable CORS",
            "To disable authentication"
        },
        CorrectAnswer = 0,
        Explanation = "The [ApiController] attribute enables automatic model validation and other API-specific behaviors."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "ExtraTopics",
        Question = "What does the [Route] attribute do?",
        Options = new List<string> {
            "Defines the URL route for a controller or action",
            "Defines the HTTP method",
            "Defines the response format",
            "Defines the authentication method"
        },
        CorrectAnswer = 0,
        Explanation = "The [Route] attribute defines the URL route for a controller or action method."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "ExtraTopics",
        Question = "What status code does CreatedAtAction return?",
        Options = new List<string> {
            "200 OK",
            "201 Created",
            "204 No Content",
            "404 Not Found"
        },
        CorrectAnswer = 1,
        Explanation = "CreatedAtAction returns a 201 Created status code with a location header pointing to the newly created resource."
    },

    // ===== LESSON 6: NuGet Packages (6 Questions) =====
    new QuizQuestion
    {
        Id = 31,
        Topic = "ExtraTopics",
        Question = "What is NuGet?",
        Options = new List<string> {
            "A programming language",
            "A package manager for .NET",
            "A web framework",
            "A database"
        },
        CorrectAnswer = 1,
        Explanation = "NuGet is the official package manager for .NET, used to install and manage libraries."
    },
    new QuizQuestion
    {
        Id = 32,
        Topic = "ExtraTopics",
        Question = "What command installs a NuGet package using the .NET CLI?",
        Options = new List<string> {
            "dotnet install package",
            "dotnet add package",
            "dotnet get package",
            "dotnet new package"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet add package' command installs a NuGet package."
    },
    new QuizQuestion
    {
        Id = 33,
        Topic = "ExtraTopics",
        Question = "What command installs a NuGet package using Package Manager Console?",
        Options = new List<string> {
            "Install-Package",
            "Add-Package",
            "Get-Package",
            "New-Package"
        },
        CorrectAnswer = 0,
        Explanation = "Install-Package is the Package Manager Console command for installing NuGet packages."
    },
    new QuizQuestion
    {
        Id = 34,
        Topic = "ExtraTopics",
        Question = "Where are installed NuGet packages listed?",
        Options = new List<string> {
            "In the .csproj file",
            "In the appsettings.json file",
            "In the Program.cs file",
            "In the Git ignore file"
        },
        CorrectAnswer = 0,
        Explanation = "Installed NuGet packages are listed as PackageReference items in the .csproj file."
    },
    new QuizQuestion
    {
        Id = 35,
        Topic = "ExtraTopics",
        Question = "What is Newtonsoft.Json used for?",
        Options = new List<string> {
            "JSON serialization and deserialization",
            "Database access",
            "Logging",
            "Testing"
        },
        CorrectAnswer = 0,
        Explanation = "Newtonsoft.Json is a popular library for JSON serialization and deserialization."
    },
    new QuizQuestion
    {
        Id = 36,
        Topic = "ExtraTopics",
        Question = "What should you consider before installing a NuGet package?",
        Options = new List<string> {
            "The publisher's reputation",
            "The download count",
            "The license",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Always verify the publisher, download count, and license before installing a NuGet package."
    }
};









        // ================================================================
        // .NET MAUI - LESSON 1: What Is MAUI
        // ================================================================
        _quizzes["DotNetMaui_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson1",
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
        Topic = "DotNetMaui_Lesson1",
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
        Topic = "DotNetMaui_Lesson1",
        Question = "What percentage of code can be shared across platforms with .NET MAUI?",
        Options = new List<string> {
            "Up to 50%",
            "Up to 70%",
            "Up to 90%",
            "100%"
        },
        CorrectAnswer = 2,
        Explanation = ".NET MAUI enables you to share up to 90% of your code across all supported platforms."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson1",
        Question = "What is the minimum Android API level supported by .NET MAUI?",
        Options = new List<string> {
            "API 19 (Android 4.4)",
            "API 21 (Android 5.0)",
            "API 23 (Android 6.0)",
            "API 26 (Android 8.0)"
        },
        CorrectAnswer = 1,
        Explanation = ".NET MAUI supports Android API level 21+ (Android 5.0)."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson1",
        Question = "What is the minimum iOS version supported by .NET MAUI?",
        Options = new List<string> {
            "iOS 10",
            "iOS 11",
            "iOS 13",
            "iOS 15"
        },
        CorrectAnswer = 2,
        Explanation = ".NET MAUI supports iOS 13+ and iPadOS 13+."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson1",
        Question = "What is XAML in .NET MAUI?",
        Options = new List<string> {
            "A programming language",
            "A markup language for defining UI",
            "A database",
            "A web framework"
        },
        CorrectAnswer = 1,
        Explanation = "XAML (eXtensible Application Markup Language) is used to define user interfaces in .NET MAUI applications."
    }
};

        // ================================================================
        // .NET MAUI - LESSON 2: Environment Setup
        // ================================================================
        _quizzes["DotNetMaui_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson2",
        Question = "Which version of Visual Studio is required for .NET MAUI development?",
        Options = new List<string> {
            "Visual Studio 2019",
            "Visual Studio 2022 (17.3+)",
            "Visual Studio Code only",
            "Visual Studio for Mac only"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio 2022 version 17.3 or later is required for .NET MAUI development."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson2",
        Question = "Which command installs the .NET MAUI workload?",
        Options = new List<string> {
            "dotnet install maui",
            "dotnet workload install maui",
            "dotnet add maui",
            "dotnet new maui"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet workload install maui' command installs the .NET MAUI workload."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson2",
        Question = "What is the environment variable for the Android SDK path?",
        Options = new List<string> {
            "ANDROID_SDK_ROOT",
            "ANDROID_HOME",
            "ANDROID_PATH",
            "SDK_ROOT"
        },
        CorrectAnswer = 0,
        Explanation = "ANDROID_SDK_ROOT is the environment variable that points to the Android SDK installation path."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson2",
        Question = "Which tool is required for iOS development on macOS?",
        Options = new List<string> {
            "Android Studio",
            "Xcode",
            "Eclipse",
            "IntelliJ IDEA"
        },
        CorrectAnswer = 1,
        Explanation = "Xcode is required for iOS development on macOS."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson2",
        Question = "How do you verify that .NET MAUI is installed correctly?",
        Options = new List<string> {
            "dotnet --version",
            "dotnet workload list",
            "dotnet --info",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "All these commands help verify .NET MAUI installation: dotnet --version, dotnet workload list, and dotnet --info."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson2",
        Question = "Which Visual Studio workload is required for .NET MAUI?",
        Options = new List<string> {
            ".NET MAUI App Development",
            "Mobile development with .NET",
            "Universal Windows Platform development",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "All three workloads are needed for full .NET MAUI development across all platforms."
    }
};

        // ================================================================
        // .NET MAUI - LESSON 3: XAML Basics
        // ================================================================
        _quizzes["DotNetMaui_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson3",
        Question = "What does XAML stand for?",
        Options = new List<string> {
            "eXtensible Application Markup Language",
            "eXtensible Application Modeling Language",
            "XML Application Markup Language",
            "eXtensible Markup Application Language"
        },
        CorrectAnswer = 0,
        Explanation = "XAML stands for eXtensible Application Markup Language."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson3",
        Question = "What is the root element of a .NET MAUI page?",
        Options = new List<string> {
            "<Page>",
            "<ContentPage>",
            "<View>",
            "<Layout>"
        },
        CorrectAnswer = 1,
        Explanation = "ContentPage is the root element for a .NET MAUI page."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson3",
        Question = "What is the purpose of the x:Class attribute in XAML?",
        Options = new List<string> {
            "Defines the namespace",
            "Specifies the code-behind class",
            "Defines a style",
            "Creates a resource"
        },
        CorrectAnswer = 1,
        Explanation = "The x:Class attribute specifies the code-behind class that the XAML file is associated with."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson3",
        Question = "What is data binding in XAML?",
        Options = new List<string> {
            "Connecting UI elements to data sources",
            "Styling UI elements",
            "Animating UI elements",
            "Positioning UI elements"
        },
        CorrectAnswer = 0,
        Explanation = "Data binding connects UI elements to data sources, allowing automatic updates."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson3",
        Question = "Which syntax is used for binding in XAML?",
        Options = new List<string> {
            "{Binding}",
            "[Binding]",
            "{{Binding}}",
            "@Binding"
        },
        CorrectAnswer = 0,
        Explanation = "The {Binding} syntax is used for data binding in XAML."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson3",
        Question = "What is the purpose of the x:Name attribute in XAML?",
        Options = new List<string> {
            "Sets the page title",
            "Defines a name for accessing the element in code-behind",
            "Creates a style",
            "Defines a resource"
        },
        CorrectAnswer = 1,
        Explanation = "The x:Name attribute gives a name to the element so it can be accessed in the code-behind file."
    }
};

        // ================================================================
        // .NET MAUI - LESSON 4: Layouts and Controls
        // ================================================================
        _quizzes["DotNetMaui_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson4",
        Question = "Which layout arranges children vertically or horizontally?",
        Options = new List<string> {
            "Grid",
            "StackLayout",
            "FlexLayout",
            "AbsoluteLayout"
        },
        CorrectAnswer = 1,
        Explanation = "StackLayout arranges children vertically or horizontally in a single line."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson4",
        Question = "Which layout is best for creating complex, table-like structures?",
        Options = new List<string> {
            "StackLayout",
            "Grid",
            "FlexLayout",
            "RelativeLayout"
        },
        CorrectAnswer = 1,
        Explanation = "Grid is best for creating complex, table-like structures with rows and columns."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson4",
        Question = "Which control is used for single-line text input?",
        Options = new List<string> {
            "Editor",
            "Entry",
            "Label",
            "SearchBar"
        },
        CorrectAnswer = 1,
        Explanation = "Entry is used for single-line text input."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson4",
        Question = "Which control displays a list of items with scrolling?",
        Options = new List<string> {
            "StackLayout",
            "ListView",
            "Grid",
            "CollectionView"
        },
        CorrectAnswer = 3,
        Explanation = "CollectionView displays a list of items with scrolling and is the modern replacement for ListView."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson4",
        Question = "Which property controls how elements are spaced in a StackLayout?",
        Options = new List<string> {
            "Margin",
            "Padding",
            "Spacing",
            "Gap"
        },
        CorrectAnswer = 2,
        Explanation = "The Spacing property controls the space between child elements in a StackLayout."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson4",
        Question = "What is the purpose of a ListView.ItemTemplate?",
        Options = new List<string> {
            "Defines the layout of each item",
            "Sets the data source",
            "Adds items to the list",
            "Removes items from the list"
        },
        CorrectAnswer = 0,
        Explanation = "ItemTemplate defines how each item in the list should be displayed."
    }
};

        // ================================================================
        // .NET MAUI - LESSON 5: Shell Navigation
        // ================================================================
        _quizzes["DotNetMaui_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson5",
        Question = "What is Shell in .NET MAUI?",
        Options = new List<string> {
            "A navigation container",
            "A UI control",
            "A database",
            "A styling system"
        },
        CorrectAnswer = 0,
        Explanation = "Shell is a navigation container that provides a consistent way to implement navigation in .NET MAUI applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson5",
        Question = "Which navigation pattern does Shell support?",
        Options = new List<string> {
            "Flyout menu only",
            "Tab bar only",
            "Both flyout and tab navigation",
            "Modal navigation only"
        },
        CorrectAnswer = 2,
        Explanation = "Shell supports both flyout menu and tab bar navigation patterns."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson5",
        Question = "How do you navigate to a page in Shell?",
        Options = new List<string> {
            "await Navigation.PushAsync()",
            "await Shell.Current.GoToAsync()",
            "await Navigate.ToAsync()",
            "Page.Navigate()"
        },
        CorrectAnswer = 1,
        Explanation = "Shell.Current.GoToAsync() is used for navigation with Shell."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson5",
        Question = "What is the purpose of QueryProperty in Shell navigation?",
        Options = new List<string> {
            "To pass data between pages",
            "To define page routes",
            "To create navigation stacks",
            "To style pages"
        },
        CorrectAnswer = 0,
        Explanation = "QueryProperty is used to pass data between pages using query parameters."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson5",
        Question = "Which Shell element is used for menu items?",
        Options = new List<string> {
            "FlyoutItem",
            "TabBar",
            "ShellContent",
            "MenuItem"
        },
        CorrectAnswer = 0,
        Explanation = "FlyoutItem is used to define items in the flyout menu."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson5",
        Question = "How do you create a tab bar in Shell?",
        Options = new List<string> {
            "Using FlyoutItem",
            "Using TabBar",
            "Using MenuItem",
            "Using Tab"
        },
        CorrectAnswer = 1,
        Explanation = "TabBar is used to create a tab bar navigation in Shell."
    }
};


        // ================================================================
        // .NET MAUI - LESSON 6: MVVM Pattern
        // ================================================================
        _quizzes["DotNetMaui_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson6",
        Question = "What does MVVM stand for?",
        Options = new List<string> {
            "Model-View-ViewModel",
            "Model-View-Controller",
            "Model-View-Presenter",
            "Model-View-View"
        },
        CorrectAnswer = 0,
        Explanation = "MVVM stands for Model-View-ViewModel."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson6",
        Question = "What is the role of the ViewModel in MVVM?",
        Options = new List<string> {
            "Handles UI rendering",
            "Contains business logic and data",
            "Bridges the Model and View",
            "Stores user preferences"
        },
        CorrectAnswer = 2,
        Explanation = "The ViewModel bridges the Model (data) and View (UI) by exposing data and commands."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson6",
        Question = "What is the purpose of ObservableObject in MVVM?",
        Options = new List<string> {
            "To create observable collections",
            "To implement INotifyPropertyChanged",
            "To handle navigation",
            "To manage resources"
        },
        CorrectAnswer = 1,
        Explanation = "ObservableObject implements INotifyPropertyChanged, which notifies the UI when properties change."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson6",
        Question = "What is a RelayCommand used for?",
        Options = new List<string> {
            "Data binding",
            "Handling user actions",
            "Styling controls",
            "Navigation"
        },
        CorrectAnswer = 1,
        Explanation = "RelayCommand is used to handle user actions (like button clicks) in the ViewModel."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson6",
        Question = "Which attribute is used with ObservableProperty in Community Toolkit?",
        Options = new List<string> {
            "[ObservableProperty]",
            "[NotifyPropertyChanged]",
            "[Bindable]",
            "[DataMember]"
        },
        CorrectAnswer = 0,
        Explanation = "The [ObservableProperty] attribute is used with the Community Toolkit MVVM to generate property code."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson6",
        Question = "What is the benefit of using MVVM?",
        Options = new List<string> {
            "Better separation of concerns",
            "Improved testability",
            "Easier maintenance",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "MVVM provides better separation of concerns, improved testability, and easier maintenance."
    }
};

        // ================================================================
        // .NET MAUI - LESSON 7: Connecting to API or DB
        // ================================================================
        _quizzes["DotNetMaui_Lesson7"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson7",
        Question = "Which class is used to make HTTP requests in .NET MAUI?",
        Options = new List<string> {
            "WebClient",
            "HttpClient",
            "HttpWebRequest",
            "RestClient"
        },
        CorrectAnswer = 1,
        Explanation = "HttpClient is used to make HTTP requests in .NET MAUI applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson7",
        Question = "Which database is commonly used for local storage in .NET MAUI?",
        Options = new List<string> {
            "SQL Server",
            "MySQL",
            "SQLite",
            "PostgreSQL"
        },
        CorrectAnswer = 2,
        Explanation = "SQLite is commonly used for local database storage in .NET MAUI applications."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson7",
        Question = "What is the purpose of JsonSerializer in .NET MAUI?",
        Options = new List<string> {
            "To format JSON data",
            "To convert JSON to objects and vice versa",
            "To validate JSON",
            "To compress JSON"
        },
        CorrectAnswer = 1,
        Explanation = "JsonSerializer is used to convert JSON data to objects and objects to JSON."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson7",
        Question = "Which NuGet package is used for SQLite in .NET MAUI?",
        Options = new List<string> {
            "System.Data.Sqlite",
            "sqlite-net-pcl",
            "Microsoft.EntityFrameworkCore.Sqlite",
            "Both B and C"
        },
        CorrectAnswer = 3,
        Explanation = "Both sqlite-net-pcl and Microsoft.EntityFrameworkCore.Sqlite can be used for SQLite in .NET MAUI."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson7",
        Question = "How do you handle network errors in a MAUI app?",
        Options = new List<string> {
            "Ignoring them",
            "Using try-catch blocks",
            "Using Task.Result",
            "Using async void"
        },
        CorrectAnswer = 1,
        Explanation = "Use try-catch blocks to handle network errors gracefully in MAUI applications."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson7",
        Question = "What is the best practice for storing sensitive data in MAUI?",
        Options = new List<string> {
            "In appsettings.json",
            "In a text file",
            "In secure storage",
            "In a database"
        },
        CorrectAnswer = 2,
        Explanation = "Secure storage (like SecureStorage) is the best practice for storing sensitive data in MAUI."
    }
};


        // ================================================================
        // .NET MAUI - LESSON 8: Publishing MAUI App
        // ================================================================
        _quizzes["DotNetMaui_Lesson8"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "DotNetMaui_Lesson8",
        Question = "What file format is used for Android distribution on Google Play?",
        Options = new List<string> {
            "APK only",
            "AAB only",
            "Both APK and AAB",
            "IPA"
        },
        CorrectAnswer = 1,
        Explanation = "Google Play requires AAB (Android App Bundle) format for distribution."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "DotNetMaui_Lesson8",
        Question = "What is required to publish to the Apple App Store?",
        Options = new List<string> {
            "Google Play account",
            "Apple Developer account",
            "Microsoft Partner account",
            "No account required"
        },
        CorrectAnswer = 1,
        Explanation = "An Apple Developer account is required to publish to the Apple App Store."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "DotNetMaui_Lesson8",
        Question = "What is the purpose of a keystore in Android publishing?",
        Options = new List<string> {
            "To store user data",
            "To sign the app",
            "To store app settings",
            "To cache images"
        },
        CorrectAnswer = 1,
        Explanation = "A keystore is used to sign the Android app with a digital certificate."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui_Lesson8",
        Question = "Which command builds an Android app in Release mode?",
        Options = new List<string> {
            "dotnet build -c Debug",
            "dotnet build -c Release",
            "dotnet publish -c Debug",
            "dotnet publish -c Release"
        },
        CorrectAnswer = 3,
        Explanation = "The 'dotnet publish -c Release' command builds and publishes an app in Release mode."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui_Lesson8",
        Question = "What is App Store Optimization (ASO)?",
        Options = new List<string> {
            "Optimizing app performance",
            "Optimizing app store listing for visibility",
            "Optimizing code quality",
            "Optimizing database queries"
        },
        CorrectAnswer = 1,
        Explanation = "ASO involves optimizing your app store listing (title, description, keywords) to improve visibility."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "DotNetMaui_Lesson8",
        Question = "What is the minimum requirement for publishing to the Microsoft Store?",
        Options = new List<string> {
            "Microsoft Partner Center account",
            "Google Play account",
            "Apple Developer account",
            "No account required"
        },
        CorrectAnswer = 0,
        Explanation = "A Microsoft Partner Center account is required to publish to the Microsoft Store."
    }
};
        // ================================================================
        // .NET MAUI - FULL SECTION (All 48 Questions)
        // ================================================================
        _quizzes["DotNetMaui"] = new List<QuizQuestion>
{
    // ===== LESSON 1: What Is MAUI (6 Questions) =====
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
        Question = "What percentage of code can be shared across platforms with .NET MAUI?",
        Options = new List<string> {
            "Up to 50%",
            "Up to 70%",
            "Up to 90%",
            "100%"
        },
        CorrectAnswer = 2,
        Explanation = ".NET MAUI enables you to share up to 90% of your code across all supported platforms."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "DotNetMaui",
        Question = "What is the minimum Android API level supported by .NET MAUI?",
        Options = new List<string> {
            "API 19 (Android 4.4)",
            "API 21 (Android 5.0)",
            "API 23 (Android 6.0)",
            "API 26 (Android 8.0)"
        },
        CorrectAnswer = 1,
        Explanation = ".NET MAUI supports Android API level 21+ (Android 5.0)."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "DotNetMaui",
        Question = "What is the minimum iOS version supported by .NET MAUI?",
        Options = new List<string> {
            "iOS 10",
            "iOS 11",
            "iOS 13",
            "iOS 15"
        },
        CorrectAnswer = 2,
        Explanation = ".NET MAUI supports iOS 13+ and iPadOS 13+."
    },
    new QuizQuestion
    {
        Id = 6,
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

    // ===== LESSON 2: Environment Setup (6 Questions) =====
    new QuizQuestion
    {
        Id = 7,
        Topic = "DotNetMaui",
        Question = "Which version of Visual Studio is required for .NET MAUI development?",
        Options = new List<string> {
            "Visual Studio 2019",
            "Visual Studio 2022 (17.3+)",
            "Visual Studio Code only",
            "Visual Studio for Mac only"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio 2022 version 17.3 or later is required for .NET MAUI development."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "DotNetMaui",
        Question = "Which command installs the .NET MAUI workload?",
        Options = new List<string> {
            "dotnet install maui",
            "dotnet workload install maui",
            "dotnet add maui",
            "dotnet new maui"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet workload install maui' command installs the .NET MAUI workload."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "DotNetMaui",
        Question = "What is the environment variable for the Android SDK path?",
        Options = new List<string> {
            "ANDROID_SDK_ROOT",
            "ANDROID_HOME",
            "ANDROID_PATH",
            "SDK_ROOT"
        },
        CorrectAnswer = 0,
        Explanation = "ANDROID_SDK_ROOT is the environment variable that points to the Android SDK installation path."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "DotNetMaui",
        Question = "Which tool is required for iOS development on macOS?",
        Options = new List<string> {
            "Android Studio",
            "Xcode",
            "Eclipse",
            "IntelliJ IDEA"
        },
        CorrectAnswer = 1,
        Explanation = "Xcode is required for iOS development on macOS."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "DotNetMaui",
        Question = "How do you verify that .NET MAUI is installed correctly?",
        Options = new List<string> {
            "dotnet --version",
            "dotnet workload list",
            "dotnet --info",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "All these commands help verify .NET MAUI installation: dotnet --version, dotnet workload list, and dotnet --info."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "DotNetMaui",
        Question = "Which Visual Studio workload is required for .NET MAUI?",
        Options = new List<string> {
            ".NET MAUI App Development",
            "Mobile development with .NET",
            "Universal Windows Platform development",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "All three workloads are needed for full .NET MAUI development across all platforms."
    },

    // ===== LESSON 3: XAML Basics (6 Questions) =====
    new QuizQuestion
    {
        Id = 13,
        Topic = "DotNetMaui",
        Question = "What does XAML stand for?",
        Options = new List<string> {
            "eXtensible Application Markup Language",
            "eXtensible Application Modeling Language",
            "XML Application Markup Language",
            "eXtensible Markup Application Language"
        },
        CorrectAnswer = 0,
        Explanation = "XAML stands for eXtensible Application Markup Language."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "DotNetMaui",
        Question = "What is the root element of a .NET MAUI page?",
        Options = new List<string> {
            "<Page>",
            "<ContentPage>",
            "<View>",
            "<Layout>"
        },
        CorrectAnswer = 1,
        Explanation = "ContentPage is the root element for a .NET MAUI page."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "DotNetMaui",
        Question = "What is the purpose of the x:Class attribute in XAML?",
        Options = new List<string> {
            "Defines the namespace",
            "Specifies the code-behind class",
            "Defines a style",
            "Creates a resource"
        },
        CorrectAnswer = 1,
        Explanation = "The x:Class attribute specifies the code-behind class that the XAML file is associated with."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "DotNetMaui",
        Question = "What is data binding in XAML?",
        Options = new List<string> {
            "Connecting UI elements to data sources",
            "Styling UI elements",
            "Animating UI elements",
            "Positioning UI elements"
        },
        CorrectAnswer = 0,
        Explanation = "Data binding connects UI elements to data sources, allowing automatic updates."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "DotNetMaui",
        Question = "Which syntax is used for binding in XAML?",
        Options = new List<string> {
            "{Binding}",
            "[Binding]",
            "{{Binding}}",
            "@Binding"
        },
        CorrectAnswer = 0,
        Explanation = "The {Binding} syntax is used for data binding in XAML."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "DotNetMaui",
        Question = "What is the purpose of the x:Name attribute in XAML?",
        Options = new List<string> {
            "Sets the page title",
            "Defines a name for accessing the element in code-behind",
            "Creates a style",
            "Defines a resource"
        },
        CorrectAnswer = 1,
        Explanation = "The x:Name attribute gives a name to the element so it can be accessed in the code-behind file."
    },

    // ===== LESSON 4: Layouts and Controls (6 Questions) =====
    new QuizQuestion
    {
        Id = 19,
        Topic = "DotNetMaui",
        Question = "Which layout arranges children vertically or horizontally?",
        Options = new List<string> {
            "Grid",
            "StackLayout",
            "FlexLayout",
            "AbsoluteLayout"
        },
        CorrectAnswer = 1,
        Explanation = "StackLayout arranges children vertically or horizontally in a single line."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "DotNetMaui",
        Question = "Which layout is best for creating complex, table-like structures?",
        Options = new List<string> {
            "StackLayout",
            "Grid",
            "FlexLayout",
            "RelativeLayout"
        },
        CorrectAnswer = 1,
        Explanation = "Grid is best for creating complex, table-like structures with rows and columns."
    },
    new QuizQuestion
    {
        Id = 21,
        Topic = "DotNetMaui",
        Question = "Which control is used for single-line text input?",
        Options = new List<string> {
            "Editor",
            "Entry",
            "Label",
            "SearchBar"
        },
        CorrectAnswer = 1,
        Explanation = "Entry is used for single-line text input."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "DotNetMaui",
        Question = "Which control displays a list of items with scrolling?",
        Options = new List<string> {
            "StackLayout",
            "ListView",
            "Grid",
            "CollectionView"
        },
        CorrectAnswer = 3,
        Explanation = "CollectionView displays a list of items with scrolling and is the modern replacement for ListView."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "DotNetMaui",
        Question = "Which property controls how elements are spaced in a StackLayout?",
        Options = new List<string> {
            "Margin",
            "Padding",
            "Spacing",
            "Gap"
        },
        CorrectAnswer = 2,
        Explanation = "The Spacing property controls the space between child elements in a StackLayout."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "DotNetMaui",
        Question = "What is the purpose of a ListView.ItemTemplate?",
        Options = new List<string> {
            "Defines the layout of each item",
            "Sets the data source",
            "Adds items to the list",
            "Removes items from the list"
        },
        CorrectAnswer = 0,
        Explanation = "ItemTemplate defines how each item in the list should be displayed."
    },

    // ===== LESSON 5: Shell Navigation (6 Questions) =====
    new QuizQuestion
    {
        Id = 25,
        Topic = "DotNetMaui",
        Question = "What is Shell in .NET MAUI?",
        Options = new List<string> {
            "A navigation container",
            "A UI control",
            "A database",
            "A styling system"
        },
        CorrectAnswer = 0,
        Explanation = "Shell is a navigation container that provides a consistent way to implement navigation in .NET MAUI applications."
    },
    new QuizQuestion
    {
        Id = 26,
        Topic = "DotNetMaui",
        Question = "Which navigation pattern does Shell support?",
        Options = new List<string> {
            "Flyout menu only",
            "Tab bar only",
            "Both flyout and tab navigation",
            "Modal navigation only"
        },
        CorrectAnswer = 2,
        Explanation = "Shell supports both flyout menu and tab bar navigation patterns."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "DotNetMaui",
        Question = "How do you navigate to a page in Shell?",
        Options = new List<string> {
            "await Navigation.PushAsync()",
            "await Shell.Current.GoToAsync()",
            "await Navigate.ToAsync()",
            "Page.Navigate()"
        },
        CorrectAnswer = 1,
        Explanation = "Shell.Current.GoToAsync() is used for navigation with Shell."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "DotNetMaui",
        Question = "What is the purpose of QueryProperty in Shell navigation?",
        Options = new List<string> {
            "To pass data between pages",
            "To define page routes",
            "To create navigation stacks",
            "To style pages"
        },
        CorrectAnswer = 0,
        Explanation = "QueryProperty is used to pass data between pages using query parameters."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "DotNetMaui",
        Question = "Which Shell element is used for menu items?",
        Options = new List<string> {
            "FlyoutItem",
            "TabBar",
            "ShellContent",
            "MenuItem"
        },
        CorrectAnswer = 0,
        Explanation = "FlyoutItem is used to define items in the flyout menu."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "DotNetMaui",
        Question = "How do you create a tab bar in Shell?",
        Options = new List<string> {
            "Using FlyoutItem",
            "Using TabBar",
            "Using MenuItem",
            "Using Tab"
        },
        CorrectAnswer = 1,
        Explanation = "TabBar is used to create a tab bar navigation in Shell."
    },

    // ===== LESSON 6: MVVM Pattern (6 Questions) =====
    new QuizQuestion
    {
        Id = 31,
        Topic = "DotNetMaui",
        Question = "What does MVVM stand for?",
        Options = new List<string> {
            "Model-View-ViewModel",
            "Model-View-Controller",
            "Model-View-Presenter",
            "Model-View-View"
        },
        CorrectAnswer = 0,
        Explanation = "MVVM stands for Model-View-ViewModel."
    },
    new QuizQuestion
    {
        Id = 32,
        Topic = "DotNetMaui",
        Question = "What is the role of the ViewModel in MVVM?",
        Options = new List<string> {
            "Handles UI rendering",
            "Contains business logic and data",
            "Bridges the Model and View",
            "Stores user preferences"
        },
        CorrectAnswer = 2,
        Explanation = "The ViewModel bridges the Model (data) and View (UI) by exposing data and commands."
    },
    new QuizQuestion
    {
        Id = 33,
        Topic = "DotNetMaui",
        Question = "What is the purpose of ObservableObject in MVVM?",
        Options = new List<string> {
            "To create observable collections",
            "To implement INotifyPropertyChanged",
            "To handle navigation",
            "To manage resources"
        },
        CorrectAnswer = 1,
        Explanation = "ObservableObject implements INotifyPropertyChanged, which notifies the UI when properties change."
    },
    new QuizQuestion
    {
        Id = 34,
        Topic = "DotNetMaui",
        Question = "What is a RelayCommand used for?",
        Options = new List<string> {
            "Data binding",
            "Handling user actions",
            "Styling controls",
            "Navigation"
        },
        CorrectAnswer = 1,
        Explanation = "RelayCommand is used to handle user actions (like button clicks) in the ViewModel."
    },
    new QuizQuestion
    {
        Id = 35,
        Topic = "DotNetMaui",
        Question = "Which attribute is used with ObservableProperty in Community Toolkit?",
        Options = new List<string> {
            "[ObservableProperty]",
            "[NotifyPropertyChanged]",
            "[Bindable]",
            "[DataMember]"
        },
        CorrectAnswer = 0,
        Explanation = "The [ObservableProperty] attribute is used with the Community Toolkit MVVM to generate property code."
    },
    new QuizQuestion
    {
        Id = 36,
        Topic = "DotNetMaui",
        Question = "What is the benefit of using MVVM?",
        Options = new List<string> {
            "Better separation of concerns",
            "Improved testability",
            "Easier maintenance",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "MVVM provides better separation of concerns, improved testability, and easier maintenance."
    },

    // ===== LESSON 7: Connecting to API or DB (6 Questions) =====
    new QuizQuestion
    {
        Id = 37,
        Topic = "DotNetMaui",
        Question = "Which class is used to make HTTP requests in .NET MAUI?",
        Options = new List<string> {
            "WebClient",
            "HttpClient",
            "HttpWebRequest",
            "RestClient"
        },
        CorrectAnswer = 1,
        Explanation = "HttpClient is used to make HTTP requests in .NET MAUI applications."
    },
    new QuizQuestion
    {
        Id = 38,
        Topic = "DotNetMaui",
        Question = "Which database is commonly used for local storage in .NET MAUI?",
        Options = new List<string> {
            "SQL Server",
            "MySQL",
            "SQLite",
            "PostgreSQL"
        },
        CorrectAnswer = 2,
        Explanation = "SQLite is commonly used for local database storage in .NET MAUI applications."
    },
    new QuizQuestion
    {
        Id = 39,
        Topic = "DotNetMaui",
        Question = "What is the purpose of JsonSerializer in .NET MAUI?",
        Options = new List<string> {
            "To format JSON data",
            "To convert JSON to objects and vice versa",
            "To validate JSON",
            "To compress JSON"
        },
        CorrectAnswer = 1,
        Explanation = "JsonSerializer is used to convert JSON data to objects and objects to JSON."
    },
    new QuizQuestion
    {
        Id = 40,
        Topic = "DotNetMaui",
        Question = "Which NuGet package is used for SQLite in .NET MAUI?",
        Options = new List<string> {
            "System.Data.Sqlite",
            "sqlite-net-pcl",
            "Microsoft.EntityFrameworkCore.Sqlite",
            "Both B and C"
        },
        CorrectAnswer = 3,
        Explanation = "Both sqlite-net-pcl and Microsoft.EntityFrameworkCore.Sqlite can be used for SQLite in .NET MAUI."
    },
    new QuizQuestion
    {
        Id = 41,
        Topic = "DotNetMaui",
        Question = "How do you handle network errors in a MAUI app?",
        Options = new List<string> {
            "Ignoring them",
            "Using try-catch blocks",
            "Using Task.Result",
            "Using async void"
        },
        CorrectAnswer = 1,
        Explanation = "Use try-catch blocks to handle network errors gracefully in MAUI applications."
    },
    new QuizQuestion
    {
        Id = 42,
        Topic = "DotNetMaui",
        Question = "What is the best practice for storing sensitive data in MAUI?",
        Options = new List<string> {
            "In appsettings.json",
            "In a text file",
            "In secure storage",
            "In a database"
        },
        CorrectAnswer = 2,
        Explanation = "Secure storage (like SecureStorage) is the best practice for storing sensitive data in MAUI."
    },

    // ===== LESSON 8: Publishing MAUI App (6 Questions) =====
    new QuizQuestion
    {
        Id = 43,
        Topic = "DotNetMaui",
        Question = "What file format is used for Android distribution on Google Play?",
        Options = new List<string> {
            "APK only",
            "AAB only",
            "Both APK and AAB",
            "IPA"
        },
        CorrectAnswer = 1,
        Explanation = "Google Play requires AAB (Android App Bundle) format for distribution."
    },
    new QuizQuestion
    {
        Id = 44,
        Topic = "DotNetMaui",
        Question = "What is required to publish to the Apple App Store?",
        Options = new List<string> {
            "Google Play account",
            "Apple Developer account",
            "Microsoft Partner account",
            "No account required"
        },
        CorrectAnswer = 1,
        Explanation = "An Apple Developer account is required to publish to the Apple App Store."
    },
    new QuizQuestion
    {
        Id = 45,
        Topic = "DotNetMaui",
        Question = "What is the purpose of a keystore in Android publishing?",
        Options = new List<string> {
            "To store user data",
            "To sign the app",
            "To store app settings",
            "To cache images"
        },
        CorrectAnswer = 1,
        Explanation = "A keystore is used to sign the Android app with a digital certificate."
    },
    new QuizQuestion
    {
        Id = 46,
        Topic = "DotNetMaui",
        Question = "Which command builds an Android app in Release mode?",
        Options = new List<string> {
            "dotnet build -c Debug",
            "dotnet build -c Release",
            "dotnet publish -c Debug",
            "dotnet publish -c Release"
        },
        CorrectAnswer = 3,
        Explanation = "The 'dotnet publish -c Release' command builds and publishes an app in Release mode."
    },
    new QuizQuestion
    {
        Id = 47,
        Topic = "DotNetMaui",
        Question = "What is App Store Optimization (ASO)?",
        Options = new List<string> {
            "Optimizing app performance",
            "Optimizing app store listing for visibility",
            "Optimizing code quality",
            "Optimizing database queries"
        },
        CorrectAnswer = 1,
        Explanation = "ASO involves optimizing your app store listing (title, description, keywords) to improve visibility."
    },
    new QuizQuestion
    {
        Id = 48,
        Topic = "DotNetMaui",
        Question = "What is the minimum requirement for publishing to the Microsoft Store?",
        Options = new List<string> {
            "Microsoft Partner Center account",
            "Google Play account",
            "Apple Developer account",
            "No account required"
        },
        CorrectAnswer = 0,
        Explanation = "A Microsoft Partner Center account is required to publish to the Microsoft Store."
    }
};









        // ================================================================
        // DEPLOYMENT - LESSON 1: Preparing for Deployment
        // ================================================================
        _quizzes["Deployment_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Deployment_Lesson1",
        Question = "What is the purpose of appsettings.json in ASP.NET Core?",
        Options = new List<string> {
            "To store application configuration",
            "To store user data",
            "To store database records",
            "To store HTML templates"
        },
        CorrectAnswer = 0,
        Explanation = "appsettings.json stores application configuration settings like connection strings, logging levels, and other environment-specific settings."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Deployment_Lesson1",
        Question = "Which file is used for environment-specific configuration overrides?",
        Options = new List<string> {
            "appsettings.json",
            "appsettings.Development.json",
            "appsettings.Production.json",
            "Both B and C"
        },
        CorrectAnswer = 3,
        Explanation = "Both appsettings.Development.json and appsettings.Production.json override the base configuration for their specific environments."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Deployment_Lesson1",
        Question = "What is the purpose of environment variables in deployment?",
        Options = new List<string> {
            "To store sensitive configuration securely",
            "To make the application run faster",
            "To store user preferences",
            "To cache data"
        },
        CorrectAnswer = 0,
        Explanation = "Environment variables store sensitive configuration like connection strings and API keys securely, keeping them out of source control."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Deployment_Lesson1",
        Question = "What does HSTS stand for?",
        Options = new List<string> {
            "HTTP Strict Transport Security",
            "HTTP Secure Transfer System",
            "Hypertext Secure Transport Service",
            "HTTP Standard Transfer Security"
        },
        CorrectAnswer = 0,
        Explanation = "HSTS stands for HTTP Strict Transport Security, which forces browsers to use HTTPS connections."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Deployment_Lesson1",
        Question = "Which middleware should be enabled in production for error handling?",
        Options = new List<string> {
            "UseDeveloperExceptionPage()",
            "UseExceptionHandler()",
            "UseStatusCodePages()",
            "UseRuntimeInfo()"
        },
        CorrectAnswer = 1,
        Explanation = "UseExceptionHandler() provides user-friendly error pages in production, while UseDeveloperExceptionPage() should only be used in development."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "Deployment_Lesson1",
        Question = "What is the purpose of health checks in a deployed application?",
        Options = new List<string> {
            "To monitor application health and availability",
            "To check user health",
            "To monitor database performance only",
            "To check server CPU usage"
        },
        CorrectAnswer = 0,
        Explanation = "Health checks monitor the application's health and availability, checking dependencies like databases and external services."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Deployment_Lesson1",
        Question = "Which command builds an ASP.NET Core application in Release mode?",
        Options = new List<string> {
            "dotnet build",
            "dotnet build -c Release",
            "dotnet publish",
            "dotnet run"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet build -c Release' command builds the application with optimizations enabled for production."
    }
};

        // ================================================================
        // DEPLOYMENT - LESSON 2: Free Hosting Options
        // ================================================================
        _quizzes["Deployment_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Deployment_Lesson2",
        Question = "Which Azure service provides free hosting for web applications?",
        Options = new List<string> {
            "Azure Virtual Machines",
            "Azure App Service",
            "Azure Functions",
            "Azure Kubernetes Service"
        },
        CorrectAnswer = 1,
        Explanation = "Azure App Service provides free tier hosting for web applications."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Deployment_Lesson2",
        Question = "What is the bandwidth limit for Netlify's free tier?",
        Options = new List<string> {
            "100GB per month",
            "50GB per month",
            "500GB per month",
            "Unlimited"
        },
        CorrectAnswer = 0,
        Explanation = "Netlify's free tier includes 100GB of bandwidth per month."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Deployment_Lesson2",
        Question = "Which platform is best suited for static websites and JAMstack applications?",
        Options = new List<string> {
            "Azure App Service",
            "Netlify",
            "Heroku",
            "Render"
        },
        CorrectAnswer = 1,
        Explanation = "Netlify is specifically designed for static websites and JAMstack applications."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Deployment_Lesson2",
        Question = "What is the maximum number of web apps available in Azure Free tier?",
        Options = new List<string> {
            "5",
            "10",
            "15",
            "Unlimited"
        },
        CorrectAnswer = 1,
        Explanation = "Azure Free tier includes 10 web apps with 1GB storage each."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Deployment_Lesson2",
        Question = "Which platform offers free PostgreSQL database hosting?",
        Options = new List<string> {
            "Netlify",
            "Vercel",
            "Render",
            "GitHub Pages"
        },
        CorrectAnswer = 2,
        Explanation = "Render offers free PostgreSQL database hosting with their free tier."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "Deployment_Lesson2",
        Question = "What is the main limitation of Heroku's free tier?",
        Options = new List<string> {
            "No SSL support",
            "App sleeps after 30 minutes of inactivity",
            "No custom domain support",
            "No database support"
        },
        CorrectAnswer = 1,
        Explanation = "Heroku's free tier apps sleep after 30 minutes of inactivity, causing delays when waking up."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Deployment_Lesson2",
        Question = "Which platform is best for deploying Next.js applications?",
        Options = new List<string> {
            "Azure",
            "Netlify",
            "Vercel",
            "GitHub Pages"
        },
        CorrectAnswer = 2,
        Explanation = "Vercel is optimized for Next.js applications with built-in support and serverless functions."
    }
};


        // ================================================================
        // DEPLOYMENT - LESSON 3: Deploying to Azure Free
        // ================================================================
        _quizzes["Deployment_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Deployment_Lesson3",
        Question = "What is required to create an Azure free account?",
        Options = new List<string> {
            "Only an email address",
            "A phone number and credit card for verification",
            "A business license",
            "A Microsoft partner account"
        },
        CorrectAnswer = 1,
        Explanation = "Azure requires a phone number and credit card for identity verification, though no charges are made."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Deployment_Lesson3",
        Question = "Which Azure App Service plan tier is free?",
        Options = new List<string> {
            "F1 (Free)",
            "B1 (Basic)",
            "S1 (Standard)",
            "P1 (Premium)"
        },
        CorrectAnswer = 0,
        Explanation = "The F1 (Free) tier is the free Azure App Service plan."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Deployment_Lesson3",
        Question = "How long does the Azure free account last?",
        Options = new List<string> {
            "6 months",
            "12 months",
            "24 months",
            "Indefinitely"
        },
        CorrectAnswer = 1,
        Explanation = "The Azure free account provides 12 months of popular free services."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Deployment_Lesson3",
        Question = "Which tool can be used to deploy to Azure from Visual Studio?",
        Options = new List<string> {
            "Git",
            "Publish profile",
            "Azure CLI",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Visual Studio supports multiple deployment methods including Git, publish profiles, and Azure CLI."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Deployment_Lesson3",
        Question = "How do you store production connection strings in Azure?",
        Options = new List<string> {
            "In appsettings.json",
            "In Azure Application Settings",
            "In a text file",
            "In the database"
        },
        CorrectAnswer = 1,
        Explanation = "Azure Application Settings store production connection strings securely without exposing them in source code."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "Deployment_Lesson3",
        Question = "What is the purpose of Azure Application Insights?",
        Options = new List<string> {
            "To monitor application performance and errors",
            "To store application data",
            "To deploy applications",
            "To manage user authentication"
        },
        CorrectAnswer = 0,
        Explanation = "Application Insights provides application performance monitoring and error tracking."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Deployment_Lesson3",
        Question = "What does the 'az' command do?",
        Options = new List<string> {
            "Deploys applications",
            "Manages Azure resources",
            "Creates databases",
            "Builds applications"
        },
        CorrectAnswer = 1,
        Explanation = "The 'az' command is the Azure CLI used to manage Azure resources from the command line."
    }
};

        // ================================================================
        // DEPLOYMENT - LESSON 4: Free Custom Domain Options
        // ================================================================
        _quizzes["Deployment_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Deployment_Lesson4",
        Question = "Which extension is available for free from Freenom?",
        Options = new List<string> {
            ".com",
            ".org",
            ".tk",
            ".net"
        },
        CorrectAnswer = 2,
        Explanation = "Freenom offers free domains with .tk, .ml, .ga, .cf, and .gq extensions."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Deployment_Lesson4",
        Question = "What is the purpose of a CNAME record?",
        Options = new List<string> {
            "Maps a domain to another domain",
            "Maps a domain to an IP address",
            "Points to a mail server",
            "Verifies domain ownership"
        },
        CorrectAnswer = 0,
        Explanation = "A CNAME record maps a domain name to another domain name (like www to @)."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Deployment_Lesson4",
        Question = "How long does DNS propagation typically take?",
        Options = new List<string> {
            "A few minutes",
            "1-2 hours",
            "24-48 hours",
            "1 week"
        },
        CorrectAnswer = 2,
        Explanation = "DNS propagation typically takes 24-48 hours to fully propagate globally."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Deployment_Lesson4",
        Question = "Which service provides free SSL certificates?",
        Options = new List<string> {
            "Let's Encrypt",
            "SSL.com",
            "Verisign",
            "Symantec"
        },
        CorrectAnswer = 0,
        Explanation = "Let's Encrypt provides free SSL/TLS certificates automatically."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Deployment_Lesson4",
        Question = "What is required to add a custom domain to Azure App Service?",
        Options = new List<string> {
            "Only the domain name",
            "Domain verification and DNS configuration",
            "A paid subscription",
            "A certificate"
        },
        CorrectAnswer = 1,
        Explanation = "Adding a custom domain requires domain verification and proper DNS configuration."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "Deployment_Lesson4",
        Question = "Which file is used to configure custom domains for GitHub Pages?",
        Options = new List<string> {
            "CNAME",
            "config.yml",
            "settings.json",
            "domains.txt"
        },
        CorrectAnswer = 0,
        Explanation = "A CNAME file in the root of the repository configures custom domains for GitHub Pages."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Deployment_Lesson4",
        Question = "What is Cloudflare primarily used for?",
        Options = new List<string> {
            "DNS management and CDN",
            "Web hosting",
            "Database hosting",
            "Email hosting"
        },
        CorrectAnswer = 0,
        Explanation = "Cloudflare provides DNS management, CDN services, and security features for websites."
    }
};

        // ================================================================
        // DEPLOYMENT - LESSON 5: CI/CD with GitHub Actions
        // ================================================================
        _quizzes["Deployment_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "Deployment_Lesson5",
        Question = "What does CI/CD stand for?",
        Options = new List<string> {
            "Continuous Integration / Continuous Deployment",
            "Code Integration / Code Deployment",
            "Continuous Improvement / Continuous Delivery",
            "Code Infrastructure / Code Development"
        },
        CorrectAnswer = 0,
        Explanation = "CI/CD stands for Continuous Integration and Continuous Deployment."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Deployment_Lesson5",
        Question = "Where are GitHub Actions workflows defined?",
        Options = new List<string> {
            "In the .github/workflows directory",
            "In the root directory",
            "In the src directory",
            "In the config directory"
        },
        CorrectAnswer = 0,
        Explanation = "GitHub Actions workflows are defined as YAML files in the .github/workflows directory."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Deployment_Lesson5",
        Question = "What is the purpose of 'secrets' in GitHub Actions?",
        Options = new List<string> {
            "To store sensitive information securely",
            "To store code",
            "To store configuration",
            "To store dependencies"
        },
        CorrectAnswer = 0,
        Explanation = "Secrets store sensitive information like passwords and API keys securely in GitHub Actions."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Deployment_Lesson5",
        Question = "Which event triggers a GitHub Actions workflow on code push?",
        Options = new List<string> {
            "workflow_dispatch",
            "push",
            "pull_request",
            "schedule"
        },
        CorrectAnswer = 1,
        Explanation = "The 'push' event triggers a workflow when code is pushed to a branch."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Deployment_Lesson5",
        Question = "What is the purpose of the 'needs' keyword in GitHub Actions?",
        Options = new List<string> {
            "To define job dependencies",
            "To install dependencies",
            "To run parallel jobs",
            "To skip jobs"
        },
        CorrectAnswer = 0,
        Explanation = "The 'needs' keyword defines dependencies between jobs, ensuring one job completes before another starts."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "Deployment_Lesson5",
        Question = "Which command runs tests in a .NET GitHub Actions workflow?",
        Options = new List<string> {
            "dotnet test",
            "dotnet run",
            "dotnet build",
            "dotnet publish"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet test' command runs unit tests in a .NET project."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Deployment_Lesson5",
        Question = "What does the 'actions/checkout@v3' action do?",
        Options = new List<string> {
            "Checks out the repository code",
            "Checks for errors",
            "Checks dependencies",
            "Checks the build status"
        },
        CorrectAnswer = 0,
        Explanation = "The 'actions/checkout@v3' action checks out the repository code so the workflow can access it."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "Deployment_Lesson5",
        Question = "What is the purpose of the 'azure/webapps-deploy@v2' action?",
        Options = new List<string> {
            "Deploys to Azure App Service",
            "Creates an Azure account",
            "Manages Azure databases",
            "Configures Azure security"
        },
        CorrectAnswer = 0,
        Explanation = "The 'azure/webapps-deploy@v2' action deploys applications to Azure App Service."
    }
};


        // ================================================================
        // DEPLOYMENT - FULL SECTION (All 39 Questions)
        // ================================================================
        _quizzes["Deployment"] = new List<QuizQuestion>
{
    // ===== LESSON 1: Preparing for Deployment (7 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "Deployment",
        Question = "What is the purpose of appsettings.json in ASP.NET Core?",
        Options = new List<string> {
            "To store application configuration",
            "To store user data",
            "To store database records",
            "To store HTML templates"
        },
        CorrectAnswer = 0,
        Explanation = "appsettings.json stores application configuration settings like connection strings, logging levels, and other environment-specific settings."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "Deployment",
        Question = "Which file is used for environment-specific configuration overrides?",
        Options = new List<string> {
            "appsettings.json",
            "appsettings.Development.json",
            "appsettings.Production.json",
            "Both B and C"
        },
        CorrectAnswer = 3,
        Explanation = "Both appsettings.Development.json and appsettings.Production.json override the base configuration for their specific environments."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "Deployment",
        Question = "What is the purpose of environment variables in deployment?",
        Options = new List<string> {
            "To store sensitive configuration securely",
            "To make the application run faster",
            "To store user preferences",
            "To cache data"
        },
        CorrectAnswer = 0,
        Explanation = "Environment variables store sensitive configuration like connection strings and API keys securely, keeping them out of source control."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "Deployment",
        Question = "What does HSTS stand for?",
        Options = new List<string> {
            "HTTP Strict Transport Security",
            "HTTP Secure Transfer System",
            "Hypertext Secure Transport Service",
            "HTTP Standard Transfer Security"
        },
        CorrectAnswer = 0,
        Explanation = "HSTS stands for HTTP Strict Transport Security, which forces browsers to use HTTPS connections."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "Deployment",
        Question = "Which middleware should be enabled in production for error handling?",
        Options = new List<string> {
            "UseDeveloperExceptionPage()",
            "UseExceptionHandler()",
            "UseStatusCodePages()",
            "UseRuntimeInfo()"
        },
        CorrectAnswer = 1,
        Explanation = "UseExceptionHandler() provides user-friendly error pages in production, while UseDeveloperExceptionPage() should only be used in development."
    },
    new QuizQuestion
    {
        Id = 6,
        Topic = "Deployment",
        Question = "What is the purpose of health checks in a deployed application?",
        Options = new List<string> {
            "To monitor application health and availability",
            "To check user health",
            "To monitor database performance only",
            "To check server CPU usage"
        },
        CorrectAnswer = 0,
        Explanation = "Health checks monitor the application's health and availability, checking dependencies like databases and external services."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "Deployment",
        Question = "Which command builds an ASP.NET Core application in Release mode?",
        Options = new List<string> {
            "dotnet build",
            "dotnet build -c Release",
            "dotnet publish",
            "dotnet run"
        },
        CorrectAnswer = 1,
        Explanation = "The 'dotnet build -c Release' command builds the application with optimizations enabled for production."
    },

    // ===== LESSON 2: Free Hosting Options (7 Questions) =====
    new QuizQuestion
    {
        Id = 8,
        Topic = "Deployment",
        Question = "Which Azure service provides free hosting for web applications?",
        Options = new List<string> {
            "Azure Virtual Machines",
            "Azure App Service",
            "Azure Functions",
            "Azure Kubernetes Service"
        },
        CorrectAnswer = 1,
        Explanation = "Azure App Service provides free tier hosting for web applications."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "Deployment",
        Question = "What is the bandwidth limit for Netlify's free tier?",
        Options = new List<string> {
            "100GB per month",
            "50GB per month",
            "500GB per month",
            "Unlimited"
        },
        CorrectAnswer = 0,
        Explanation = "Netlify's free tier includes 100GB of bandwidth per month."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "Deployment",
        Question = "Which platform is best suited for static websites and JAMstack applications?",
        Options = new List<string> {
            "Azure App Service",
            "Netlify",
            "Heroku",
            "Render"
        },
        CorrectAnswer = 1,
        Explanation = "Netlify is specifically designed for static websites and JAMstack applications."
    },
    new QuizQuestion
    {
        Id = 11,
        Topic = "Deployment",
        Question = "What is the maximum number of web apps available in Azure Free tier?",
        Options = new List<string> {
            "5",
            "10",
            "15",
            "Unlimited"
        },
        CorrectAnswer = 1,
        Explanation = "Azure Free tier includes 10 web apps with 1GB storage each."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "Deployment",
        Question = "Which platform offers free PostgreSQL database hosting?",
        Options = new List<string> {
            "Netlify",
            "Vercel",
            "Render",
            "GitHub Pages"
        },
        CorrectAnswer = 2,
        Explanation = "Render offers free PostgreSQL database hosting with their free tier."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "Deployment",
        Question = "What is the main limitation of Heroku's free tier?",
        Options = new List<string> {
            "No SSL support",
            "App sleeps after 30 minutes of inactivity",
            "No custom domain support",
            "No database support"
        },
        CorrectAnswer = 1,
        Explanation = "Heroku's free tier apps sleep after 30 minutes of inactivity, causing delays when waking up."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "Deployment",
        Question = "Which platform is best for deploying Next.js applications?",
        Options = new List<string> {
            "Azure",
            "Netlify",
            "Vercel",
            "GitHub Pages"
        },
        CorrectAnswer = 2,
        Explanation = "Vercel is optimized for Next.js applications with built-in support and serverless functions."
    },

    // ===== LESSON 3: Deploying to Azure Free (7 Questions) =====
    new QuizQuestion
    {
        Id = 15,
        Topic = "Deployment",
        Question = "What is required to create an Azure free account?",
        Options = new List<string> {
            "Only an email address",
            "A phone number and credit card for verification",
            "A business license",
            "A Microsoft partner account"
        },
        CorrectAnswer = 1,
        Explanation = "Azure requires a phone number and credit card for identity verification, though no charges are made."
    },
    new QuizQuestion
    {
        Id = 16,
        Topic = "Deployment",
        Question = "Which Azure App Service plan tier is free?",
        Options = new List<string> {
            "F1 (Free)",
            "B1 (Basic)",
            "S1 (Standard)",
            "P1 (Premium)"
        },
        CorrectAnswer = 0,
        Explanation = "The F1 (Free) tier is the free Azure App Service plan."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "Deployment",
        Question = "How long does the Azure free account last?",
        Options = new List<string> {
            "6 months",
            "12 months",
            "24 months",
            "Indefinitely"
        },
        CorrectAnswer = 1,
        Explanation = "The Azure free account provides 12 months of popular free services."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "Deployment",
        Question = "Which tool can be used to deploy to Azure from Visual Studio?",
        Options = new List<string> {
            "Git",
            "Publish profile",
            "Azure CLI",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Visual Studio supports multiple deployment methods including Git, publish profiles, and Azure CLI."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "Deployment",
        Question = "How do you store production connection strings in Azure?",
        Options = new List<string> {
            "In appsettings.json",
            "In Azure Application Settings",
            "In a text file",
            "In the database"
        },
        CorrectAnswer = 1,
        Explanation = "Azure Application Settings store production connection strings securely without exposing them in source code."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "Deployment",
        Question = "What is the purpose of Azure Application Insights?",
        Options = new List<string> {
            "To monitor application performance and errors",
            "To store application data",
            "To deploy applications",
            "To manage user authentication"
        },
        CorrectAnswer = 0,
        Explanation = "Application Insights provides application performance monitoring and error tracking."
    },
    new QuizQuestion
    {
        Id = 21,
        Topic = "Deployment",
        Question = "What does the 'az' command do?",
        Options = new List<string> {
            "Deploys applications",
            "Manages Azure resources",
            "Creates databases",
            "Builds applications"
        },
        CorrectAnswer = 1,
        Explanation = "The 'az' command is the Azure CLI used to manage Azure resources from the command line."
    },

    // ===== LESSON 4: Free Custom Domain Options (7 Questions) =====
    new QuizQuestion
    {
        Id = 22,
        Topic = "Deployment",
        Question = "Which extension is available for free from Freenom?",
        Options = new List<string> {
            ".com",
            ".org",
            ".tk",
            ".net"
        },
        CorrectAnswer = 2,
        Explanation = "Freenom offers free domains with .tk, .ml, .ga, .cf, and .gq extensions."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "Deployment",
        Question = "What is the purpose of a CNAME record?",
        Options = new List<string> {
            "Maps a domain to another domain",
            "Maps a domain to an IP address",
            "Points to a mail server",
            "Verifies domain ownership"
        },
        CorrectAnswer = 0,
        Explanation = "A CNAME record maps a domain name to another domain name (like www to @)."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "Deployment",
        Question = "How long does DNS propagation typically take?",
        Options = new List<string> {
            "A few minutes",
            "1-2 hours",
            "24-48 hours",
            "1 week"
        },
        CorrectAnswer = 2,
        Explanation = "DNS propagation typically takes 24-48 hours to fully propagate globally."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "Deployment",
        Question = "Which service provides free SSL certificates?",
        Options = new List<string> {
            "Let's Encrypt",
            "SSL.com",
            "Verisign",
            "Symantec"
        },
        CorrectAnswer = 0,
        Explanation = "Let's Encrypt provides free SSL/TLS certificates automatically."
    },
    new QuizQuestion
    {
        Id = 26,
        Topic = "Deployment",
        Question = "What is required to add a custom domain to Azure App Service?",
        Options = new List<string> {
            "Only the domain name",
            "Domain verification and DNS configuration",
            "A paid subscription",
            "A certificate"
        },
        CorrectAnswer = 1,
        Explanation = "Adding a custom domain requires domain verification and proper DNS configuration."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "Deployment",
        Question = "Which file is used to configure custom domains for GitHub Pages?",
        Options = new List<string> {
            "CNAME",
            "config.yml",
            "settings.json",
            "domains.txt"
        },
        CorrectAnswer = 0,
        Explanation = "A CNAME file in the root of the repository configures custom domains for GitHub Pages."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "Deployment",
        Question = "What is Cloudflare primarily used for?",
        Options = new List<string> {
            "DNS management and CDN",
            "Web hosting",
            "Database hosting",
            "Email hosting"
        },
        CorrectAnswer = 0,
        Explanation = "Cloudflare provides DNS management, CDN services, and security features for websites."
    },

    // ===== LESSON 5: CI/CD with GitHub Actions (11 Questions) =====
    new QuizQuestion
    {
        Id = 29,
        Topic = "Deployment",
        Question = "What does CI/CD stand for?",
        Options = new List<string> {
            "Continuous Integration / Continuous Deployment",
            "Code Integration / Code Deployment",
            "Continuous Improvement / Continuous Delivery",
            "Code Infrastructure / Code Development"
        },
        CorrectAnswer = 0,
        Explanation = "CI/CD stands for Continuous Integration and Continuous Deployment."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "Deployment",
        Question = "Where are GitHub Actions workflows defined?",
        Options = new List<string> {
            "In the .github/workflows directory",
            "In the root directory",
            "In the src directory",
            "In the config directory"
        },
        CorrectAnswer = 0,
        Explanation = "GitHub Actions workflows are defined as YAML files in the .github/workflows directory."
    },
    new QuizQuestion
    {
        Id = 31,
        Topic = "Deployment",
        Question = "What is the purpose of 'secrets' in GitHub Actions?",
        Options = new List<string> {
            "To store sensitive information securely",
            "To store code",
            "To store configuration",
            "To store dependencies"
        },
        CorrectAnswer = 0,
        Explanation = "Secrets store sensitive information like passwords and API keys securely in GitHub Actions."
    },
    new QuizQuestion
    {
        Id = 32,
        Topic = "Deployment",
        Question = "Which event triggers a GitHub Actions workflow on code push?",
        Options = new List<string> {
            "workflow_dispatch",
            "push",
            "pull_request",
            "schedule"
        },
        CorrectAnswer = 1,
        Explanation = "The 'push' event triggers a workflow when code is pushed to a branch."
    },
    new QuizQuestion
    {
        Id = 33,
        Topic = "Deployment",
        Question = "What is the purpose of the 'needs' keyword in GitHub Actions?",
        Options = new List<string> {
            "To define job dependencies",
            "To install dependencies",
            "To run parallel jobs",
            "To skip jobs"
        },
        CorrectAnswer = 0,
        Explanation = "The 'needs' keyword defines dependencies between jobs, ensuring one job completes before another starts."
    },
    new QuizQuestion
    {
        Id = 34,
        Topic = "Deployment",
        Question = "Which command runs tests in a .NET GitHub Actions workflow?",
        Options = new List<string> {
            "dotnet test",
            "dotnet run",
            "dotnet build",
            "dotnet publish"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet test' command runs unit tests in a .NET project."
    },
    new QuizQuestion
    {
        Id = 35,
        Topic = "Deployment",
        Question = "What does the 'actions/checkout@v3' action do?",
        Options = new List<string> {
            "Checks out the repository code",
            "Checks for errors",
            "Checks dependencies",
            "Checks the build status"
        },
        CorrectAnswer = 0,
        Explanation = "The 'actions/checkout@v3' action checks out the repository code so the workflow can access it."
    },
    new QuizQuestion
    {
        Id = 36,
        Topic = "Deployment",
        Question = "What is the purpose of the 'azure/webapps-deploy@v2' action?",
        Options = new List<string> {
            "Deploys to Azure App Service",
            "Creates an Azure account",
            "Manages Azure databases",
            "Configures Azure security"
        },
        CorrectAnswer = 0,
        Explanation = "The 'azure/webapps-deploy@v2' action deploys applications to Azure App Service."
    },
    new QuizQuestion
    {
        Id = 37,
        Topic = "Deployment",
        Question = "What does the 'workflow_dispatch' event allow?",
        Options = new List<string> {
            "Manual workflow triggering",
            "Automatic workflow triggering",
            "Scheduled workflow triggering",
            "Event-based triggering"
        },
        CorrectAnswer = 0,
        Explanation = "The 'workflow_dispatch' event allows manual triggering of a workflow from the GitHub UI."
    },
    new QuizQuestion
    {
        Id = 38,
        Topic = "Deployment",
        Question = "How do you make a job run only on the main branch?",
        Options = new List<string> {
            "if: github.ref == 'refs/heads/main'",
            "if: github.branch == 'main'",
            "if: github.ref == 'main'",
            "if: github.branch == 'refs/heads/main'"
        },
        CorrectAnswer = 0,
        Explanation = "The condition 'if: github.ref == 'refs/heads/main'' ensures a job only runs on the main branch."
    },
    new QuizQuestion
    {
        Id = 39,
        Topic = "Deployment",
        Question = "What is the purpose of 'actions/upload-artifact@v3' in a workflow?",
        Options = new List<string> {
            "To store build artifacts",
            "To upload code to GitHub",
            "To deploy to Azure",
            "To run tests"
        },
        CorrectAnswer = 0,
        Explanation = "The 'actions/upload-artifact@v3' action stores build artifacts that can be used by other jobs or downloaded."
    }
};






        // ================================================================
        // C# FUNDAMENTALS - LESSON 1: Introduction to C#
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson1"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson1",
        Question = "When was C# first released?",
        Options = new List<string> { "1998", "2000", "2002", "2004" },
        CorrectAnswer = 2,
        Explanation = "C# was released in 2002 as part of the .NET framework."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson1",
        Question = "Who designed the C# programming language?",
        Options = new List<string> {
            "Bill Gates",
            "Anders Hejlsberg",
            "James Gosling",
            "Bjarne Stroustrup"
        },
        CorrectAnswer = 1,
        Explanation = "Anders Hejlsberg designed C# at Microsoft."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson1",
        Question = "Which of the following is NOT a valid use case for C#?",
        Options = new List<string> {
            "Desktop applications",
            "Web applications",
            "Mobile applications",
            "Hardware drivers"
        },
        CorrectAnswer = 3,
        Explanation = "While C# can be used for many things, hardware drivers are typically written in C or C++."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson1",
        Question = "What type of programming language is C#?",
        Options = new List<string> {
            "Procedural only",
            "Object-oriented",
            "Functional only",
            "Assembly language"
        },
        CorrectAnswer = 1,
        Explanation = "C# is primarily an object-oriented programming language."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson1",
        Question = "What is the entry point of a C# program?",
        Options = new List<string> { "Start()", "Main()", "Run()", "Begin()" },
        CorrectAnswer = 1,
        Explanation = "The Main() method is the entry point of every C# program."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 2: Setting Up Environment
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson2"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson2",
        Question = "Which IDE is recommended for C# development?",
        Options = new List<string> {
            "Visual Studio Code",
            "Visual Studio",
            "IntelliJ IDEA",
            "Eclipse"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio is the recommended IDE for C# development."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson2",
        Question = "Which command checks if .NET SDK is installed?",
        Options = new List<string> {
            "dotnet --version",
            "dotnet check",
            "net --version",
            "dotnet --install"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet --version' command shows the installed .NET SDK version."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson2",
        Question = "What is the free edition of Visual Studio called?",
        Options = new List<string> {
            "Visual Studio Free",
            "Visual Studio Community",
            "Visual Studio Express",
            "Visual Studio Basic"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio Community is the free edition of Visual Studio."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson2",
        Question = "Which tool is used for version control in C# projects?",
        Options = new List<string> {
            "SVN",
            "Git",
            "Mercurial",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Git, SVN, and Mercurial are all version control systems that work with C# projects."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson2",
        Question = "Which command creates a new console application?",
        Options = new List<string> {
            "dotnet create console",
            "dotnet new console",
            "dotnet start console",
            "dotnet init console"
        },
        CorrectAnswer = 1,
        Explanation = "'dotnet new console' creates a new console application project."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 3: Variables and Data Types
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson3"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson3",
        Question = "Which data type is used for whole numbers in C#?",
        Options = new List<string> { "double", "decimal", "int", "float" },
        CorrectAnswer = 2,
        Explanation = "The 'int' data type is used for whole numbers in C#."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson3",
        Question = "What is the range of the int data type in C#?",
        Options = new List<string> {
            "-128 to 127",
            "-32,768 to 32,767",
            "-2,147,483,648 to 2,147,483,647",
            "0 to 4,294,967,295"
        },
        CorrectAnswer = 2,
        Explanation = "The int data type in C# ranges from -2,147,483,648 to 2,147,483,647."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson3",
        Question = "Which data type is best for precise decimal calculations like money?",
        Options = new List<string> { "double", "float", "decimal", "int" },
        CorrectAnswer = 2,
        Explanation = "The 'decimal' type is best for precise decimal calculations like money."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson3",
        Question = "What does the 'var' keyword do in C#?",
        Options = new List<string> {
            "Creates a variable without a type",
            "Implicitly types a variable based on the value",
            "Makes a variable constant",
            "Creates a global variable"
        },
        CorrectAnswer = 1,
        Explanation = "'var' tells the compiler to infer the type from the value assigned."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson3",
        Question = "What is a nullable type in C#?",
        Options = new List<string> {
            "A type that can be null",
            "A type that cannot be null",
            "A type that is always optional",
            "A type with a default value of null"
        },
        CorrectAnswer = 0,
        Explanation = "Nullable types (like int?) allow value types to be assigned null."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 4: Operators and Expressions
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson4"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson4",
        Question = "What does the % operator do in C#?",
        Options = new List<string> {
            "Division",
            "Multiplication",
            "Modulus (remainder)",
            "Percentage"
        },
        CorrectAnswer = 2,
        Explanation = "The % operator returns the remainder of a division operation."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson4",
        Question = "What is the result of 10 / 3 in C# (integer division)?",
        Options = new List<string> { "3.333", "3", "4", "3.33" },
        CorrectAnswer = 1,
        Explanation = "Integer division in C# truncates the decimal part, so 10 / 3 = 3."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson4",
        Question = "Which operator is used for logical AND in C#?",
        Options = new List<string> { "&", "&&", "and", "AND" },
        CorrectAnswer = 1,
        Explanation = "The '&&' operator is used for logical AND in C#."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson4",
        Question = "What is the difference between ++x and x++?",
        Options = new List<string> {
            "No difference",
            "++x increments before use, x++ increments after use",
            "x++ increments before use, ++x increments after use",
            "They produce different results only with strings"
        },
        CorrectAnswer = 1,
        Explanation = "++x (pre-increment) increments the value before using it, while x++ (post-increment) uses the current value then increments."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson4",
        Question = "Which operator is used for string concatenation?",
        Options = new List<string> { "+", "&", ".", "," },
        CorrectAnswer = 0,
        Explanation = "The '+' operator is used for string concatenation in C#."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 5: Control Flow
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson5"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson5",
        Question = "What does the if statement do in C#?",
        Options = new List<string> {
            "Executes code based on a condition",
            "Repeats code multiple times",
            "Defines a new variable",
            "Creates a new class"
        },
        CorrectAnswer = 0,
        Explanation = "The if statement executes code based on whether a condition is true or false."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson5",
        Question = "Which statement is best for multiple condition checks?",
        Options = new List<string> { "if-else if", "switch", "while", "for" },
        CorrectAnswer = 1,
        Explanation = "The switch statement is best for checking multiple specific values against a single expression."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson5",
        Question = "What does the break keyword do in a switch statement?",
        Options = new List<string> {
            "Continues to next case",
            "Exits the switch block",
            "Restarts the switch",
            "Skips the current iteration"
        },
        CorrectAnswer = 1,
        Explanation = "The break keyword exits the switch block after a case is matched."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson5",
        Question = "What is the ternary operator syntax in C#?",
        Options = new List<string> {
            "condition ? true_value : false_value",
            "condition : true_value ? false_value",
            "true_value ? condition : false_value",
            "condition ? false_value : true_value"
        },
        CorrectAnswer = 0,
        Explanation = "The ternary operator syntax is: condition ? true_value : false_value."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson5",
        Question = "What does the default case do in a switch statement?",
        Options = new List<string> {
            "Handles all unmatched values",
            "Handles only the first value",
            "Exits the switch",
            "Throws an exception"
        },
        CorrectAnswer = 0,
        Explanation = "The default case handles all values that don't match any other case."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 6: Loops
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson6"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson6",
        Question = "Which loop is best when you know how many times to iterate?",
        Options = new List<string> { "while", "do-while", "for", "foreach" },
        CorrectAnswer = 2,
        Explanation = "The for loop is best when you know the exact number of iterations in advance."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson6",
        Question = "Which loop always executes at least once?",
        Options = new List<string> { "for", "while", "do-while", "foreach" },
        CorrectAnswer = 2,
        Explanation = "The do-while loop always executes the code block at least once before checking the condition."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson6",
        Question = "What does the continue statement do in a loop?",
        Options = new List<string> {
            "Exits the loop entirely",
            "Skips the current iteration",
            "Restarts the loop",
            "Throws an exception"
        },
        CorrectAnswer = 1,
        Explanation = "The continue statement skips the current iteration and continues with the next one."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson6",
        Question = "Which loop is specifically designed for collections?",
        Options = new List<string> { "for", "while", "do-while", "foreach" },
        CorrectAnswer = 3,
        Explanation = "The foreach loop is specifically designed to iterate over collections like arrays and lists."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson6",
        Question = "What does the break statement do in a loop?",
        Options = new List<string> {
            "Skips the current iteration",
            "Exits the loop entirely",
            "Restarts the loop",
            "Continues to the next iteration"
        },
        CorrectAnswer = 1,
        Explanation = "The break statement exits the loop entirely, regardless of the loop condition."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 7: Arrays and Collections
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson7"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson7",
        Question = "What is the index of the first element in an array?",
        Options = new List<string> { "0", "1", "-1", "Depends on the array" },
        CorrectAnswer = 0,
        Explanation = "Arrays in C# are zero-indexed, meaning the first element is at index 0."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson7",
        Question = "Which collection type stores key-value pairs?",
        Options = new List<string> { "List<T>", "Array", "Dictionary<TKey, TValue>", "Queue<T>" },
        CorrectAnswer = 2,
        Explanation = "Dictionary<TKey, TValue> stores key-value pairs for fast lookups by key."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson7",
        Question = "What is the difference between Array and List<T>?",
        Options = new List<string> {
            "Arrays are dynamic, Lists are fixed",
            "Arrays are fixed, Lists are dynamic",
            "There is no difference",
            "Arrays can only store strings"
        },
        CorrectAnswer = 1,
        Explanation = "Arrays have a fixed size, while Lists<T> can grow and shrink dynamically."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson7",
        Question = "Which collection ensures all items are unique?",
        Options = new List<string> { "List<T>", "HashSet<T>", "Array", "Dictionary<TKey, TValue>" },
        CorrectAnswer = 1,
        Explanation = "HashSet<T> ensures that all items in the collection are unique."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson7",
        Question = "What is a multidimensional array?",
        Options = new List<string> {
            "An array with more than one dimension",
            "An array of arrays",
            "A collection of arrays",
            "A list of arrays"
        },
        CorrectAnswer = 0,
        Explanation = "A multidimensional array has more than one dimension, like a grid or matrix."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 8: Strings
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson8"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson8",
        Question = "Are strings mutable or immutable in C#?",
        Options = new List<string> { "Mutable", "Immutable", "Both", "Depends on the version" },
        CorrectAnswer = 1,
        Explanation = "Strings in C# are immutable. Every operation creates a new string instance."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson8",
        Question = "Which class should you use for heavy string manipulation?",
        Options = new List<string> { "String", "StringBuilder", "StringBuffer", "StringWriter" },
        CorrectAnswer = 1,
        Explanation = "StringBuilder is more efficient than String for heavy string manipulation."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson8",
        Question = "What is string interpolation?",
        Options = new List<string> {
            "Concatenating strings with +",
            "Embedding expressions inside strings using $",
            "Splitting strings into parts",
            "Converting strings to numbers"
        },
        CorrectAnswer = 1,
        Explanation = "String interpolation using $ allows you to embed expressions directly in strings: $\"Hello {name}\"."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson8",
        Question = "Which method splits a string into an array of substrings?",
        Options = new List<string> { "Split()", "Substring()", "IndexOf()", "Replace()" },
        CorrectAnswer = 0,
        Explanation = "The Split() method splits a string into an array of substrings based on a delimiter."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson8",
        Question = "What does the Trim() method do to a string?",
        Options = new List<string> {
            "Removes all spaces",
            "Removes leading and trailing spaces",
            "Removes only leading spaces",
            "Removes only trailing spaces"
        },
        CorrectAnswer = 1,
        Explanation = "The Trim() method removes all leading and trailing whitespace characters from a string."
    }
};
        // ================================================================
        // C# FUNDAMENTALS - LESSON 9: Exception Handling
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson9"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson9",
        Question = "What is exception handling in C#?",
        Options = new List<string> {
            "Ignoring errors in code",
            "Handling runtime errors gracefully",
            "Preventing all errors",
            "Logging only errors"
        },
        CorrectAnswer = 1,
        Explanation = "Exception handling allows you to handle runtime errors gracefully without crashing the application."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson9",
        Question = "What is the correct order of catch blocks?",
        Options = new List<string> {
            "Most specific to most general",
            "Most general to most specific",
            "Order doesn't matter",
            "Only one catch block is allowed"
        },
        CorrectAnswer = 0,
        Explanation = "Catch blocks should be ordered from most specific to most general (Exception last)."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson9",
        Question = "What is the purpose of the finally block?",
        Options = new List<string> {
            "To catch exceptions",
            "To always execute code regardless of exceptions",
            "To throw exceptions",
            "To log errors"
        },
        CorrectAnswer = 1,
        Explanation = "The finally block always executes, whether an exception occurs or not."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson9",
        Question = "Which keyword is used to throw a custom exception?",
        Options = new List<string> { "throw", "throws", "raise", "error" },
        CorrectAnswer = 0,
        Explanation = "The 'throw' keyword is used to explicitly throw an exception."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson9",
        Question = "What does the using statement do?",
        Options = new List<string> {
            "Imports a namespace",
            "Automatically disposes objects",
            "Creates a new object",
            "Defines a scope"
        },
        CorrectAnswer = 1,
        Explanation = "The using statement ensures that IDisposable objects are properly disposed of."
    }
};
        // ================================================================
        // C# FUNDAMENTALS - LESSON 10: Methods Basics
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson10"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson10",
        Question = "What is a method in C#?",
        Options = new List<string> {
            "A block of code that performs a specific task",
            "A variable that stores data",
            "A type of class",
            "A property that validates data"
        },
        CorrectAnswer = 0,
        Explanation = "A method is a block of code that performs a specific task."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson10",
        Question = "What is method overloading?",
        Options = new List<string> {
            "Multiple methods with the same name but different parameters",
            "Methods with different names",
            "Methods in different classes",
            "Methods that return different types"
        },
        CorrectAnswer = 0,
        Explanation = "Method overloading allows multiple methods with the same name but different parameters."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson10",
        Question = "What does the 'params' keyword do?",
        Options = new List<string> {
            "Makes a parameter optional",
            "Allows a method to accept a variable number of arguments",
            "Makes a parameter read-only",
            "Passes parameters by reference"
        },
        CorrectAnswer = 1,
        Explanation = "The 'params' keyword allows a method to accept a variable number of arguments."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson10",
        Question = "What is the difference between ref and out parameters?",
        Options = new List<string> {
            "ref requires initialization, out doesn't",
            "out requires initialization, ref doesn't",
            "They are the same",
            "ref is for value types only"
        },
        CorrectAnswer = 0,
        Explanation = "ref parameters must be initialized before being passed, while out parameters don't need to be initialized."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson10",
        Question = "What is a static method?",
        Options = new List<string> {
            "A method that belongs to the class, not an instance",
            "A method that belongs to an instance",
            "A method that never changes",
            "A method that cannot be called"
        },
        CorrectAnswer = 0,
        Explanation = "Static methods belong to the class itself and can be called without creating an instance."
    }
};
        // ================================================================
        // C# FUNDAMENTALS - LESSON 11: Pattern Matching & Nullables
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson11"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson11",
        Question = "How do you declare a nullable int in C#?",
        Options = new List<string> { "int? myInt", "int myInt?", "nullable int myInt", "int myInt = null" },
        CorrectAnswer = 0,
        Explanation = "You declare a nullable int using the '?' suffix: int? myInt = null;"
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson11",
        Question = "What does the ?? operator do?",
        Options = new List<string> {
            "Checks if a value is null",
            "Returns the left operand if not null, otherwise the right operand",
            "Checks for equality",
            "Throws an exception if null"
        },
        CorrectAnswer = 1,
        Explanation = "The null-coalescing operator (??) returns the left operand if it's not null, otherwise the right operand."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson11",
        Question = "What does the 'is' keyword do in pattern matching?",
        Options = new List<string> {
            "Checks type compatibility",
            "Casts an object",
            "Creates a new object",
            "Deletes an object"
        },
        CorrectAnswer = 0,
        Explanation = "The 'is' keyword checks if an object is compatible with a specific type."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson11",
        Question = "What is pattern matching in C#?",
        Options = new List<string> {
            "A way to match strings",
            "A way to test values against patterns",
            "A way to create patterns",
            "A way to format strings"
        },
        CorrectAnswer = 1,
        Explanation = "Pattern matching allows you to test values against patterns to extract information or check conditions."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson11",
        Question = "What does the ??= operator do?",
        Options = new List<string> {
            "Assigns a value if the variable is null",
            "Checks for null",
            "Throws an exception",
            "Creates a new variable"
        },
        CorrectAnswer = 0,
        Explanation = "The null-coalescing assignment operator (??=) assigns the right operand to the left operand if the left operand is null."
    }
};

        // ================================================================
        // C# FUNDAMENTALS - LESSON 12: LINQ Introduction
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson12"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson12",
        Question = "What does LINQ stand for?",
        Options = new List<string> {
            "Language Integrated Query",
            "Language Interrogation Query",
            "Linear Integrated Query",
            "Language Integrated Question"
        },
        CorrectAnswer = 0,
        Explanation = "LINQ stands for Language Integrated Query."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson12",
        Question = "Which LINQ method filters a collection?",
        Options = new List<string> { "Select", "Where", "OrderBy", "GroupBy" },
        CorrectAnswer = 1,
        Explanation = "The Where method filters a collection based on a condition."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson12",
        Question = "Which LINQ method transforms a collection?",
        Options = new List<string> { "Where", "Select", "OrderBy", "GroupBy" },
        CorrectAnswer = 1,
        Explanation = "The Select method projects/transforms each element of a collection."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson12",
        Question = "Which LINQ method calculates the sum of a numeric property?",
        Options = new List<string> { "Average", "Sum", "Count", "Max" },
        CorrectAnswer = 1,
        Explanation = "The Sum method calculates the sum of a numeric property in a collection."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson12",
        Question = "Which LINQ method checks if any element meets a condition?",
        Options = new List<string> { "All", "Any", "Contains", "Exists" },
        CorrectAnswer = 1,
        Explanation = "The Any method checks if at least one element in the collection meets a condition."
    }
};


        // ================================================================
        // C# FUNDAMENTALS - LESSON 13: Delegates, Events & Async
        // ================================================================
        _quizzes["CSharpFundamentals_Lesson13"] = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals_Lesson13",
        Question = "What is a delegate in C#?",
        Options = new List<string> {
            "A type that holds a reference to a method",
            "A type of class",
            "A type of variable",
            "A type of collection"
        },
        CorrectAnswer = 0,
        Explanation = "A delegate is a type that holds a reference to a method with a specific signature."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals_Lesson13",
        Question = "What is the difference between Func and Action in C#?",
        Options = new List<string> {
            "Func returns a value, Action doesn't",
            "Action returns a value, Func doesn't",
            "They are the same",
            "Func is for strings only"
        },
        CorrectAnswer = 0,
        Explanation = "Func delegates return a value, while Action delegates do not return a value."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals_Lesson13",
        Question = "What is an event in C#?",
        Options = new List<string> {
            "A way to raise notifications",
            "A type of delegate",
            "A type of class",
            "A type of variable"
        },
        CorrectAnswer = 0,
        Explanation = "Events are a way to raise notifications when something happens, based on delegates."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals_Lesson13",
        Question = "What does the async keyword do?",
        Options = new List<string> {
            "Makes a method synchronous",
            "Marks a method as asynchronous",
            "Makes a method faster",
            "Makes a method return void"
        },
        CorrectAnswer = 1,
        Explanation = "The async keyword marks a method as asynchronous, allowing it to use await."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals_Lesson13",
        Question = "What does the await keyword do?",
        Options = new List<string> {
            "Blocks the thread",
            "Suspends execution until the awaited task completes",
            "Creates a new thread",
            "Cancels the operation"
        },
        CorrectAnswer = 1,
        Explanation = "The await keyword suspends execution of the current method until the awaited task completes."
    }
};
        // ================================================================
        // C# FUNDAMENTALS - FULL SECTION (All 65 Questions)
        // ================================================================
        _quizzes["CSharpFundamentals"] = new List<QuizQuestion>
{
    // ===== LESSON 1: Introduction to C# (5 Questions) =====
    new QuizQuestion
    {
        Id = 1,
        Topic = "CSharpFundamentals",
        Question = "When was C# first released?",
        Options = new List<string> { "1998", "2000", "2002", "2004" },
        CorrectAnswer = 2,
        Explanation = "C# was released in 2002 as part of the .NET framework."
    },
    new QuizQuestion
    {
        Id = 2,
        Topic = "CSharpFundamentals",
        Question = "Who designed the C# programming language?",
        Options = new List<string> {
            "Bill Gates",
            "Anders Hejlsberg",
            "James Gosling",
            "Bjarne Stroustrup"
        },
        CorrectAnswer = 1,
        Explanation = "Anders Hejlsberg designed C# at Microsoft."
    },
    new QuizQuestion
    {
        Id = 3,
        Topic = "CSharpFundamentals",
        Question = "Which of the following is NOT a valid use case for C#?",
        Options = new List<string> {
            "Desktop applications",
            "Web applications",
            "Mobile applications",
            "Hardware drivers"
        },
        CorrectAnswer = 3,
        Explanation = "While C# can be used for many things, hardware drivers are typically written in C or C++."
    },
    new QuizQuestion
    {
        Id = 4,
        Topic = "CSharpFundamentals",
        Question = "What type of programming language is C#?",
        Options = new List<string> {
            "Procedural only",
            "Object-oriented",
            "Functional only",
            "Assembly language"
        },
        CorrectAnswer = 1,
        Explanation = "C# is primarily an object-oriented programming language."
    },
    new QuizQuestion
    {
        Id = 5,
        Topic = "CSharpFundamentals",
        Question = "What is the entry point of a C# program?",
        Options = new List<string> { "Start()", "Main()", "Run()", "Begin()" },
        CorrectAnswer = 1,
        Explanation = "The Main() method is the entry point of every C# program."
    },

    // ===== LESSON 2: Setting Up Environment (5 Questions) =====
    new QuizQuestion
    {
        Id = 6,
        Topic = "CSharpFundamentals",
        Question = "Which IDE is recommended for C# development?",
        Options = new List<string> {
            "Visual Studio Code",
            "Visual Studio",
            "IntelliJ IDEA",
            "Eclipse"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio is the recommended IDE for C# development."
    },
    new QuizQuestion
    {
        Id = 7,
        Topic = "CSharpFundamentals",
        Question = "Which command checks if .NET SDK is installed?",
        Options = new List<string> {
            "dotnet --version",
            "dotnet check",
            "net --version",
            "dotnet --install"
        },
        CorrectAnswer = 0,
        Explanation = "The 'dotnet --version' command shows the installed .NET SDK version."
    },
    new QuizQuestion
    {
        Id = 8,
        Topic = "CSharpFundamentals",
        Question = "What is the free edition of Visual Studio called?",
        Options = new List<string> {
            "Visual Studio Free",
            "Visual Studio Community",
            "Visual Studio Express",
            "Visual Studio Basic"
        },
        CorrectAnswer = 1,
        Explanation = "Visual Studio Community is the free edition of Visual Studio."
    },
    new QuizQuestion
    {
        Id = 9,
        Topic = "CSharpFundamentals",
        Question = "Which tool is used for version control in C# projects?",
        Options = new List<string> {
            "SVN",
            "Git",
            "Mercurial",
            "All of the above"
        },
        CorrectAnswer = 3,
        Explanation = "Git, SVN, and Mercurial are all version control systems that work with C# projects."
    },
    new QuizQuestion
    {
        Id = 10,
        Topic = "CSharpFundamentals",
        Question = "Which command creates a new console application?",
        Options = new List<string> {
            "dotnet create console",
            "dotnet new console",
            "dotnet start console",
            "dotnet init console"
        },
        CorrectAnswer = 1,
        Explanation = "'dotnet new console' creates a new console application project."
    },

    // ===== LESSON 3: Variables and Data Types (5 Questions) =====
    new QuizQuestion
    {
        Id = 11,
        Topic = "CSharpFundamentals",
        Question = "Which data type is used for whole numbers in C#?",
        Options = new List<string> { "double", "decimal", "int", "float" },
        CorrectAnswer = 2,
        Explanation = "The 'int' data type is used for whole numbers in C#."
    },
    new QuizQuestion
    {
        Id = 12,
        Topic = "CSharpFundamentals",
        Question = "What is the range of the int data type in C#?",
        Options = new List<string> {
            "-128 to 127",
            "-32,768 to 32,767",
            "-2,147,483,648 to 2,147,483,647",
            "0 to 4,294,967,295"
        },
        CorrectAnswer = 2,
        Explanation = "The int data type in C# ranges from -2,147,483,648 to 2,147,483,647."
    },
    new QuizQuestion
    {
        Id = 13,
        Topic = "CSharpFundamentals",
        Question = "Which data type is best for precise decimal calculations like money?",
        Options = new List<string> { "double", "float", "decimal", "int" },
        CorrectAnswer = 2,
        Explanation = "The 'decimal' type is best for precise decimal calculations like money."
    },
    new QuizQuestion
    {
        Id = 14,
        Topic = "CSharpFundamentals",
        Question = "What does the 'var' keyword do in C#?",
        Options = new List<string> {
            "Creates a variable without a type",
            "Implicitly types a variable based on the value",
            "Makes a variable constant",
            "Creates a global variable"
        },
        CorrectAnswer = 1,
        Explanation = "'var' tells the compiler to infer the type from the value assigned."
    },
    new QuizQuestion
    {
        Id = 15,
        Topic = "CSharpFundamentals",
        Question = "What is a nullable type in C#?",
        Options = new List<string> {
            "A type that can be null",
            "A type that cannot be null",
            "A type that is always optional",
            "A type with a default value of null"
        },
        CorrectAnswer = 0,
        Explanation = "Nullable types (like int?) allow value types to be assigned null."
    },

    // ===== LESSON 4: Operators and Expressions (5 Questions) =====
    new QuizQuestion
    {
        Id = 16,
        Topic = "CSharpFundamentals",
        Question = "What does the % operator do in C#?",
        Options = new List<string> {
            "Division",
            "Multiplication",
            "Modulus (remainder)",
            "Percentage"
        },
        CorrectAnswer = 2,
        Explanation = "The % operator returns the remainder of a division operation."
    },
    new QuizQuestion
    {
        Id = 17,
        Topic = "CSharpFundamentals",
        Question = "What is the result of 10 / 3 in C# (integer division)?",
        Options = new List<string> { "3.333", "3", "4", "3.33" },
        CorrectAnswer = 1,
        Explanation = "Integer division in C# truncates the decimal part, so 10 / 3 = 3."
    },
    new QuizQuestion
    {
        Id = 18,
        Topic = "CSharpFundamentals",
        Question = "Which operator is used for logical AND in C#?",
        Options = new List<string> { "&", "&&", "and", "AND" },
        CorrectAnswer = 1,
        Explanation = "The '&&' operator is used for logical AND in C#."
    },
    new QuizQuestion
    {
        Id = 19,
        Topic = "CSharpFundamentals",
        Question = "What is the difference between ++x and x++?",
        Options = new List<string> {
            "No difference",
            "++x increments before use, x++ increments after use",
            "x++ increments before use, ++x increments after use",
            "They produce different results only with strings"
        },
        CorrectAnswer = 1,
        Explanation = "++x (pre-increment) increments the value before using it, while x++ (post-increment) uses the current value then increments."
    },
    new QuizQuestion
    {
        Id = 20,
        Topic = "CSharpFundamentals",
        Question = "Which operator is used for string concatenation?",
        Options = new List<string> { "+", "&", ".", "," },
        CorrectAnswer = 0,
        Explanation = "The '+' operator is used for string concatenation in C#."
    },

    // ===== LESSON 5: Control Flow (5 Questions) =====
    new QuizQuestion
    {
        Id = 21,
        Topic = "CSharpFundamentals",
        Question = "What does the if statement do in C#?",
        Options = new List<string> {
            "Executes code based on a condition",
            "Repeats code multiple times",
            "Defines a new variable",
            "Creates a new class"
        },
        CorrectAnswer = 0,
        Explanation = "The if statement executes code based on whether a condition is true or false."
    },
    new QuizQuestion
    {
        Id = 22,
        Topic = "CSharpFundamentals",
        Question = "Which statement is best for multiple condition checks?",
        Options = new List<string> { "if-else if", "switch", "while", "for" },
        CorrectAnswer = 1,
        Explanation = "The switch statement is best for checking multiple specific values against a single expression."
    },
    new QuizQuestion
    {
        Id = 23,
        Topic = "CSharpFundamentals",
        Question = "What does the break keyword do in a switch statement?",
        Options = new List<string> {
            "Continues to next case",
            "Exits the switch block",
            "Restarts the switch",
            "Skips the current iteration"
        },
        CorrectAnswer = 1,
        Explanation = "The break keyword exits the switch block after a case is matched."
    },
    new QuizQuestion
    {
        Id = 24,
        Topic = "CSharpFundamentals",
        Question = "What is the ternary operator syntax in C#?",
        Options = new List<string> {
            "condition ? true_value : false_value",
            "condition : true_value ? false_value",
            "true_value ? condition : false_value",
            "condition ? false_value : true_value"
        },
        CorrectAnswer = 0,
        Explanation = "The ternary operator syntax is: condition ? true_value : false_value."
    },
    new QuizQuestion
    {
        Id = 25,
        Topic = "CSharpFundamentals",
        Question = "What does the default case do in a switch statement?",
        Options = new List<string> {
            "Handles all unmatched values",
            "Handles only the first value",
            "Exits the switch",
            "Throws an exception"
        },
        CorrectAnswer = 0,
        Explanation = "The default case handles all values that don't match any other case."
    },

    // ===== LESSON 6: Loops (5 Questions) =====
    new QuizQuestion
    {
        Id = 26,
        Topic = "CSharpFundamentals",
        Question = "Which loop is best when you know how many times to iterate?",
        Options = new List<string> { "while", "do-while", "for", "foreach" },
        CorrectAnswer = 2,
        Explanation = "The for loop is best when you know the exact number of iterations in advance."
    },
    new QuizQuestion
    {
        Id = 27,
        Topic = "CSharpFundamentals",
        Question = "Which loop always executes at least once?",
        Options = new List<string> { "for", "while", "do-while", "foreach" },
        CorrectAnswer = 2,
        Explanation = "The do-while loop always executes the code block at least once before checking the condition."
    },
    new QuizQuestion
    {
        Id = 28,
        Topic = "CSharpFundamentals",
        Question = "What does the continue statement do in a loop?",
        Options = new List<string> {
            "Exits the loop entirely",
            "Skips the current iteration",
            "Restarts the loop",
            "Throws an exception"
        },
        CorrectAnswer = 1,
        Explanation = "The continue statement skips the current iteration and continues with the next one."
    },
    new QuizQuestion
    {
        Id = 29,
        Topic = "CSharpFundamentals",
        Question = "Which loop is specifically designed for collections?",
        Options = new List<string> { "for", "while", "do-while", "foreach" },
        CorrectAnswer = 3,
        Explanation = "The foreach loop is specifically designed to iterate over collections like arrays and lists."
    },
    new QuizQuestion
    {
        Id = 30,
        Topic = "CSharpFundamentals",
        Question = "What does the break statement do in a loop?",
        Options = new List<string> {
            "Skips the current iteration",
            "Exits the loop entirely",
            "Restarts the loop",
            "Continues to the next iteration"
        },
        CorrectAnswer = 1,
        Explanation = "The break statement exits the loop entirely, regardless of the loop condition."
    },

    // ===== LESSON 7: Arrays and Collections (5 Questions) =====
    new QuizQuestion
    {
        Id = 31,
        Topic = "CSharpFundamentals",
        Question = "What is the index of the first element in an array?",
        Options = new List<string> { "0", "1", "-1", "Depends on the array" },
        CorrectAnswer = 0,
        Explanation = "Arrays in C# are zero-indexed, meaning the first element is at index 0."
    },
    new QuizQuestion
    {
        Id = 32,
        Topic = "CSharpFundamentals",
        Question = "Which collection type stores key-value pairs?",
        Options = new List<string> { "List<T>", "Array", "Dictionary<TKey, TValue>", "Queue<T>" },
        CorrectAnswer = 2,
        Explanation = "Dictionary<TKey, TValue> stores key-value pairs for fast lookups by key."
    },
    new QuizQuestion
    {
        Id = 33,
        Topic = "CSharpFundamentals",
        Question = "What is the difference between Array and List<T>?",
        Options = new List<string> {
            "Arrays are dynamic, Lists are fixed",
            "Arrays are fixed, Lists are dynamic",
            "There is no difference",
            "Arrays can only store strings"
        },
        CorrectAnswer = 1,
        Explanation = "Arrays have a fixed size, while Lists<T> can grow and shrink dynamically."
    },
    new QuizQuestion
    {
        Id = 34,
        Topic = "CSharpFundamentals",
        Question = "Which collection ensures all items are unique?",
        Options = new List<string> { "List<T>", "HashSet<T>", "Array", "Dictionary<TKey, TValue>" },
        CorrectAnswer = 1,
        Explanation = "HashSet<T> ensures that all items in the collection are unique."
    },
    new QuizQuestion
    {
        Id = 35,
        Topic = "CSharpFundamentals",
        Question = "What is a multidimensional array?",
        Options = new List<string> {
            "An array with more than one dimension",
            "An array of arrays",
            "A collection of arrays",
            "A list of arrays"
        },
        CorrectAnswer = 0,
        Explanation = "A multidimensional array has more than one dimension, like a grid or matrix."
    },

    // ===== LESSON 8: Strings (5 Questions) =====
    new QuizQuestion
    {
        Id = 36,
        Topic = "CSharpFundamentals",
        Question = "Are strings mutable or immutable in C#?",
        Options = new List<string> { "Mutable", "Immutable", "Both", "Depends on the version" },
        CorrectAnswer = 1,
        Explanation = "Strings in C# are immutable. Every operation creates a new string instance."
    },
    new QuizQuestion
    {
        Id = 37,
        Topic = "CSharpFundamentals",
        Question = "Which class should you use for heavy string manipulation?",
        Options = new List<string> { "String", "StringBuilder", "StringBuffer", "StringWriter" },
        CorrectAnswer = 1,
        Explanation = "StringBuilder is more efficient than String for heavy string manipulation."
    },
    new QuizQuestion
    {
        Id = 38,
        Topic = "CSharpFundamentals",
        Question = "What is string interpolation?",
        Options = new List<string> {
            "Concatenating strings with +",
            "Embedding expressions inside strings using $",
            "Splitting strings into parts",
            "Converting strings to numbers"
        },
        CorrectAnswer = 1,
        Explanation = "String interpolation using $ allows you to embed expressions directly in strings: $\"Hello {name}\"."
    },
    new QuizQuestion
    {
        Id = 39,
        Topic = "CSharpFundamentals",
        Question = "Which method splits a string into an array of substrings?",
        Options = new List<string> { "Split()", "Substring()", "IndexOf()", "Replace()" },
        CorrectAnswer = 0,
        Explanation = "The Split() method splits a string into an array of substrings based on a delimiter."
    },
    new QuizQuestion
    {
        Id = 40,
        Topic = "CSharpFundamentals",
        Question = "What does the Trim() method do to a string?",
        Options = new List<string> {
            "Removes all spaces",
            "Removes leading and trailing spaces",
            "Removes only leading spaces",
            "Removes only trailing spaces"
        },
        CorrectAnswer = 1,
        Explanation = "The Trim() method removes all leading and trailing whitespace characters from a string."
    },

    // ===== LESSON 9: Exception Handling (5 Questions) =====
    new QuizQuestion
    {
        Id = 41,
        Topic = "CSharpFundamentals",
        Question = "What is exception handling in C#?",
        Options = new List<string> {
            "Ignoring errors in code",
            "Handling runtime errors gracefully",
            "Preventing all errors",
            "Logging only errors"
        },
        CorrectAnswer = 1,
        Explanation = "Exception handling allows you to handle runtime errors gracefully without crashing the application."
    },
    new QuizQuestion
    {
        Id = 42,
        Topic = "CSharpFundamentals",
        Question = "What is the correct order of catch blocks?",
        Options = new List<string> {
            "Most specific to most general",
            "Most general to most specific",
            "Order doesn't matter",
            "Only one catch block is allowed"
        },
        CorrectAnswer = 0,
        Explanation = "Catch blocks should be ordered from most specific to most general (Exception last)."
    },
    new QuizQuestion
    {
        Id = 43,
        Topic = "CSharpFundamentals",
        Question = "What is the purpose of the finally block?",
        Options = new List<string> {
            "To catch exceptions",
            "To always execute code regardless of exceptions",
            "To throw exceptions",
            "To log errors"
        },
        CorrectAnswer = 1,
        Explanation = "The finally block always executes, whether an exception occurs or not."
    },
    new QuizQuestion
    {
        Id = 44,
        Topic = "CSharpFundamentals",
        Question = "Which keyword is used to throw a custom exception?",
        Options = new List<string> { "throw", "throws", "raise", "error" },
        CorrectAnswer = 0,
        Explanation = "The 'throw' keyword is used to explicitly throw an exception."
    },
    new QuizQuestion
    {
        Id = 45,
        Topic = "CSharpFundamentals",
        Question = "What does the using statement do?",
        Options = new List<string> {
            "Imports a namespace",
            "Automatically disposes objects",
            "Creates a new object",
            "Defines a scope"
        },
        CorrectAnswer = 1,
        Explanation = "The using statement ensures that IDisposable objects are properly disposed of."
    },

    // ===== LESSON 10: Methods Basics (5 Questions) =====
    new QuizQuestion
    {
        Id = 46,
        Topic = "CSharpFundamentals",
        Question = "What is a method in C#?",
        Options = new List<string> {
            "A block of code that performs a specific task",
            "A variable that stores data",
            "A type of class",
            "A property that validates data"
        },
        CorrectAnswer = 0,
        Explanation = "A method is a block of code that performs a specific task."
    },
    new QuizQuestion
    {
        Id = 47,
        Topic = "CSharpFundamentals",
        Question = "What is method overloading?",
        Options = new List<string> {
            "Multiple methods with the same name but different parameters",
            "Methods with different names",
            "Methods in different classes",
            "Methods that return different types"
        },
        CorrectAnswer = 0,
        Explanation = "Method overloading allows multiple methods with the same name but different parameters."
    },
    new QuizQuestion
    {
        Id = 48,
        Topic = "CSharpFundamentals",
        Question = "What does the 'params' keyword do?",
        Options = new List<string> {
            "Makes a parameter optional",
            "Allows a method to accept a variable number of arguments",
            "Makes a parameter read-only",
            "Passes parameters by reference"
        },
        CorrectAnswer = 1,
        Explanation = "The 'params' keyword allows a method to accept a variable number of arguments."
    },
    new QuizQuestion
    {
        Id = 49,
        Topic = "CSharpFundamentals",
        Question = "What is the difference between ref and out parameters?",
        Options = new List<string> {
            "ref requires initialization, out doesn't",
            "out requires initialization, ref doesn't",
            "They are the same",
            "ref is for value types only"
        },
        CorrectAnswer = 0,
        Explanation = "ref parameters must be initialized before being passed, while out parameters don't need to be initialized."
    },
    new QuizQuestion
    {
        Id = 50,
        Topic = "CSharpFundamentals",
        Question = "What is a static method?",
        Options = new List<string> {
            "A method that belongs to the class, not an instance",
            "A method that belongs to an instance",
            "A method that never changes",
            "A method that cannot be called"
        },
        CorrectAnswer = 0,
        Explanation = "Static methods belong to the class itself and can be called without creating an instance."
    },

    // ===== LESSON 11: Pattern Matching & Nullables (5 Questions) =====
    new QuizQuestion
    {
        Id = 51,
        Topic = "CSharpFundamentals",
        Question = "How do you declare a nullable int in C#?",
        Options = new List<string> { "int? myInt", "int myInt?", "nullable int myInt", "int myInt = null" },
        CorrectAnswer = 0,
        Explanation = "You declare a nullable int using the '?' suffix: int? myInt = null;"
    },
    new QuizQuestion
    {
        Id = 52,
        Topic = "CSharpFundamentals",
        Question = "What does the ?? operator do?",
        Options = new List<string> {
            "Checks if a value is null",
            "Returns the left operand if not null, otherwise the right operand",
            "Checks for equality",
            "Throws an exception if null"
        },
        CorrectAnswer = 1,
        Explanation = "The null-coalescing operator (??) returns the left operand if it's not null, otherwise the right operand."
    },
    new QuizQuestion
    {
        Id = 53,
        Topic = "CSharpFundamentals",
        Question = "What does the 'is' keyword do in pattern matching?",
        Options = new List<string> {
            "Checks type compatibility",
            "Casts an object",
            "Creates a new object",
            "Deletes an object"
        },
        CorrectAnswer = 0,
        Explanation = "The 'is' keyword checks if an object is compatible with a specific type."
    },
    new QuizQuestion
    {
        Id = 54,
        Topic = "CSharpFundamentals",
        Question = "What is pattern matching in C#?",
        Options = new List<string> {
            "A way to match strings",
            "A way to test values against patterns",
            "A way to create patterns",
            "A way to format strings"
        },
        CorrectAnswer = 1,
        Explanation = "Pattern matching allows you to test values against patterns to extract information or check conditions."
    },
    new QuizQuestion
    {
        Id = 55,
        Topic = "CSharpFundamentals",
        Question = "What does the ??= operator do?",
        Options = new List<string> {
            "Assigns a value if the variable is null",
            "Checks for null",
            "Throws an exception",
            "Creates a new variable"
        },
        CorrectAnswer = 0,
        Explanation = "The null-coalescing assignment operator (??=) assigns the right operand to the left operand if the left operand is null."
    },

    // ===== LESSON 12: LINQ Introduction (5 Questions) =====
    new QuizQuestion
    {
        Id = 56,
        Topic = "CSharpFundamentals",
        Question = "What does LINQ stand for?",
        Options = new List<string> {
            "Language Integrated Query",
            "Language Interrogation Query",
            "Linear Integrated Query",
            "Language Integrated Question"
        },
        CorrectAnswer = 0,
        Explanation = "LINQ stands for Language Integrated Query."
    },
    new QuizQuestion
    {
        Id = 57,
        Topic = "CSharpFundamentals",
        Question = "Which LINQ method filters a collection?",
        Options = new List<string> { "Select", "Where", "OrderBy", "GroupBy" },
        CorrectAnswer = 1,
        Explanation = "The Where method filters a collection based on a condition."
    },
    new QuizQuestion
    {
        Id = 58,
        Topic = "CSharpFundamentals",
        Question = "Which LINQ method transforms a collection?",
        Options = new List<string> { "Where", "Select", "OrderBy", "GroupBy" },
        CorrectAnswer = 1,
        Explanation = "The Select method projects/transforms each element of a collection."
    },
    new QuizQuestion
    {
        Id = 59,
        Topic = "CSharpFundamentals",
        Question = "Which LINQ method calculates the sum of a numeric property?",
        Options = new List<string> { "Average", "Sum", "Count", "Max" },
        CorrectAnswer = 1,
        Explanation = "The Sum method calculates the sum of a numeric property in a collection."
    },
    new QuizQuestion
    {
        Id = 60,
        Topic = "CSharpFundamentals",
        Question = "Which LINQ method checks if any element meets a condition?",
        Options = new List<string> { "All", "Any", "Contains", "Exists" },
        CorrectAnswer = 1,
        Explanation = "The Any method checks if at least one element in the collection meets a condition."
    },

    // ===== LESSON 13: Delegates, Events & Async (5 Questions) =====
    new QuizQuestion
    {
        Id = 61,
        Topic = "CSharpFundamentals",
        Question = "What is a delegate in C#?",
        Options = new List<string> {
            "A type that holds a reference to a method",
            "A type of class",
            "A type of variable",
            "A type of collection"
        },
        CorrectAnswer = 0,
        Explanation = "A delegate is a type that holds a reference to a method with a specific signature."
    },
    new QuizQuestion
    {
        Id = 62,
        Topic = "CSharpFundamentals",
        Question = "What is the difference between Func and Action in C#?",
        Options = new List<string> {
            "Func returns a value, Action doesn't",
            "Action returns a value, Func doesn't",
            "They are the same",
            "Func is for strings only"
        },
        CorrectAnswer = 0,
        Explanation = "Func delegates return a value, while Action delegates do not return a value."
    },
    new QuizQuestion
    {
        Id = 63,
        Topic = "CSharpFundamentals",
        Question = "What is an event in C#?",
        Options = new List<string> {
            "A way to raise notifications",
            "A type of delegate",
            "A type of class",
            "A type of variable"
        },
        CorrectAnswer = 0,
        Explanation = "Events are a way to raise notifications when something happens, based on delegates."
    },
    new QuizQuestion
    {
        Id = 64,
        Topic = "CSharpFundamentals",
        Question = "What does the async keyword do?",
        Options = new List<string> {
            "Makes a method synchronous",
            "Marks a method as asynchronous",
            "Makes a method faster",
            "Makes a method return void"
        },
        CorrectAnswer = 1,
        Explanation = "The async keyword marks a method as asynchronous, allowing it to use await."
    },
    new QuizQuestion
    {
        Id = 65,
        Topic = "CSharpFundamentals",
        Question = "What does the await keyword do?",
        Options = new List<string> {
            "Blocks the thread",
            "Suspends execution until the awaited task completes",
            "Creates a new thread",
            "Cancels the operation"
        },
        CorrectAnswer = 1,
        Explanation = "The await keyword suspends execution of the current method until the awaited task completes."
    }
};

















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