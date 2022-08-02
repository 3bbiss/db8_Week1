string name = "Fred";
Console.WriteLine(name);
string upperName = name.ToUpper();  // Strings are IMMUTABLE
Console.WriteLine(upperName);
Console.WriteLine(name);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);

Console.WriteLine(name.ToLower());

// Floating Point Types aka decimals
//double PI = Math.PI;
double pi = 3.1415926;
Console.WriteLine(pi);
double pi2 = pi * 2;
Console.WriteLine(pi2);

Console.WriteLine(Math.Sqrt(pi));

double q = Math.Sqrt(25);
Console.WriteLine(q);

//float n = 3.1415926f;  We rarely use float. Put an F/f after to cast.
// When working with money, we don't use float OR double in C#.

decimal amount = 99.95m;
Console.WriteLine(amount);
amount *= 2;
Console.WriteLine(amount);

bool passed = true;
Console.WriteLine(passed);
passed = false;
Console.WriteLine(passed);
passed = !passed;
Console.WriteLine(passed); // passed was false; the "not" operator flips it to true
