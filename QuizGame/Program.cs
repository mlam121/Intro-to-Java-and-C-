int score = 0;
int gamesPlayed = 0;
int highestScore = 0;

string playAgain = "Y";

while (playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase))
{

score = 0;

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

//Question 4
Console.WriteLine("Riddle:  What has a head and a tail, but no body?");

string answer4 = Console.ReadLine();
if (answer4.Equals("Coin", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}


//Question 5
Console.WriteLine("Riddle: I act like a cat, I look like a cat. Yet, I am not a cat. What am I?");

string answer5 = Console.ReadLine();
if(answer5.Equals("Kitten", StringComparison.OrdinalIgnoreCase))
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

//Track played games
gamesPlayed++;

//highest score
if (score > highestScore)
    {
        highestScore = score;
    }

//play again
do
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to play again? (Y/N)");
        playAgain = Console.ReadLine();

        if (!playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
            !playAgain.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Invalid input. Please enter Y or N.");
        }

    } 
    while (!playAgain.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
            !playAgain.Equals("N", StringComparison.OrdinalIgnoreCase));
}

//Final Sumamry
Console.WriteLine();
Console.WriteLine("Games Played: " + gamesPlayed);
Console.WriteLine("Highest Score: " + highestScore);
Console.WriteLine("Thanks for playing!");