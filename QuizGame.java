import java.io.Console;
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
        String answer1 = keyboard.nextLine();
        if (answer1.equalsIgnoreCase("7")) {
            score++;
        }
        else {
            System.out.println("Incorrect.");
        }


        try
        {
            answer1 = Integer.parseInt(keyboard.nextLine());
        }
        catch (NumberFormatException)
        {
            System.out.println("Incorrect");
            return;
        }

        // Question 2
        System.out.println();
        System.out.println("What is the value of PI rounded to two decimal places?");
        String answer2 = keyboard.nextLine();
        if (answer2.equalsIgnoreCase("3.14")) {
            score++;
        }
        else {
            System.out.println("Incorrect.");
            return;
        }

        // Question 3
        System.out.println();
        System.out.println("Name one programming language we are learning in this course:");
        String answer3 = keyboard.nextLine();

        if (answer3.equalsIgnoreCase("Java or C#") || answer3.equalsIgnoreCase("C# or Java")) {
            score++;
        }
        else {
            System.out.println("Incorrect.");
            return;
        }



        System.out.println();
        System.out.println("Final Score: " + score);

        keyboard.close();
    }
}
