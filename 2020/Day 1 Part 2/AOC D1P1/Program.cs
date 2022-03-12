using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_D1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 2020;
            int total = 0;
            string[] inputStr = File.ReadAllLines("Input.txt");
            int[] input = inputStr.Select(x => Convert.ToInt32(x)).ToArray();

            //List<int> input = new List<int>();
            //foreach (string line in inputStr) 
            //{
            //    int inputInt = Convert.ToInt32(line);
            //    input.Add(inputInt);
            //}
            int input1 = 0;
            int input2 = 0;
            int input3 = 0;

                for (int i = 0; i <= input.Count() - 3; i++)
                {
                    input1 = input[i];

                    for (int r = i + 1; r <= input.Count() - 2; r++)
                    {
                        input2 = input[r];

                        for (int c = r + 1; c <= input.Count() - 1; c++)
                        {
                            input3 = input[c];
                            total = input1 + input2 + input3;
                        
                            if (total == target) 
                            {
                                Console.WriteLine(input1 * input2 * input3);
                            }

                        }
                    }
                }
        }
    }
}
