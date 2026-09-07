import java.util.Scanner;

public class ComputerOrder {
    public static void main(String[] args) {

        Scanner keyboard = new Scanner(System.in);

String firstName;
String lastName;
String fullName;

char firstInitial;
char lastInitial;

String orderNumber;

String computerModel1;
double price;
int quantity;

double subTotal;
double salesTax;
double totalCost;
int WDsubTotal;

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

WDsubTotal = (int)subTotal;

orderNumber = (firstInitial + "" + lastInitial) + "-" + quantity + "-" + WDsubTotal;

loyaltyPoints = (int)totalCost;


        //Purchase Summary
        System.out.println("Purchase Summary");
        System.out.println("---------------------");

System.out.println();

        System.out.println("Customer: " + fullName);
        System.out.println("Order Number: " + orderNumber);

System.out.println();

        System.out.println("Computer Model: " + computerModel1);
        System.out.println("Price Each: $" + price);
        System.out.println("Quantity: " + quantity);

System.out.println();

        System.out.println("Subtotal: $" + subTotal);
        System.out.println("Sales Tax: $" + salesTax);
        System.out.println("Total Cost: $" + totalCost);

System.out.println();

        System.out.println("Loyalty Points Earned: " + loyaltyPoints);

    }
}
