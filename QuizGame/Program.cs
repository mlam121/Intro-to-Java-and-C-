int score = 0;

Console.WriteLine("Welcome to the Quiz Game!");
Console.WriteLine();

// Question 1
Console.WriteLine("How many days are in a week?");

int answer1;

try
{
    answer1 = int.Parse(Console.ReadLine());

    if (answer1 == 7)
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Incorrect");
}

// Question 2
Console.WriteLine("What is the value of PI rounded to two decimal places?");

double answer2 = double.Parse(Console.ReadLine());

if (answer2 == 3.14)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}

// Question 3
Console.WriteLine("Name one programming language we are learning in this course.");

string answer3 = Console.ReadLine();

if (answer3.Equals("C#", StringComparison.OrdinalIgnoreCase) || answer3.Equals("Java", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}
//Score Display
Console.WriteLine();
Console.WriteLine("Final Score: " + score);

//Switch statement
switch (score)
{
    case 3:
        Console.WriteLine("Quiz Master!");
        break;
    case 2:
        Console.WriteLine("Great Job!");
        break;
    case 1:
        Console.WriteLine("Keep Practicing!");
        break;
    default:
        Console.WriteLine("Let's Study More!");
        break;
}