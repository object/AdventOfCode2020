using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public static class Day02
    {
        class Rule
        {
            public char Char { get; private set; }
            public int First { get; private set; }
            public int Second { get; private set; }
            public string Sample { get; private set; }

            public static Rule Parse(string line)
            {
                var groups = Regex.Match(line, @"^(\d+)-(\d+) (\w): (\w+)$").Groups;

                return new Rule
                {
                    Char = groups[3].Value[0],
                    First = Int32.Parse(groups[1].Value),
                    Second = Int32.Parse(groups[2].Value),
                    Sample = groups[4].Value,
                };
            }

            public bool IsValidSamplePart1()
            {
                var count = Sample.Where(x => x == Char).Count();
                return count >= First && count <= Second;
            }

            public bool IsValidSamplePart2()
            {
                return Sample.Length >= Second && 
                    Sample[First-1] == Char && Sample[Second-1] != Char ||
                    Sample[First-1] != Char && Sample[Second-1] == Char;
            }
        }

        public static long Part1(string [] lines)
        {
            return lines.Select(x => Rule.Parse(x)).Where(x => x.IsValidSamplePart1()).Count();
        }

        public static long Part2(string [] lines)
        {
            return lines.Select(x => Rule.Parse(x)).Where(x => x.IsValidSamplePart2()).Count();
        }
    }
}
