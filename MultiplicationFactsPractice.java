import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class MultiplicationFactsPractice {    public static void main(String[] args) {
        final int NUM_QUESTIONS = 10;

        Random rand = new Random();
        Scanner input = new Scanner(System.in);

        int[] firstFactor = new int[NUM_QUESTIONS];
        int[] secondFactor = new int[NUM_QUESTIONS];
        int[] correctAnswers = new int[NUM_QUESTIONS];
        int[] userAnswers = new int[NUM_QUESTIONS];

        ArrayList<Integer> missedQuestions = new ArrayList<Integer>();

        for (int i = 0; i < NUM_QUESTIONS; i++) {

            firstFactor[i] = rand.nextInt(15) + 1;
            secondFactor[i] = rand.nextInt(15) + 1;
            correctAnswers[i] = firstFactor[i] * secondFactor[i];

            System.out.print(firstFactor[i] + " x " + secondFactor[i] + " = ");
            userAnswers[i] = input.nextInt();

            if (userAnswers[i] != correctAnswers[i]) {
                missedQuestions.add(i);
            }
        }

        int correct = NUM_QUESTIONS - missedQuestions.size();

        System.out.println("You got " + correct + " out of " + NUM_QUESTIONS + " correct.");

        if (missedQuestions.size() > 0) {
            System.out.println("Let's try the missed questions again.");

            for (int i = 0; i < missedQuestions.size(); i++) {
                int question = missedQuestions.get(i);
                System.out.print(firstFactor[question] + " x "
                        + secondFactor[question] + " = ");

                int answer = input.nextInt();

                if (answer == correctAnswers[question]) {
                    System.out.println("Correct!");
                } else {
                    System.out.println("The correct answer is "
                        + correctAnswers[question]);
                }
            }
    } 
        else
        {
            System.out.println("Great job! You got them all correct!");
        }

        input.close();
        
    }
}
