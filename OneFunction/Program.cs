int first = 20;
int second = 30;
Console.WriteLine("Getting started!");
int product = Multiply(first, second);
Console.WriteLine(product);
Console.WriteLine("All done!");

int p2 = Multiply(first, 50);
Console.WriteLine(p2);
int p3 = Multiply(second, 2);
Console.WriteLine(p3);
int p4 = Multiply(p2, p3);
Console.WriteLine(p4);






static int Multiply(int x, int y)
{
    //Console.WriteLine("We are inside the function!");
    //Console.WriteLine($"The value of x is: {x}");
    //Console.WriteLine($"The value of y is: {y}");
    return x * y;
}