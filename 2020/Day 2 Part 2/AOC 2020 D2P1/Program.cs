using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_2020_D2P2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawInput = File.ReadAllLines("Input.txt");
            int correctPasswords = 0;

            foreach (string line in rawInput) 
            {
                //password
                string[] splitLine = line.Split(": ");
                string password = splitLine[1];
                //mandatory character
                string[] splitLine2 = splitLine[0].Split(" ");
                char mandChar = splitLine2[1].ToCharArray()[0];
                //min + max num
                string[] nums = splitLine2[0].Split("-");
                int firstNum = Convert.ToInt32(nums[0]);
                int secondNum = Convert.ToInt32(nums[1]);

                var count = new List<int>();
                int counter = 0;

                foreach (char letter in password) 
                {
                    counter++;
                    if (letter == mandChar) 
                    {
                        count.Add(counter);
                    }
                }
                if (count.Contains(firstNum) ^ count.Contains(secondNum)) 
                {
                    correctPasswords++;
                }
            }
            Console.WriteLine(correctPasswords);
        }
    }
}
