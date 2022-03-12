using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_2021_D7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("PuzzleInput.txt");
            string[] inputArrStr = input.Split(",");
            int[] inputArrInt = Array.ConvertAll(inputArrStr, int.Parse);

            int ans1 = Part1(inputArrInt);
            int ans2 = Part2(inputArrInt);

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }

        static int Part1(int[] input) 
        {
            int lowest = input.Min();
            int highest = input.Max();

            int ans = 0;
            bool check = false;

            for (int i = lowest; i <= highest; i++)
            {
                int r = 0;

                foreach (int crab in input) 
                {
                    if (crab < i)
                    {
                        r += (i - crab);
                    }
                    else 
                    {
                        r += (crab - i);
                    }
                }

                if (check)
                {
                    if (r < ans) 
                    {
                        ans = r;
                    }
                }
                else 
                {
                    ans = r;
                    check = true;
                }

            }


            return ans;


        }

        static int Part2(int[] input) 
        {
            int lowest = input.Min();
            int highest = input.Max();

            int ans = 0;
            bool check = false;

            for (int i = lowest; i <= highest; i++)
            {
                int r = 0;

                foreach (int crab in input)
                {
                    int x = 0;

                    if (crab < i)
                    {
                        x += (i - crab);
                    }
                    else
                    {
                        x += (crab - i);
                    }

                    for (int y = 0; y < x; y++)
                    {
                        r += y + 1;
                    }
                }

                //for (int x = 0; x < input.Length; x++) 
                //{
                //    r += (input[x] * (input[x] + 1)) / 2;
                //}


                if (check)
                {
                    if (r < ans)
                    {
                        ans = r;
                    }
                }
                else
                {
                    ans = r;
                    check = true;
                }
            }

            return ans;
        }
    }
}
