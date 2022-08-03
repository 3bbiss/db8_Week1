
int a = TimesTwo(5);
Console.WriteLine(a);

int b = SomeNumber();
Console.WriteLine(b);

double area1 = CircleArea(3);
Console.WriteLine(area1);

double area2 = TriangleArea(3, 3);
Console.WriteLine(area2);

PrintArea(10);




static int TimesTwo(int num)
{
    //int result = num * 2;
    //return result;
    return num * 2;
}


static int SomeNumber()
{
    return 20;
}

static double CircleArea(double radius)
{
    return Math.PI * (radius * radius);
}

static double TriangleArea(int height, int width)
{
    //return 0.5 * height * width;
    return height * width / 2.0; // 2.0 to force double. Just 2 is int division.
}

static void PrintArea(double radius)
{
    double area = CircleArea(radius);
    Console.WriteLine(area);
}