using System;
using System.IO;

namespace AOC_2021_D2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("PuzzleInput.txt");

            int ans1 = Part1(lines);
            int ans2 = Part2(lines);

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }

        static int Part1(string[] lines) 
        {
            int forwardH = 0;
            int depth = 0;
            int up = 0;
            int down = 0;

            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(" ");
                string dir = lineSplit[0];
                int num = Convert.ToInt32(lineSplit[1]);

                if (dir == "forward")
                {
                    forwardH += num;
                }

                if (dir == "up")
                {
                    up += num;
                }

                if (dir == "down")
                {
                    down += num;
                }
            }

            depth = down - up;
            int result = depth * forwardH;

            return result;
        }

        static int Part2(string[] lines) 
        {
            int forwardH = 0;
            int depth = 0;
            int aim = 0;

            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(" ");
                string dir = lineSplit[0];
                int num = Convert.ToInt32(lineSplit[1]);

                if (dir == "forward")
                {
                    forwardH += num;
                    depth += aim * num;
                }

                if (dir == "up")
                {
                    aim -= num;
                }

                if (dir == "down")
                {
                    aim += num;
                }
            }

            int result = forwardH * depth;
            return result;

        }
    }
}
