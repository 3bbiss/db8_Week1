//const double HEIGHT = 8; just to remember CONSTANT VARIABLES

Console.WriteLine("Enter length");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter width");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Enter height");
double height = double.Parse(Console.ReadLine());

double perimeter = length + length + width + width;
double area = length * width;
double volume = length * width * height;

Console.WriteLine($"perimeter = {perimeter}");
Console.WriteLine($"area = {area}");
Console.WriteLine($"volume ={volume}"); // extra


if (area <= 250) // assuming valid data, no negatives
{
    Console.WriteLine("The room is small");
}
else if (area < 650)
{
    Console.WriteLine("The room is medium");
}
else
{
    Console.WriteLine("The room is large");
}