Console.WriteLine("Welcome to Streamfix Subscription Calculator!");

Console.WriteLine();


//User input
Console.Write("Enter your name: ");
String name = Console.ReadLine();


//age input
Console.Write("Enter your age: ");

int age;

try
{
    age = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Error: Please enter a valid whole number for age.");
    return;
}

//subscription plan input
Console.Write("Enter your subscription plan (B = Basic, S = Standard, P = Premium): ");
String plan = Console.ReadLine();

   switch (plan)
        {
            case "B":
                originalPrice = 8.99;
                planName = "Basic";
                break;

            case "S":
                originalPrice = 12.99;
                planName = "Standard";
                break;

            case "P":
                originalPrice = 16.99;
                planName = "Premium";
                break;

            default:
                Console.WriteLine("Error: Invalid subscription plan.");
                return;
        }



Console.Write("Enter student status (Y = yes, N = no): ");
String studentStatus = Console.ReadLine();