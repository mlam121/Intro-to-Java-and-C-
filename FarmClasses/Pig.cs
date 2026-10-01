public class Pig
{
    public string Color{get;set;}
    public int PenSize{get;set;}
    public bool WallowedInMud{get;set;}
    public double Weight{get;set;}

    private static int pigCount = 0;

    //Pig Constructors
    public Pig()
    {
        Color = "pink";
        PenSize = 8;
        WallowedInMud = true;
        Weight = 500.0;
        pigCount++;
    }
    public Pig(string color, int penSize, bool wallowedInMud, double weight)
    {
        Color = color;
        PenSize = penSize;
        WallowedInMud = wallowedInMud;
        Weight = weight;
        pigCount++;
    }
    public void MakeNoise()
    {
        Console.WriteLine("OINK OINK OINK");
    }
    public void UpgradePenSize(int amount)
    {
        PenSize += amount;
    }
    public static int GetPigCount()
    {
        return pigCount;
    }
    public override string ToString()
    {
    return $"Color: {Color}, Pen Size: {PenSize}, Mud Wallowed: {WallowedInMud}, Weight: {Weight:F1}";
    }

}