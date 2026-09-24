//Random rand = new Random();

//int bingoValue;

//Console.WriteLine("B\tI\tN\tG\tO");

//for (int row = 0; row <=4; row++)
// {
//    for (int startRange = 1; startRange < 75; startRange += 15)
//    {
//        if (row == 2 && startRange == 31)
//        {
//            Console.Write("FREE\t");
//        }
//        else
//        {
//            bingoValue = rand.Next(15) + startRange;
//            Console.Write(bingoValue + "\t");
//        }
//    }
//    Console.WriteLine();
// }

Random rand = new Random();
int[,] bingoCard = new int[5, 5];
List<int> usedNumbers = new List<int>();

for (int row = 0; row < 5; row++)
{
    for (int col = 0; col < 5; col++)
    {
        if (row == 2 && col == 2)
        {
            bingoCard[row, col] = -1;
        }
        else
        {
            int startRange = (col * 15) + 1;
            int bingoValue;

            do
            {
                bingoValue = rand.Next(15) + startRange;
            } while (usedNumbers.Contains(bingoValue));

            usedNumbers.Add(bingoValue);
            bingoCard[row, col] = bingoValue;
        }
    }
}

Console.WriteLine("B\tI\tN\tG\tO");

for (int row = 0; row < 5; row++)
{
    for (int col = 0; col < 5; col++)
    {
        if (bingoCard[row, col] == -1)
        {
            Console.Write("FREE\t");
        }
        else
        {
            Console.Write(bingoCard[row, col] + "\t");
        }
    }
    Console.WriteLine();
}