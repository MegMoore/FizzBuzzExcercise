﻿
using FizzBuzzExcercise;

Student.print("This is a static method statement");

//var greg = new Instructor();


var david = new Student("David");
Console.WriteLine($"Id [{david.Id}] Name is [{david.name}] State is [{david.state}] ");
                           

var megan = new Student("Megan");
megan.name = "Megan";
megan.state = "OH";

var tony = new Student("Tony");
tony.name = "Tony";
tony.state = "AZ";
tony.ChangeName("Anthony");


Console.WriteLine($"Students are {megan.name} and {tony.name}");

Console.WriteLine($"Id is [{megan.Id}] Name is [{megan.name}] State is [{megan.state}] "); 
                





/*
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
*/