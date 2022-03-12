using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_2020_D3P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("Input.txt");
            int treeCount = 0;
            int i = 0;
            char tree = '#';

            foreach (string line in input) 
            {
                char place = line[i % line.Length];
                if (place == tree) 
                {
                    treeCount++;
                }
                
                i += 3;
            }
            Console.WriteLine(treeCount);
        }
    }
}
