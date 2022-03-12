using System;
using System.IO;
using System.Linq;

namespace AOC_2020_D2P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawInput = File.ReadAllLines("Input.txt");
            int correctPasswords = 0;

            foreach (string line in rawInput) 
            {
                int count = 0;
                //password
                string[] splitLine = line.Split(": ");
                string password = splitLine[1];
                //mandatory character
                string[] splitLine2 = splitLine[0].Split(" ");
                char mandChar = splitLine2[1].ToCharArray()[0];
                //min + max num
                string[] nums = splitLine2[0].Split("-");
                int minNum = Convert.ToInt32(nums[0]);
                int maxNum = Convert.ToInt32(nums[1]);

                foreach (char check in password) 
                {
                    if (check == mandChar)
                    {
                        count++;
                    }
                }
                if (count >= minNum && count <= maxNum) 
                {
                    correctPasswords++;
                }

            }
            Console.WriteLine(correctPasswords);

        }
    }
}
