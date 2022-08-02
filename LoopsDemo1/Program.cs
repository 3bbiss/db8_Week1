// For loop

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 20; i > 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 21; i >= 0; i-=3)
{
    Console.WriteLine(i);
}

Console.WriteLine("All done!");


// While loop

int w = 1;
while (w < 5)
{
    Console.WriteLine("Inside while loop");
    Console.WriteLine(w);
    w++;
}

// Example of a break statement inside a while(true)

int w2 = 10;
while (w2 >= 0)
{
    if (w2 == 4) {
        Console.WriteLine("Oops, found corrupted data");
        break; // exits the LOOP immediately (doesn't exit "if")
    }
    Console.WriteLine(w2);
    w2--;
}

Console.WriteLine("Finished with while loops");
Console.WriteLine();

int w3 = 0;
do
{
    System.Console.WriteLine(w3);
    w3++;
} while (w3 < 10);

Console.WriteLine("All done with do while!");
Console.WriteLine();

// Nested loops

// for (int hour = 0; hour < 24; hour ++) {
//     System.Console.WriteLine($"The hour is {hour}");
//     for (int minute = 0; minute < 60; minute ++) {
//         System.Console.WriteLine($"   {hour}:{minute}");
//     }
// }


for (int i = 0; i < 12; i++) {
    Console.WriteLine($"Hour is: {i}");
    for (int j = 1; j < 60; j++) {
        Console.WriteLine($"\t{i}:{j}");
    }
}