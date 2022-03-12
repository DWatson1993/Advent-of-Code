using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace AOC_2021_D6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("PuzzleInput.txt");

            string[] inputArrStr = input.Split(",");

            int[] inputArr = Array.ConvertAll(inputArrStr, int.Parse);

            int ans1 = Part1(inputArr);

            double ans2 = Part2(inputArr);

            Console.WriteLine(ans1);

            Console.WriteLine(ans2);
        }

        static int Part1(int[] input)
        {
            List<int> mainList = input.ToList();

            for (int d = 0; d < 80; d++) 
            {

                List<int> tempList = new List<int>();

                for (int f = 0; f < mainList.Count(); f++) 
                {
                    int fish = mainList[f] - 1;

                    if (fish < 0)
                    {
                        fish = 6;
                        tempList.Add(fish);
                        tempList.Add(8);
                    }
                    else
                    {
                        tempList.Add(fish);
                    }


                }

                mainList = tempList;

            }

            int result = mainList.Count();

            return result;
        }

        static double Part2(int[] input)
        {
            Dictionary<int, double> fish = new Dictionary<int, double>();

            for (int i = 0; i < 9; i++) 
            {
                fish[i] = 0;
            }

            foreach (var f in input) 
            {
                fish[f]++;
            }

            for (int d = 0; d < 256; d++) 
            {
                double tempZero = 0;

                for (int i = 0; i < 9; i++) 
                {
                    if (i == 0)
                    {
                        tempZero = fish[i];
                    }
                    else
                    {
                        fish[i - 1] = fish[i];
                    }
                }

                fish[6] += tempZero;
                fish[8] = tempZero;
            }

            double result = 0;

            for (int i = 0; i < 9; i++) 
            {
                result += fish[i];
            }

            return result;
        }

    }
}
