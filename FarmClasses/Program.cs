// DO NOT MAKE EDITS TO THIS FILE!

// Create farm animals using both constructors
Cow franny = new Cow();
Cow gretta = new Cow("Gretta", 100, 1, false);

Chicken clucky = new Chicken();
Chicken marshmallow = new Chicken("Sussex", 2, false, 83.5);

Pig piglet = new Pig();
Pig pickles = new Pig("Yellow", 10, true, 567.88);

// Call MakeNoise() methods
franny.MakeNoise();
clucky.MakeNoise();
pickles.MakeNoise();

// Modify some values using behavior methods
gretta.HaveBirthday();
marshmallow.EatFood(10);
piglet.UpgradePenSize(3);

// Display updated values using properties
Console.WriteLine("Gretta's age: " + gretta.Age);
Console.WriteLine("Marshmallow's weight: " + marshmallow.Weight);
Console.WriteLine("Piglet's pen size: " + piglet.PenSize);

// Display the number of objects created from each class
Console.WriteLine("Total cows created: " + Cow.GetCowCount());
Console.WriteLine("Total chickens created: " + Chicken.GetChickenCount());
Console.WriteLine("Total pigs created: " + Pig.GetPigCount());

// Use ToString() to display full details
Console.WriteLine(gretta);
Console.WriteLine(marshmallow);
Console.WriteLine(piglet);