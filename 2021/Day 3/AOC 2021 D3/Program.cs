using System;
using System.Collections.Generic;
using System.IO;

namespace AOC_2021_D3
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
            int len = lines[0].Length;

            string gamma = "";
            string epsilon = "";

            for (int i = 0; i < len; i++)
            {
                int one = 0;
                int zero = 0;

                foreach (string line in lines)
                {
                    char p = line[i];

                    if (p == '1')
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }

                }

                if (one > zero)
                {
                    gamma += "1";
                    epsilon += "0";
                }
                else 
                {
                    gamma += "0";
                    epsilon += "1";
                }

            }

            int gammaDec = Convert.ToInt32(gamma, 2);
            int epsilonDec = Convert.ToInt32(epsilon, 2);

            int result = gammaDec * epsilonDec;

            return result;
        }

        static int Part2(string[] lines) 
        {
            int len = lines[0].Length;

            string oxygen = "";
            string co2 = "";
            string[] linesOx = lines;
            string[] linesCo2 = lines;



            for (int i = 0; i < len; i++)
            {
                List<string> oxList = new List<string>();
                int one = 0;
                int zero = 0;
                char r;                

                foreach (string line in linesOx)
                {
                    char p = line[i];

                    if (p == '1')
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }

                }

                if (one >= zero)
                {
                    r = '1';
                }
                else
                {
                    r = '0';
                }
                

                foreach (string line in linesOx) 
                {
                    char p = line[i];

                    if (p == r) 
                    {
                        oxList.Add(line);
                    }
                }
                linesOx = oxList.ToArray();

                if (linesOx.Length == 1) 
                {
                    break;
                }
            }

            oxygen = linesOx[0];

            for (int i = 0; i < len; i++)
            {
                List<string> co2List = new List<string>();
                int one = 0;
                int zero = 0;
                char r;

                foreach (string line in linesCo2)
                {
                    char p = line[i];

                    if (p == '1')
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }

                }

                if (zero <= one)
                {
                    r = '0';
                }
                else
                {
                    r = '1';
                }


                foreach (string line in linesCo2)
                {
                    char p = line[i];

                    if (p == r)
                    {
                        co2List.Add(line);
                    }
                }
                linesCo2 = co2List.ToArray();

                if (linesCo2.Length == 1)
                {
                    break;
                }
            }

            co2 = linesCo2[0];


            int oxygenDec = Convert.ToInt32(oxygen, 2);
            int co2Dec = Convert.ToInt32(co2, 2);

            int result = oxygenDec * co2Dec;

            return result;


        }
    }
}
