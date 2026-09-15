import java.util.Scanner;
import java.util.Random;

public class NumberGuessingGame {
    public static void main(String[] args) {
        
        Random random = new Random();
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter a number between 1 and 100: ");
        int guess = scanner.nextInt();

        int answer = random.nextInt(100) + 1;
        int guessCount = 1;

        while (guess != answer) {
            if (guess > answer) {
                System.out.println("Too high!");
            } 
            else if (guess < answer) {
                System.out.println("Too low!");
            }
            System.out.println("Enter another guess: ");
            guess = scanner.nextInt();

            guessCount++;
        }

        System.out.println("Congratulations! You guessed the number.");
        System.out.println("Number of guesses: " + guessCount);

        scanner.close();

    } 
}
