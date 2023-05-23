using DemoLibrary;


string fName, lName, fullName;

Console.Write("What is your First name: ");
fName = Console.ReadLine();

Console.Write("What is your Second name: ");
lName = Console.ReadLine();

fullName = PersonProcessor.JoinName(fName, lName);

Console.WriteLine($"Your full name is {fullName}.");
