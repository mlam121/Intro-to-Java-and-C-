List<string> animals = new List<string>()
{
    "Bella",
    "Max",
    "Charlie",
    "Luna",
    "Buddy",
    "Daisy",
    "Rocky",
    "Milo",
    "Sadie",
    "Bailey"
};

// Task 1
        // Causes an InvalidOperationException because the list is being modified while the foreach loop is traversing it

// foreach (string animal in animals)
// {
//     Console.WriteLine(animal);
//
//     if (animal == "Buddy")
//     {
//         animals.Remove(animal);
//     }
// }


// Task 2

// for (int i = 0; i < animals.Count; i++)
// {
//     if (animals[i] == "Buddy")
//     {
//         Console.WriteLine("Goodbye " + animals[i]);
//         animals.RemoveAt(i);
//     }
// }
//
// foreach (string animal in animals)
// {
//     Console.WriteLine(animal);
// }


// Task 3

// for (int i = 0; i < animals.Count; i++)
// {
//     if (animals[i] == "Buddy")
//     {
//         Console.WriteLine("Goodbye " + animals[i]);
//         animals.RemoveAt(i);
//     }
//     else if (animals[i] == "Daisy")
//     {
//         Console.WriteLine("Goodbye " + animals[i]);
//         animals.RemoveAt(i);
//     }
// }
//
// foreach (string animal in animals)
// {
//     Console.WriteLine(animal);
// }
        // Daisy may not be removed because when Buddy is removed, Daisy shifts to Buddy's old index. 
        // The loop then moves to the next index and skips Daisy.


// Task 4
// for (int i = 0; i < animals.Count; i++)
// {
//     if (animals[i] == "Buddy")
//     {
//         Console.WriteLine("Goodbye " + animals[i]);
//         animals.RemoveAt(i);
//         i--;
//     }
//     else if (animals[i] == "Daisy")
//     {
//         Console.WriteLine("Goodbye " + animals[i]);
//         animals.RemoveAt(i);
//         i--;
//     }
// }
//
// foreach (string animal in animals)
// {
//     Console.WriteLine(animal);
// }

        // Decreasing i by 1 has the loop check the same index again after an animal is removed. 
        // This prevents the next animal from being skipped.

// Task 5

for (int i = animals.Count - 1; i >= 0; i--)
{
    if (animals[i] == "Buddy")
    {
        Console.WriteLine("Goodbye " + animals[i]);
        animals.RemoveAt(i);
    }
    else if (animals[i] == "Daisy")
    {
        Console.WriteLine("Goodbye " + animals[i]);
        animals.RemoveAt(i);
    }
}

foreach (string animal in animals)
{
    Console.WriteLine(animal);
}

        // Traversing a List backwards is a good strategy when elements need to be
        // removed because removing an item does not affect the indexes already checked.