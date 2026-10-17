using System;
using System.IO;

int score = 0;
int gamesPlayed = 0;
int highestScore = 0;
string playAgain = "Y";

// Questions and answers
string[] questions =
{
    "How many days are in a week?",
    "What is the value of PI rounded to two decimal places?",
    "Name one programming language we are learning in this course.",
    "Riddle: What has a head and a tail, but no body?",
    "Riddle: I act like a cat, I look like a cat. Yet, I am not a cat. What am I?"
};

string[] answers =
{
    "7",
    "3.14",
    "C#",
    "Coin",
    "Kitten"
};

while (playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase))
{
    score = 0;

    int[] order = { 0, 1, 2, 3, 4 };
    Random random = new Random();

    // Randomize questions
    for (int i = 0; i < order.Length; i++)
    {
        int randomNumber = random.Next(i, order.Length);
        int temp = order[i];
        order[i] = order[randomNumber];
        order[randomNumber] = temp;
    }

    // Method 1
    DisplayWelcome();

    // Ask questions
    for (int i = 0; i < questions.Length; i++)
    {
        int questionNumber = order[i];

        Console.WriteLine(questions[questionNumber]);

        string userAnswer = Console.ReadLine() ?? "";

        if (userAnswer.Equals(
            answers[questionNumber], StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else if (questionNumber == 2 &&
                userAnswer.Equals("Java", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }

        Console.WriteLine();
    }

    // Method 2
    DisplayScore(score);

    // Switch
    switch (score)
    {
        case 5:
            Console.WriteLine("Quiz Master!");
            break;

        case 4:
            Console.WriteLine("Great Job!");
            break;

        case 3:
            Console.WriteLine("Great Job!");
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

    gamesPlayed++;

    // Track highest score
    if (score > highestScore)
    {
        highestScore = score;
    }

    // Save results
    SaveResults(score, gamesPlayed, highestScore);

    string viewChoice;

    do
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to view saved quiz results? (Y/N)");

        viewChoice = Console.ReadLine() ?? "";

        if (viewChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            DisplayResults();
            break;
        }
        else if (viewChoice.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter Y or N.");
        }

    } while (true);

// Play again
    do
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to play again? (Y/N)");

        playAgain = Console.ReadLine() ?? "";

        if (!playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
            !playAgain.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Invalid input. Please enter Y or N.");
        }

    } while (!playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
            !playAgain.Equals("N", StringComparison.OrdinalIgnoreCase));
}

// Summary
Console.WriteLine();

Console.WriteLine("Games Played: " + gamesPlayed);
Console.WriteLine("Highest Score: " + highestScore);
Console.WriteLine("Thanks for playing!");

// Method 1
static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the Quiz Game!");
    Console.WriteLine();
}

// Method 2
static void DisplayScore(int score)
{
    Console.WriteLine("Final Score: " + score);
}

// Method 3
static void SaveResults(int score, int gamesPlayed, int highestScore)
{
    try
    {
        string result =
            "Game " + gamesPlayed + Environment.NewLine +
            "Final Score: " + score + "/5" + Environment.NewLine +
            "Games Played: " + gamesPlayed + Environment.NewLine +
            "Highest Score: " + highestScore + Environment.NewLine +
            Environment.NewLine;

        File.AppendAllText("quiz_results.txt", result);

        Console.WriteLine("Quiz results saved.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("Error: You do not have permission to save quiz results.");
    }
    catch (IOException)
    {
        Console.WriteLine("Error: Could not save quiz results.");
    }
}

// Method 4
static void DisplayResults()
{
    try
    {
        string contents = File.ReadAllText("quiz_results.txt");

        Console.WriteLine();
        Console.WriteLine("--- Saved Quiz Results ---");
        Console.WriteLine();
        Console.WriteLine(contents);
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("No saved quiz results were found.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("You do not have permission to read quiz results.");
    }
    catch (IOException)
    {
        Console.WriteLine("Error: Could not read quiz results.");
    }
}