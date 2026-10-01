public class Chicken
{
    public string Breed{get;set;}
    public int EggsPerDay{get;set;}
    public bool IsMean{get;set;}
    public double Weight{get;set;}

    private static int chickenCount = 0;

    public Chicken()
    {
        Breed = "Rhode Island Red";
        EggsPerDay = 1;
        IsMean = false;
        Weight = 6.0;
        chickenCount++;
    }

    public Chicken(string breed, int eggsPerDay, bool isMean, double weight)
    {
        Breed = breed;
        EggsPerDay = eggsPerDay;
        IsMean = isMean;
        Weight = weight;
        chickenCount++;
    }

    //Make noise
    public void MakeNoise()
    {
        Console.WriteLine("CLUCK CLUCK CLUCK");
    }
    public void EatFood(int amount)
    {
        Weight += amount;
    }
    public static int GetChickenCount()
    {
        return chickenCount;
    }
    public override string ToString()
    {
        return $"Breed: {Breed}, Eggs Per Day: {EggsPerDay}, Mean: {IsMean}, Weight: {Weight:F1}";
    }

}