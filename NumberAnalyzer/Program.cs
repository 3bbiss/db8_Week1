string res; // variable to determine if user wants to play again or not
Console.WriteLine("Enter your name :)");
string name = Console.ReadLine();

do
{
    Console.WriteLine($"Hi {name}! Enter an integer from 1-100");
    int entry = int.Parse(Console.ReadLine());


    // input validation: restricted 1-100
    while (entry < 1 || entry > 100)
    {
        Console.WriteLine($"Try again {name}! Enter an integer from 1-100");
        entry = int.Parse(Console.ReadLine());
    }

    if ((entry % 2 == 1) && (entry < 60))
    {
        Console.WriteLine("Odd and less than 60.");
    }
    else if ((entry % 2 == 0) && (entry >= 2 && entry <= 24))
    {
        Console.WriteLine("Even and less than 25.");
    }
    else if ((entry % 2 == 0) && (entry >= 26 && entry <= 60))
    {
        Console.WriteLine("Even and between 26 and 60 inclusive.");
    }
    else if ((entry % 2 == 0) && (entry > 60))
    {
        Console.WriteLine("Even and greater than 60.");
    }
    else if ((entry % 2 == 1) && (entry > 60))
    {
        Console.WriteLine("Odd and greater than 60.");
    }

    Console.WriteLine("Do you want to go again?");
    res = Console.ReadLine();
} while (res[0] == 'y' || res[0] == 'Y');