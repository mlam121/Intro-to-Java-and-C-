public class Cow
{
    //Properties of each cow
    public string Name{get;set;}
    public double Weight{get;set;}
    public int Age{get;set;}
    public bool Gender{get;set;}

    //Static variable to track the number of Cow objects created
    private static int cowCount = 0;

    //Default constructor
    public Cow()
    {
        Name = "Franny";
        Weight = 100.0;
        Age = 0;
        Gender = true;
        cowCount++;
    }

    //Parameterized constructor
    public Cow(string name, double weight, int age, bool gender)
    {
        Name = name;
        Weight = weight;
        Age = age;
        Gender = gender;
        cowCount++;
    }

    //Method to make noise
    public void MakeNoise()
    {
        Console.WriteLine("MOO MOO MOO");
    }

    //Method to increase cow's age
    public void HaveBirthday()
    {
        Age++;
    }

    //Static method to return number of Cow objects
    public static int GetCowCount()
    {
        return cowCount;
    }
    //Return a formatted string with the Cow object's data
    public override string ToString()
    {
    return $"Name: {Name}, Weight: {Weight:F1}, Age: {Age}, Gender: {Gender}";
    }

    
}