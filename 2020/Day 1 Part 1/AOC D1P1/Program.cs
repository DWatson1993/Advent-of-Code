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
            string[] input = File.ReadAllLines("Input.txt");
            
            for (int i = 0; i <= input.Length - 1; i++) 
            {
                int input1 = Convert.ToInt32(input[i]);

                for (int r = i++; r <= input.Length - 1; r++) 
                {
                    int input2 = Convert.ToInt32(input[r]);
                    total = input1 + input2;

                    if (total == target) 
                    {
                        Console.WriteLine(input1 * input2);
                    }
                }
            }

        }
    }
}
