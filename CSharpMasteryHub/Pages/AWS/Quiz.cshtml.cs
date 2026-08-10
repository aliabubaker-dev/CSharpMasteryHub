using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpMasteryHub.Models;
using CSharpMasteryHub.Services;

namespace CSharpMasteryHub.Pages.AWS;

public class QuizModel : PageModel
{
    private readonly QuizService _quizService;

    public QuizModel(QuizService quizService)
    {
        _quizService = quizService;
    }

    [BindProperty]
    public string Topic { get; set; } = "AWS";

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
            Questions = GetAWSQuestions();
        }
        IsSubmitted = false;
    }

    public IActionResult OnPost()
    {
        IsSubmitted = true;
        Questions = _quizService.GetQuizQuestions(Topic);
        if (Questions.Count == 0)
        {
            Questions = GetAWSQuestions();
        }
        Result = _quizService.EvaluateQuiz(Questions, Answers);
        return Page();
    }

    private List<QuizQuestion> GetAWSQuestions()
    {
        return new List<QuizQuestion>
        {
            // ===== GETTING STARTED (Questions 1-5) =====
            new QuizQuestion
            {
                Id = 1,
                Topic = Topic,
                Question = "What does AWS stand for?",
                Options = new List<string>
                {
                    "Amazon Web Services",
                    "Advanced Web Solutions",
                    "Automated Web Systems",
                    "Amazon Worldwide Services"
                },
                CorrectAnswer = 0,
                Explanation = "AWS stands for Amazon Web Services. It is Amazon's cloud computing platform."
            },
            new QuizQuestion
            {
                Id = 2,
                Topic = Topic,
                Question = "How many hours of free EC2 server do you get each month?",
                Options = new List<string>
                {
                    "100 hours",
                    "500 hours",
                    "750 hours",
                    "1000 hours"
                },
                CorrectAnswer = 2,
                Explanation = "AWS gives you 750 hours of t2.micro or t3.micro server for free every month for 12 months."
            },
            new QuizQuestion
            {
                Id = 3,
                Topic = Topic,
                Question = "What should you do after testing to avoid paying money?",
                Options = new List<string>
                {
                    "Stop the server",
                    "Pause the server",
                    "Terminate (delete) the server",
                    "Restart the server"
                },
                CorrectAnswer = 2,
                Explanation = "Always TERMINATE (delete) your servers when done testing. Stopping keeps the hard drive active and costs money."
            },
            new QuizQuestion
            {
                Id = 4,
                Topic = Topic,
                Question = "How long does the AWS Free Tier last?",
                Options = new List<string>
                {
                    "3 months",
                    "6 months",
                    "12 months",
                    "24 months"
                },
                CorrectAnswer = 2,
                Explanation = "The AWS Free Tier lasts for 12 months from the day you create your account."
            },
            new QuizQuestion
            {
                Id = 5,
                Topic = Topic,
                Question = "What is a Billing Alarm used for?",
                Options = new List<string>
                {
                    "To make your bill bigger",
                    "To notify you when your bill goes over a set amount",
                    "To pay your bill automatically",
                    "To cancel your account"
                },
                CorrectAnswer = 1,
                Explanation = "A Billing Alarm sends you an email if your bill goes over a set amount (like $1). This is your safety net!"
            },

            // ===== EC2 (Questions 6-10) =====
            new QuizQuestion
            {
                Id = 6,
                Topic = Topic,
                Question = "What does EC2 stand for?",
                Options = new List<string>
                {
                    "Elastic Compute Cloud",
                    "Elastic Cloud Compute",
                    "Elastic Container Cloud",
                    "Enterprise Compute Cloud"
                },
                CorrectAnswer = 0,
                Explanation = "EC2 stands for Elastic Compute Cloud. It is Amazon's virtual server service."
            },
            new QuizQuestion
            {
                Id = 7,
                Topic = Topic,
                Question = "What is the free tier EC2 server type called?",
                Options = new List<string>
                {
                    "t2.large",
                    "t2.micro",
                    "t3.medium",
                    "t2.small"
                },
                CorrectAnswer = 1,
                Explanation = "t2.micro (or t3.micro) is the free tier EC2 server type. It has 1 vCPU and 1GB of RAM."
            },
            new QuizQuestion
            {
                Id = 8,
                Topic = Topic,
                Question = "What is a Key Pair used for in EC2?",
                Options = new List<string>
                {
                    "To unlock your server",
                    "To change your password",
                    "To login to your server",
                    "To delete your server"
                },
                CorrectAnswer = 2,
                Explanation = "A Key Pair is like a password file that lets you login to your EC2 server. Keep it safe!"
            },
            new QuizQuestion
            {
                Id = 9,
                Topic = Topic,
                Question = "What is an AMI in EC2?",
                Options = new List<string>
                {
                    "A type of server",
                    "The operating system template for your server",
                    "A storage device",
                    "A network setting"
                },
                CorrectAnswer = 1,
                Explanation = "AMI (Amazon Machine Image) is the template that contains the operating system for your server."
            },
            new QuizQuestion
            {
                Id = 10,
                Topic = Topic,
                Question = "How do you connect to your EC2 server?",
                Options = new List<string>
                {
                    "Using the Connect button in the AWS console",
                    "Using a web browser",
                    "Using a mobile app",
                    "Using a text message"
                },
                CorrectAnswer = 0,
                Explanation = "You can connect to your EC2 server using the Connect button in the AWS console, which opens a terminal window."
            },

            // ===== S3 (Questions 11-15) =====
            new QuizQuestion
            {
                Id = 11,
                Topic = Topic,
                Question = "What is S3 used for?",
                Options = new List<string>
                {
                    "Running virtual servers",
                    "Storing files in the cloud",
                    "Running code",
                    "Managing databases"
                },
                CorrectAnswer = 1,
                Explanation = "S3 (Simple Storage Service) is used for storing files like photos, videos, and documents in the cloud."
            },
            new QuizQuestion
            {
                Id = 12,
                Topic = Topic,
                Question = "How much free storage do you get with S3?",
                Options = new List<string>
                {
                    "1 GB",
                    "5 GB",
                    "10 GB",
                    "100 GB"
                },
                CorrectAnswer = 1,
                Explanation = "AWS gives you 5 GB of free storage in S3 for 12 months."
            },
            new QuizQuestion
            {
                Id = 13,
                Topic = Topic,
                Question = "What is a Bucket in S3?",
                Options = new List<string>
                {
                    "A container for your files",
                    "A type of server",
                    "A database",
                    "A network setting"
                },
                CorrectAnswer = 0,
                Explanation = "A Bucket is like a folder where you store your files in S3. Every bucket name must be unique worldwide."
            },
            new QuizQuestion
            {
                Id = 14,
                Topic = Topic,
                Question = "What happens when you make a file public in S3?",
                Options = new List<string>
                {
                    "Anyone can see it",
                    "Only you can see it",
                    "It gets deleted",
                    "It moves to another folder"
                },
                CorrectAnswer = 0,
                Explanation = "When you make a file public in S3, anyone with the link can view it. This is how you share files online."
            },
            new QuizQuestion
            {
                Id = 15,
                Topic = Topic,
                Question = "Can you host a website using S3?",
                Options = new List<string>
                {
                    "Yes, S3 can host static websites",
                    "No, S3 cannot host websites",
                    "Only if you pay extra",
                    "Only with a special plugin"
                },
                CorrectAnswer = 0,
                Explanation = "Yes! S3 can host static websites (HTML, CSS, JavaScript) for free."
            },

            // ===== LAMBDA (Questions 16-20) =====
            new QuizQuestion
            {
                Id = 16,
                Topic = Topic,
                Question = "What is Lambda used for?",
                Options = new List<string>
                {
                    "Running virtual servers",
                    "Running code without servers",
                    "Storing files",
                    "Managing databases"
                },
                CorrectAnswer = 1,
                Explanation = "Lambda lets you run code without managing any servers. Just upload your code and AWS runs it!"
            },
            new QuizQuestion
            {
                Id = 17,
                Topic = Topic,
                Question = "How many free Lambda requests do you get each month?",
                Options = new List<string>
                {
                    "100,000 requests",
                    "500,000 requests",
                    "1,000,000 requests",
                    "10,000,000 requests"
                },
                CorrectAnswer = 2,
                Explanation = "AWS gives you 1 million Lambda requests for free every month. This is always free!"
            },
            new QuizQuestion
            {
                Id = 18,
                Topic = Topic,
                Question = "Which programming languages can you use with Lambda?",
                Options = new List<string>
                {
                    "Only Python",
                    "Only JavaScript",
                    "Python, Node.js, C#, Java, and more",
                    "Only C#"
                },
                CorrectAnswer = 2,
                Explanation = "Lambda supports many languages including Python, Node.js, C#, Java, Go, Ruby, and PHP."
            },
            new QuizQuestion
            {
                Id = 19,
                Topic = Topic,
                Question = "What is a Lambda Trigger?",
                Options = new List<string>
                {
                    "A button that starts your function",
                    "An event that makes your function run",
                    "A type of server",
                    "A storage service"
                },
                CorrectAnswer = 1,
                Explanation = "A Trigger is an event that makes your Lambda function run. For example, when a file is uploaded to S3."
            },
            new QuizQuestion
            {
                Id = 20,
                Topic = Topic,
                Question = "Can Lambda functions use C#?",
                Options = new List<string>
                {
                    "Yes, Lambda supports C# (.NET 6 and 8)",
                    "No, Lambda only supports Python",
                    "Only if you pay extra",
                    "Only C# 4.0"
                },
                CorrectAnswer = 0,
                Explanation = "Yes! Lambda fully supports C# with .NET 6 and .NET 8. You can write your functions in C#."
            },

            // ===== NETWORKING (Questions 21-25) =====
            new QuizQuestion
            {
                Id = 21,
                Topic = Topic,
                Question = "What is a VPC in AWS?",
                Options = new List<string>
                {
                    "Virtual Private Cloud - your private network",
                    "Virtual Public Cloud",
                    "Virtual Private Computer",
                    "Virtual Public Computer"
                },
                CorrectAnswer = 0,
                Explanation = "VPC (Virtual Private Cloud) is your own private network inside AWS where you can put your servers."
            },
            new QuizQuestion
            {
                Id = 22,
                Topic = Topic,
                Question = "What is a Subnet in a VPC?",
                Options = new List<string>
                {
                    "A type of server",
                    "A part of your VPC where you put resources",
                    "A storage device",
                    "A security setting"
                },
                CorrectAnswer = 1,
                Explanation = "A Subnet is a section of your VPC. You put your resources (like EC2 servers) inside subnets."
            },
            new QuizQuestion
            {
                Id = 23,
                Topic = Topic,
                Question = "What is the difference between a Public and Private Subnet?",
                Options = new List<string>
                {
                    "Public subnets have internet access, private ones don't",
                    "Private subnets have internet access, public ones don't",
                    "They are the same",
                    "Public subnets are more expensive"
                },
                CorrectAnswer = 0,
                Explanation = "Public subnets connect to the internet through an Internet Gateway. Private subnets do not have direct internet access."
            },
            new QuizQuestion
            {
                Id = 24,
                Topic = Topic,
                Question = "What is a Security Group used for?",
                Options = new List<string>
                {
                    "To group servers together",
                    "A firewall that controls traffic to your servers",
                    "A storage service",
                    "A database service"
                },
                CorrectAnswer = 1,
                Explanation = "A Security Group is like a firewall. It controls what traffic can go in and out of your EC2 servers."
            },
            new QuizQuestion
            {
                Id = 25,
                Topic = Topic,
                Question = "What is an Internet Gateway?",
                Options = new List<string>
                {
                    "A type of server",
                    "A storage device",
                    "A door that connects your VPC to the internet",
                    "A database"
                },
                CorrectAnswer = 2,
                Explanation = "An Internet Gateway is like a door that connects your VPC to the internet so your servers can be accessed online."
            },

            // ===== DATABASES (Questions 26-30) =====
            new QuizQuestion
            {
                Id = 26,
                Topic = Topic,
                Question = "What is RDS used for?",
                Options = new List<string>
                {
                    "Running virtual servers",
                    "Managing relational databases",
                    "Storing files",
                    "Running code"
                },
                CorrectAnswer = 1,
                Explanation = "RDS (Relational Database Service) is used to manage relational databases like MySQL, PostgreSQL, and SQL Server."
            },
            new QuizQuestion
            {
                Id = 27,
                Topic = Topic,
                Question = "What is the difference between RDS and DynamoDB?",
                Options = new List<string>
                {
                    "RDS is relational, DynamoDB is NoSQL",
                    "They are the same",
                    "RDS is faster",
                    "DynamoDB is for storing files"
                },
                CorrectAnswer = 0,
                Explanation = "RDS is for relational databases (tables with rows and columns). DynamoDB is NoSQL (flexible, key-value storage)."
            },
            new QuizQuestion
            {
                Id = 28,
                Topic = Topic,
                Question = "What is a free tier option for RDS?",
                Options = new List<string>
                {
                    "db.t2.micro",
                    "db.t2.large",
                    "db.t3.medium",
                    "db.t2.small"
                },
                CorrectAnswer = 0,
                Explanation = "db.t2.micro is the free tier option for RDS. It gives you 750 hours per month for 12 months."
            },
            new QuizQuestion
            {
                Id = 29,
                Topic = Topic,
                Question = "What is DynamoDB used for?",
                Options = new List<string>
                {
                    "Relational databases",
                    "NoSQL databases that scale automatically",
                    "Storing files",
                    "Running code"
                },
                CorrectAnswer = 1,
                Explanation = "DynamoDB is a NoSQL database that scales automatically to handle any amount of traffic."
            },
            new QuizQuestion
            {
                Id = 30,
                Topic = Topic,
                Question = "How much free storage does DynamoDB give you?",
                Options = new List<string>
                {
                    "5 GB",
                    "10 GB",
                    "25 GB",
                    "50 GB"
                },
                CorrectAnswer = 2,
                Explanation = "DynamoDB gives you 25 GB of free storage forever, not just for 12 months!"
            },

            // ===== SECURITY & IAM (Questions 31-35) =====
            new QuizQuestion
            {
                Id = 31,
                Topic = Topic,
                Question = "What is IAM used for?",
                Options = new List<string>
                {
                    "Running servers",
                    "Managing who can access your AWS resources",
                    "Storing data",
                    "Running code"
                },
                CorrectAnswer = 1,
                Explanation = "IAM (Identity and Access Management) controls who can access your AWS resources and what they can do."
            },
            new QuizQuestion
            {
                Id = 32,
                Topic = Topic,
                Question = "What is the principle of least privilege?",
                Options = new List<string>
                {
                    "Give everyone full access",
                    "Give only the permissions people need",
                    "Give no permissions at all",
                    "Give permissions based on job title"
                },
                CorrectAnswer = 1,
                Explanation = "The principle of least privilege means giving people only the permissions they need, and nothing more."
            },
            new QuizQuestion
            {
                Id = 33,
                Topic = Topic,
                Question = "What is an IAM Role used for?",
                Options = new List<string>
                {
                    "For user accounts",
                    "For AWS services to get permissions",
                    "For storing passwords",
                    "For file storage"
                },
                CorrectAnswer = 1,
                Explanation = "IAM Roles give permissions to AWS services. For example, an EC2 server can use a role to access S3."
            },
            new QuizQuestion
            {
                Id = 34,
                Topic = Topic,
                Question = "What is MFA in AWS?",
                Options = new List<string>
                {
                    "Multi-Factor Authentication - extra security",
                    "Main File Access",
                    "Manual Form Approval",
                    "Mobile Feature Access"
                },
                CorrectAnswer = 0,
                Explanation = "MFA (Multi-Factor Authentication) adds extra security by requiring a code from your phone to login."
            },
            new QuizQuestion
            {
                Id = 35,
                Topic = Topic,
                Question = "Why should you never store AWS keys in your code?",
                Options = new List<string>
                {
                    "It makes your code slower",
                    "It's a security risk",
                    "It costs more money",
                    "It doesn't work"
                },
                CorrectAnswer = 1,
                Explanation = "Storing AWS keys in your code is a big security risk. Use IAM Roles instead."
            },

            // ===== DEPLOYMENT (Questions 36-40) =====
            new QuizQuestion
            {
                Id = 36,
                Topic = Topic,
                Question = "What is CI/CD?",
                Options = new List<string>
                {
                    "Continuous Integration / Continuous Deployment",
                    "Computer Integration / Computer Deployment",
                    "Code Implementation / Code Delivery",
                    "Continuous Improvement / Continuous Delivery"
                },
                CorrectAnswer = 0,
                Explanation = "CI/CD stands for Continuous Integration / Continuous Deployment. It automates testing and deploying your code."
            },
            new QuizQuestion
            {
                Id = 37,
                Topic = Topic,
                Question = "What is Blue/Green Deployment?",
                Options = new List<string>
                {
                    "Deploying to two environments with zero downtime",
                    "Deploying to one environment",
                    "Deploying only during business hours",
                    "Deploying using only blue colors"
                },
                CorrectAnswer = 0,
                Explanation = "Blue/Green Deployment uses two environments. You deploy to one (Blue) while the other (Green) is live, then switch."
            },
            new QuizQuestion
            {
                Id = 38,
                Topic = Topic,
                Question = "What is a Canary Deployment?",
                Options = new List<string>
                {
                    "Deploying all at once",
                    "Gradually rolling out to a small group first",
                    "Deploying only to test environment",
                    "Deploying without testing"
                },
                CorrectAnswer = 1,
                Explanation = "Canary Deployment rolls out changes to a small group of users first. If it works, you roll out to everyone."
            },
            new QuizQuestion
            {
                Id = 39,
                Topic = Topic,
                Question = "What is the easiest way to deploy a .NET app to AWS?",
                Options = new List<string>
                {
                    "Copy files manually",
                    "Use AWS Elastic Beanstalk",
                    "Email the files",
                    "Use FTP"
                },
                CorrectAnswer = 1,
                Explanation = "Elastic Beanstalk is the easiest way to deploy .NET apps to AWS. It handles everything for you."
            },
            new QuizQuestion
            {
                Id = 40,
                Topic = Topic,
                Question = "What should you always do after testing on AWS?",
                Options = new List<string>
                {
                    "Take a screenshot",
                    "Terminate all resources",
                    "Share your account",
                    "Leave everything running"
                },
                CorrectAnswer = 1,
                Explanation = "Always terminate (delete) all resources after testing to avoid unexpected charges on your bill."
            }
        };
    }
}