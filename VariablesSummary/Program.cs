// Integers
int x = 10;
x *= 2;
x++;
Console.WriteLine(x); // should see 21


// Strings
string product = "Monitor";
product = product.ToUpper();
Console.WriteLine(product); // should see MONITOR


// Doubles
double first = 2.5;
double pi = Math.PI; // redundant variable.
Console.WriteLine(first);
Console.WriteLine(pi);
double mult = first * pi;
Console.WriteLine(mult);
double mult2 = first * Math.PI;
Console.WriteLine(mult2);


// Decimal (Money)
decimal charge = 10.25m; // m for "money"
decimal perc = charge / 3;
Console.WriteLine(perc);

// Boolean
bool finished = false;
Console.WriteLine(finished); // should see "False" w/ capital F
bool another = !finished;
Console.WriteLine(another); // should see "True" w/ capital T

Console.WriteLine();
Console.WriteLine("Expressions that are true or false");
int q = 20;
bool test1 = (q > 10); // Not a question: Is q greater than 10? Instead a sentence: "q is greater than 10." Is that True of False?
Console.WriteLine(test1); // should see True

// Let's just print a couple out directly
Console.WriteLine(q > 30); // should see False
Console.WriteLine(q == 20); // should see True
Console.WriteLine(q != 20); // should see False. "Q is not equal to 20. True or False?"
Console.WriteLine(!(q != 20)); // should see True. 

// Let's add in "and" "or"
int j = 10;
int k = 11;

Console.WriteLine( (j == 10) && (k == 11) );
Console.WriteLine((j == 10) && (k == 12));
Console.WriteLine((j == 10) || (k == 12));