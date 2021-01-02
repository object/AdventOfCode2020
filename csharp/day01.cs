using System;
using System.Linq;
using System.IO;
using System.Diagnostics;

var numbers = File.ReadAllLines("./../data/input01.txt").Select(x => Int32.Parse(x)).ToArray();

var stopwatch = new Stopwatch();

// Part One
stopwatch.Start();
int result = 0;
for (var i = 0; i < numbers.Count(); i++) 
{
    for (var j = i+1; j < numbers.Count(); j++) 
    {
        if (numbers[i] + numbers[j] == 2020) {
            result = numbers[i] * numbers[j];
            break;
        }
    }
}
stopwatch.Stop();
Console.WriteLine($"{result} ({stopwatch.Elapsed})");

// Part Two
stopwatch.Reset();
stopwatch.Start();
result = 0;
for (var i = 0; i < numbers.Count(); i++) 
{
    for (var j = i+1; j < numbers.Count(); j++) 
    {
        for (var k = j+1; k < numbers.Count(); k++) 
        {
            if (numbers[i] + numbers[j] + numbers[k] == 2020) {
                result = numbers[i] * numbers[j] * numbers[k];
                break;
            }
        }
    }
}
stopwatch.Stop();
Console.WriteLine($"{result} ({stopwatch.Elapsed})");
