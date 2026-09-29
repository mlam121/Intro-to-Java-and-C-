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

Console.WriteLine("Animals currently in the shelter:");

// foreach (string animal in animals)
// {
//    Console.WriteLine(animal);

//    if (animal == "Buddy")
//    {
//        animals.Remove(animal);
//    }
// }
for (int i = 0; i < animals.Count; i++)
{
    if (animals[i] == "Buddy")
    {
        Console.WriteLine("Goodbye " + animals[i]);
        animals.RemoveAt(i);
    }
}