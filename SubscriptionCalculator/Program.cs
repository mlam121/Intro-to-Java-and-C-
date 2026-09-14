Console.Write("Welcome to Streamfix! Subscription Calculator");

//User input
Console.Write("Enter your name: ");
String name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

try-catch block to handle invalid input for age
try
{
    Console.Write("Enter your age: ");
    age = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
    return;
}



Console.Write("Enter your subscription plan (B = Basic, S = Standard, P = Premium): ");
String plan = Console.ReadLine();

Console.Write("Enter student status (Y = yes, N = no): ");
String studentStatus = Console.ReadLine();

