/*
First ask the user for the number of sides and then generate two dice of that size and print them both out. Get that part working before moving on to the next.
Then add an if statement checking if the size is 6, and then do all the if statements for the scoring given in the lab
Then only after all the above is done, add in the "would you like to go again" part.
 */


bool res1;
int sides;
string response;

do
{
    do
    {
        Console.Write("Enter number of sides on dice! (Will not accept invalid input!): ");
        string input1 = Console.ReadLine();
        res1 = int.TryParse(input1, out sides);
    }
    while (!res1 || sides < 2 || sides > 6); // restricted number of sides to between 2 and 6

    int number1 = GetRandom(sides + 1);
    int number2 = GetRandom(sides + 1);

    string output = RollDice(number1, number2, sides);
    Console.WriteLine(output);

    Console.WriteLine();
    Console.Write("Want to play again? Enter y/Y, or any other key to quit: ");
    response = Console.ReadLine().ToLower();
    Console.WriteLine();
} while (response[0] == 'y');






// FUNCTIONS BELOW //

static string RollDice(int num1, int num2, int numSides)
{
    if (numSides == 6)
    {
        return SixSided(num1, num2);
    }
    else
    {
        return ($"You rolled {num1} and {num2} and your combination is {num1 + num2}");
    }
}

static int GetRandom(int numSides)
{
    Random r = new Random();
    int r1 = r.Next(1, numSides);
    return r1;
}

static string SixSided(int d1, int d2)
{
    if (d1 + d2 == 2)
    {
        return ($"You rolled {d1} and {d2} = {d1 + d2} = Snake Eyes & Craps!");
    }
    else if (d1 + d2 == 3)
    {
        return ($"You rolled {d1} and {d2} = {d1 + d2} = Ace Deuce & Craps!");
    }
    else if (d1 + d2 == 12)
    {
        return ($"You rolled {d1} and {d2} = {d1 + d2} = Box Cars & Craps!");
    }
    else if (d1 + d2 == 7 || d1 + d2 == 11)
    {
        return ($"You rolled {d1} and {d2} = {d1 + d2} = Win!");
    }
    else
    {
        return ($"You rolled {d1} and {d2} = {d1 + d2}");
    }
}