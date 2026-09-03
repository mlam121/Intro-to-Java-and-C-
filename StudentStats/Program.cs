string firstName = "Alex";
string lastName = "Smith";
string fullName = firstName + " " + lastName;



int exam1 = 88;
int exam2 = 94;
int exam3 = 98;

double studyHours = 7.8;

const double PARTICIPATION_WEIGHT = 0.20;

Console.WriteLine("Student Progress Report");
Console.WriteLine("-----------------------");

Console.WriteLine("Student: " + fullName);
Console.WriteLine("Full Name (Uppercase): " + fullName.ToUpper());
Console.WriteLine("Full Name (Lowercase): " + fullName.ToLower());
Console.WriteLine("Number of Characters: " + fullName.Length);


double average = (exam1 + exam2 + exam3) / 3.0;

Console.WriteLine("Exam Average: " + average);

Console.WriteLine("Study Hours: " + studyHours);

int wholeHours = (int)studyHours;

Console.WriteLine("Whole Study Hours: " + wholeHours);

double participationGrade = 100;

double finalGrade = average * 0.80 + participationGrade * PARTICIPATION_WEIGHT;

Console.WriteLine("Projected Final Grade: " + finalGrade);

Console.WriteLine();
Console.WriteLine("End of report.");