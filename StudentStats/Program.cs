Console.Write("Enter first name: ");
String firstName = Console.ReadLine();

Console.Write("Enter last name: ");
String lastName = Console.ReadLine();

string fullName = firstName + " " + lastName;

Console.Write("Enter your exam 1 score: ");
int exam1 = int.Parse(Console.ReadLine());
Console.Write("Enter your exam 2 score: ");
int exam2 = int.Parse(Console.ReadLine());
Console.Write("Enter your exam 3 score: ");
int exam3 = int.Parse(Console.ReadLine());


const double TAX_RATE = 0.0825;

Console.Write("Enter the price of the textbook: ");
double textbookPrice = double.Parse(Console.ReadLine());

double salesTax = textbookPrice * TAX_RATE;
double totalCost = textbookPrice + salesTax;


double studyHours = 7.8;

const double PARTICIPATION_WEIGHT = 0.20;

double average = (exam1 + exam2 + exam3) / 3.0;

int wholeHours = (int)studyHours;

double participationGrade = 100;

double finalGrade = average * 0.80 + participationGrade * PARTICIPATION_WEIGHT;

Console.WriteLine();

Console.WriteLine("Student Progress Report");
Console.WriteLine("-----------------------");

Console.WriteLine();

Console.WriteLine("Student: " + fullName);
Console.WriteLine("Full Name (Uppercase): " + fullName.ToUpper());
Console.WriteLine("Full Name (Lowercase): " + fullName.ToLower());
Console.WriteLine("Name Length: " + fullName.Length);

Console.WriteLine();

Console.WriteLine("Study Hours: " + studyHours);
Console.WriteLine("Whole Study Hours: " + wholeHours);

Console.WriteLine();

Console.WriteLine("Exam Average: " + average.ToString("F2"));
Console.WriteLine("Projected Final Grade: " + finalGrade.ToString("F2"));

Console.WriteLine();

Console.WriteLine("Textbook Price: $" + textbookPrice.ToString("F2"));
Console.WriteLine("Sales Tax: $" + salesTax.ToString("F2"));
Console.WriteLine("Total Cost: $" + totalCost.ToString("F2"));

Console.WriteLine();

Console.WriteLine("End of report.");