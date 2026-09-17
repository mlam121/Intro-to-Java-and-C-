Random rand = new Random();

int bingoValue;

Console.WriteLine("B\tI\tN\tG\tO");

for (int row = 0; row <=4; row++)
{
    for (int startRange = 1; startRange < 75; startRange += 15)
    {
        if (row == 2 && startRange == 31)
        {
            Console.Write("FREE\t");
        }
        else
        {
            bingoValue = rand.Next(15) + startRange;
            Console.Write(bingoValue + "\t");
        }
    }
    Console.WriteLine();
}