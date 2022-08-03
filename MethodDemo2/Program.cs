// Pass by reference

double first = 3.5;
double second = 4.5;
double area = RectangleArea(ref first, ref second);
Console.WriteLine($"Rectangle {first} by {second} has area {area}");
Console.WriteLine(first); // changed to 100
Console.WriteLine(second); // changed to 200

static double RectangleArea(ref double len, ref double wid)
{
    double result = len * wid;
    len = 100; // changes original
    wid = 200; // changes original
    return result;
}

// Out parameter

double result;
bool worked = Divide(10, 0, out result);
if (worked)
{
	Console.WriteLine($"Great! The answer is {result}");
}
else
{
	Console.WriteLine("Sorry, you cannot divide by zero!");
}

static bool Divide(double num1, double num2, out double result)
{
	// check if num2 is zero. And if so, don't do it.
	if (num2 == 0)
	{
		result = 0;
		return false;
	}
	else
	{
		result = num1 / num2;
		return true;
	}
}