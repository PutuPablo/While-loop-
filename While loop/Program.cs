// The while loop

Console.WriteLine("Enter go or stay");

string userChoice = Console.ReadLine();

if (userChoice.ToLower() == "stay")
{
    Console.WriteLine("Alright, take a good rest first ");
}
else if (userChoice.ToLower() == "go")
{
    while (userChoice.ToLower() == "go")
    {
        Console.WriteLine("Go walking for 10 km");
        Console.WriteLine("Keep walking? Enter go again.");
        userChoice = Console.ReadLine();
    }

    Console.WriteLine("Okay, now it's time to rest!");
}
else
{
    Console.WriteLine("Invalid input!");
}

Console.ReadKey();
