
string entry = Console.ReadLine();
int n = int.Parse(entry);

//int n = Convert.ToInt32(Console.ReadLine());

if (n > 50)
{
    Console.WriteLine("Yes, n is greater than 50.");
    Console.WriteLine($"n is {n}");
}
else
{
    Console.WriteLine("No, n is not greater than 50.");
    Console.WriteLine($"n is {n}");
}


// Let's see if the number is between 3 and 10 exclusive
if ( (n > 3) && (n < 10) )
{
    Console.WriteLine("Yes, N is between 3 and 10");
}
else
{
    Console.WriteLine("No, N is not between 3 and 10");
}


// Let's see if the number is between 3 and 10 inclusive
if ((n >= 3) && (n <= 10))
{
    Console.WriteLine("Yes, N is between 3 and 10, or 3 or 10");
}
else
{
    Console.WriteLine("No, N is not between 3 and 10, or 3 or 10");
}