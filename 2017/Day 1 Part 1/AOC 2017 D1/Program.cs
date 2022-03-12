using System;

namespace AOC_2017_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("Puzzle input.txt");

            var total = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var leftchar = text[i];
                var rightchar = text[(i + 1) % text.Length];

                if (leftchar == rightchar) 
                {
                    var left = Convert.ToInt32(leftchar.ToString());

                    total += left;
                    
                }

            }

            Console.WriteLine(total);
           
        }
    }
}
