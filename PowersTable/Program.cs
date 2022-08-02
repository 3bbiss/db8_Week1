string res;

do
{
    Console.WriteLine("Enter a positive integer");
    int entry = int.Parse(Console.ReadLine());

    // input validation: restricted 1-100
    while (entry < 1 || entry > 1290) // 1290^3 is biggest cube that can fit in int.
    {
        Console.WriteLine("Try again! Enter a positive integer <= 1290");
        entry = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Number\t Squared\tCubed");

    for (int i = 1; i <= entry; i++)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"{i}\t{i * i}\t\t{i * i * i}");
    }

    Console.WriteLine("Do you want to go again? Enter y/Y, or another key to quit");
    res = Console.ReadLine();
} while (res[0] == 'y' || res[0] == 'Y');