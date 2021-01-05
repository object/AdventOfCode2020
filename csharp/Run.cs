using System;
using System.IO;
using System.Diagnostics;
using AdventOfCode2020;

var lines = File.ReadAllLines("./../data/input03.txt");
Func<string[],long> part1Func = Day03.Part1;
Func<string[],long> part2Func = Day03.Part2;

var stopwatch = new Stopwatch();

// Part One
stopwatch.Start();
long result = part1Func(lines);
stopwatch.Stop();
Console.WriteLine($"{result} ({stopwatch.Elapsed})");

// Part Two
stopwatch.Reset();
stopwatch.Start();
result = part2Func(lines);
stopwatch.Stop();
Console.WriteLine($"{result} ({stopwatch.Elapsed})");
