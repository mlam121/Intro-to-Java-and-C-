int score = 0;
int gamesPlayed = 0;
int highestScore = 0;

string playAgain = "Y";

// Questions and answers are stored in arrays
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

    // Question order
int[] order = { 0, 1, 2, 3, 4 };

Random random = new Random();

// Randomize the questions
for (int i = 0; i < order.Length; i++)
{
    int randomNumber = random.Next(i, order.Length);

    int temp = order[i];
    order[i] = order[randomNumber];
    order[randomNumber] = temp;
}


    Console.WriteLine("Welcome to the Quiz Game!");
    Console.WriteLine();

    // Ask all of the questions
    for (int i = 0; i < questions.Length; i++)
    {
        int questionNumber = order[i];

        Console.WriteLine(questions[questionNumber]);

        string userAnswer = Console.ReadLine() ?? "";

        if (userAnswer.Equals(answers[questionNumber], StringComparison.OrdinalIgnoreCase))
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

    // Score Display
    Console.WriteLine("Final Score: " + score);

    // Switch statement
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

    // Track played games
    gamesPlayed++;

    // Track highest score
    if (score > highestScore)
    {
        highestScore = score;
    }

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

    }
    while (!playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
        !playAgain.Equals("N", StringComparison.OrdinalIgnoreCase));
}

// Final Summary
Console.WriteLine();
Console.WriteLine("Games Played: " + gamesPlayed);
Console.WriteLine("Highest Score: " + highestScore);
Console.WriteLine("Thanks for playing!");
