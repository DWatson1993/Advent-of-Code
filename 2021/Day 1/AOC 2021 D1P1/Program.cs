using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_2021_D1P1
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
            int current = Convert.ToInt32(lines[0]);
            int count = 0;


            for (int i = 1; i < lines.Length; i++)
            {
                int lineNum = Convert.ToInt32(lines[i]);

                if (lineNum > current)
                {
                    count++;
                }

                current = lineNum;
            }

            return count;
        }

        static int Part2(string[] lines) 
        {
            int count = 0;
            List<int> numSums = new List<int>();

            for (int i = 0; i < lines.Length - 2; i++) 
            {
                int lineSums = 0;

                for (int c = 0; c < 3; c++) 
                {
                    lineSums += Convert.ToInt32(lines[c + i]);
                }

                numSums.Add(lineSums);
            }

            int[] numSumsArr = numSums.ToArray();

            for (int i = 1; i < numSumsArr.Length; i++) 
            {
                if (numSumsArr[i] > numSumsArr[i - 1]) 
                {
                    count++;
                }
            }

            return count;
        }

    }
}
