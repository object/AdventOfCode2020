using System;
using System.Linq;

namespace AdventOfCode2020
{
    public static class Day03
    {
        static int [][] GetArea(string [] lines)
        {
            return lines.Select(line => line.Select(c => c == '#' ? 1 : 0).ToArray()).ToArray();
        }

        public static long Part1(string [] lines)
        {
            var area = GetArea(lines);
            var count = 0;
            for (int x = 0, y = 0; x < area.Count(); x += 1, y += 3)
            {
                count += area[x][y % area[0].Count()];
            }
            return count;
        }
 
        public static long Part2(string [] lines)
        {
            (int X, int Y)[] steps = { (1,1), (3,1), (5,1), (7,1), (1,2) };
            var area = GetArea(lines);
            var result = 1L;
            foreach (var step in steps)
            {
                var count = 0;
                for (int x = 0, y = 0; y < area.Count(); x += step.X, y += step.Y)
                {
                    count += area[y][x % area[0].Count()];
                }
                result *= count;
            } 
            return result;
        }
    }
}