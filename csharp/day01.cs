using System;
using System.Linq;

namespace AdventOfCode2020
{
    public static class Day01
    {
        public static long Part1(string [] lines)
        {
            var numbers = lines.Select(x => Int32.Parse(x)).ToArray();
            for (var i = 0; i < numbers.Count(); i++) 
            {
                for (var j = i+1; j < numbers.Count(); j++) 
                {
                    if (numbers[i] + numbers[j] == 2020) {
                        return numbers[i] * numbers[j];
                    }
                }
            }
            return 0L;
        }

        public static long Part2(string [] lines)
        {
            var numbers = lines.Select(x => Int32.Parse(x)).ToArray();
            for (var i = 0; i < numbers.Count(); i++) 
            {
                for (var j = i+1; j < numbers.Count(); j++) 
                {
                    for (var k = j+1; k < numbers.Count(); k++) 
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 2020) {
                            return numbers[i] * numbers[j] * numbers[k];
                        }
                    }
                }
            }
            return 0L;
        }
    }
}
