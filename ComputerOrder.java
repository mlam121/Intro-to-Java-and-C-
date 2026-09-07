import java.util.Scanner;

public class ComputerOrder {
    public static void main(String[] args) {

        Scanner keyboard = new Scanner(System.in);

String firstName;
String lastName;
String fullName;

char firstInitial;
char lastInitial;

String computerModel1;
double price;
int quantity;

String orderNumber;

double subTotal;
double salesTax;
double totalCost;

int loyaltyPoints;


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

System.out.print("Enter your computer model: ");
computerModel1 = keyboard.nextLine();

System.out.print("Enter the price: ");
price = keyboard.nextDouble();

System.out.print("Enter the quantity: ");
quantity = keyboard.nextInt();

System.out.println();

subTotal = price * quantity;
salesTax = subTotal * SALES_TAX_RATE;
totalCost = subTotal + salesTax;


orderNumber = (firstInitial + "" + lastInitial) + "-" + quantity + "-" + (int)subTotal;

loyaltyPoints = (int)totalCost;


        //Purchase Summary
        System.out.println("Purchase Summary");
        System.out.println("---------------------");

System.out.println();

        System.out.println("Customer: " + fullName);
        System.out.println("Order Number: " + orderNumber);

System.out.println();

        System.out.println("Computer Model: " + computerModel1);
        System.out.printf("Price Each: $%.2f%n", price);
        System.out.println("Quantity: " + quantity);

System.out.println();

        System.out.printf("Subtotal: $%.2f%n", subTotal);
        System.out.printf("Sales Tax: $%.2f%n", salesTax);
        System.out.printf("Total Cost: $%.2f%n", totalCost);


System.out.println();

        System.out.println("Loyalty Points Earned: " + loyaltyPoints);

    }
}
