import java.util.Scanner;

public class ComputerOrder {
    public static void main(String[] args) {

        Scanner keyboard = new Scanner(System.in);

String firstName;
String lastName;
String fullName;

char firstInitial;
char lastInitial;

int orderNumber;

String computerModel1;
double price;
int quantity;

final double SALES_TAX_RATE = 0.0825;


System.out.print("Enter your first name: ");
firstName = keyboard.nextLine();

System.out.print("Enter your last name: ");
lastName = keyboard.nextLine();

fullName = firstName + " " + lastName;
System.out.println("Your full name is " + fullName);

firstInitial = firstName.charAt(0);
lastInitial = lastName.charAt(0);

System.out.println();

System.out.println("Enter your computer model: ");
computerModel1 = keyboard.nextLine();

System.out.println("Enter the price: ");
price = keyboard.nextDouble();

System.out.println("Enter the quantity: ");
quantity = keyboard.nextInt();



    }
}
