using System;

namespace AOC_2017_D2P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = System.IO.File.ReadAllLines("Puzzle input.txt");

            var total = 0;

            foreach (var line in text) 
            {
                var chunks = line.Split('\t');

                var value = Calculate(chunks);

                total += value;
            }

            Console.WriteLine("Total = " + total);

        }

        static int Calculate(string[] preTotal) 
        {

            var min = 10000;

            var max = 0;

            foreach (var splitNumbers in preTotal) 
            {
                var result = Convert.ToInt32(splitNumbers);

            
                if (result <= min) 
                {
                    min = result;
                }

                if (result >= max) 
                {
                    max = result;
                }
                      

            }

            return (max - min);

        }
    }
}
