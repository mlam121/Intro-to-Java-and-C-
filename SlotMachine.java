import java.util.Random;

public class SlotMachine {
    public static void main(String[] args) {
        Random random = new Random();

        String[] fruits = {"Cherry", "Orange", "Lemon"};
        String[] results = new String[3];

        for (int i = 0; i < 3; i++) {
            int number = random.nextInt(3);

            results[i] = fruits[number];
            System.out.print(results[i] + " ");
        }

        System.out.println();

         if (results[0].equals(results[1]) && results[1].equals(results[2])) {
            System.out.println("Jackpot!");
        }
        else if (results[0].equals(results[1]) ||
                   results[0].equals(results[2]) ||
                   results[1].equals(results[2])) {
            System.out.println("Small Prize!");
        }
        else {
            System.out.println("Try Again!");
        }
    }
}
