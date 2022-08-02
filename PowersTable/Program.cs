string res;

do
{
    Console.WriteLine("Enter a positive integer");
    int entry = int.Parse(Console.ReadLine());

    // input validation: restricted 1-100 (unless they enter -1 to quit)
    while (entry < 1)
    {
        Console.WriteLine("Try again! Enter a positive integer");
        entry = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Number\t Squared\tCubed");

    for (int i = 1; i <= entry; i++)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"{i}\t{i * i}\t\t{i * i * i}");
    }

    Console.WriteLine("Do you want to go again? Enter y or n");
    res = Console.ReadLine();
} while (res[0] == 'y' || res[0] == 'Y');