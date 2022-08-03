

bool isNum;
int num;
Console.Write("Enter a number: ");
string input = Console.ReadLine();
isNum = int.TryParse(input, out num);

// can i get a do-while in here? above..Maybe, maybe not. Thinking not because
// if I leave variables outside of the loop (scope things), then I can access/evaluate its value/condition
// inside the loop (or at end in while(xx). Being able to check the variables conditions at end of do-while
// lets me check to ensure its both a valid integer AND in range.
// IDK how to do that with a standard do-while loop yet.

while (!isNum || num < 1 || num > 100)
{
    Console.Write("Not an integer. Try again! Or too small/big!: ");
    input = Console.ReadLine();
    isNum = int.TryParse(input, out num);
}

Console.WriteLine();
Console.WriteLine(num);