/*
Instructions:
Ask the user to enter a number
Print out the square of the number
Ask the user if they want to go again. They can enter y or Y to go again, n or N to quit
*/

string entry;
bool keepGoing = true;


do
{
    Console.Write("Please enter a number: ");
    double num = double.Parse(Console.ReadLine());
    System.Console.WriteLine($"That number squares is {num * num}");

    // Ask the user if they wanna go again
    bool valid = false;
    do
    {
        Console.WriteLine("Want to play again? (y/n)");
        entry = Console.ReadLine().ToLower();
        if (entry == "n" || entry == "no") {
            valid = true;
            keepGoing = false;
        }
        else if (entry == "y" || entry == "yes") {
            valid = true;
        }
    } while (valid == false);

} while (keepGoing);


