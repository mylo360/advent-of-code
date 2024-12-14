using System;
using AdventOfCode2024.Days;

Console.WriteLine("Hi, welcome to advent of code 2024");

var day = getDayInput();

switch (day)
{
    case 1:
        Day01.Solution();
        break;
    default:
        Console.WriteLine($"The day {day} does not exist.");
        break;
}

int getDayInput()
{
    var isDayValidInt = false;
    int day = 0;

    while (isDayValidInt == false)
    {
        Console.Write("Tell me which day you want to execute: ");
        var dayInput = Console.ReadLine();

        isDayValidInt = int.TryParse(dayInput, out day);

        if (!isDayValidInt)
        {
            Console.WriteLine("Your input is not a number!");
        }
    }
    return day;
}

