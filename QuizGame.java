import java.util.Scanner;

public class QuizGame
{
    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);

        int score = 0;

        System.out.println("Welcome to the Quiz Game!");
        System.out.println();


// Question 1
        System.out.println("How many days are in a week?");
        int answer1;

        try
        {
            answer1 = Integer.parseInt(keyboard.nextLine());

            if (answer1 == 7)
            {
                System.out.println("Correct!");
                score++;
            }
            else
            {
                System.out.println("Incorrect.");
            }
        }
catch (NumberFormatException e)
{
    System.out.println("Incorrect");
}


        // Question 2
        System.out.println();
        System.out.println("What is the value of PI rounded to two decimal places?");
        double answer2 = Double.parseDouble(keyboard.nextLine());

        if (answer2 == 3.14)
        {
            System.out.println("Correct!");
            score++;
        }
        else
        {
            System.out.println("Incorrect.");
        }


        // Question 3
        System.out.println();
        System.out.println("Name one programming language we are learning in this course:");
        String answer3 = keyboard.nextLine();

        if (answer3.equalsIgnoreCase("Java") || answer3.equalsIgnoreCase("C#"))
        {
            System.out.println("Correct!");
            score++;
        }
        else
        {
            System.out.println("Incorrect.");
        }


        System.out.println();
        System.out.println("Final Score: " + score + "/3");

        switch (score)
        {
            case 3:
                System.out.println("Quiz Master!");
                break;

            case 2:
                System.out.println("Great Job!");
                break;

            case 1:
                System.out.println("Keep Practicing!");
                break;

            case 0:
                System.out.println("Let's Study More!");
                break;
        }

        keyboard.close();
    }
}
