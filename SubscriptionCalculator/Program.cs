Console.WriteLine("Welcome to StreamFlix Subscription Calculator!");

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();


//AGE
Console.WriteLine("Enter your age: ");
int age;

try 
{
    age = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid age.");
    return;
}

//SWITCH CASE FOR SUBSCRIPTION PLAN
Console.WriteLine("Enter your subscription plan (B = Basic, S = Standard, P = Premium): ");
string plan = Console.ReadLine();
double originalPrice;


switch (plan)
{
    case "B":
        originalPrice = 8.99;
        Console.WriteLine("Basic(B) Monthly Price: $8.99");
        break;
    case "S":
        originalPrice = 12.99;
        Console.WriteLine("Standard(S) Monthly Price: $12.99");
        break;
    case "P":
        originalPrice = 16.99;
        Console.WriteLine("Premium(P) Monthly Price: $16.99");
        break;
    default:
        Console.WriteLine("Invalid subscription plan. Please enter B, S, or P.");
        return;
}

Console.WriteLine("Student Status (Y = Yes, N = No): ");
string studentStatus = Console.ReadLine();

//DISCOUNTS
double discountRate;

if (age >= 65)
{
    discountRate = 0.15;
}
else if (studentStatus == "Y")
{
    discountRate = 0.10;
}
else if (age >= 65 && studentStatus == "Y")
{
    discountRate = 0.15;
}
else
{
    discountRate = 0.0;
}

double discountAmount = originalPrice * discountRate;

double finalPrice = originalPrice - discountAmount;


//PREMIUM
if (plan == "P" && age >= 18)
{
    Console.WriteLine("You are qualified for Premium Benefits Program!");
}


//SUMMARY
Console.WriteLine("Subscription Summary");
Console.WriteLine("---------------------");

Console.WriteLine("Name: " + name);
Console.WriteLine("Subscription Plan: " + plan);
Console.WriteLine("Original Price: " + originalPrice);
Console.WriteLine("Discount: " + discountAmount);
Console.WriteLine("Final Price: " + finalPrice);