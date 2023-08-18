

for (var idx = 1; idx <= 30; idx++)
{
    if (idx % 3 == 0 && idx % 5 == 0)
    {
        Console.WriteLine($"FizzBuzz");
        continue;
    }
    if (idx % 3 == 0)
    {
        Console.WriteLine($"Fizz");
        continue;
    }

    if (idx % 5 == 0)
    {
        Console.WriteLine($"Buzz");
        continue;
    }
    Console.WriteLine($"{idx} ");

}
Console.WriteLine("\nDone...");