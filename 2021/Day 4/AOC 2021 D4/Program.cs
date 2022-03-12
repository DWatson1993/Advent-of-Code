using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_2021_D4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("PuzzleInput.txt");

            string ballNumInput = input[0];

            string[] ballNums = ballNumInput.Split(",");

            List<Grid> gridData = ReadData(input[2..]);

            int ans1 = Part1(ballNums, gridData);

            gridData = ReadData(input[2..]);

            int ans2 = Part2(ballNums, gridData);

            Console.WriteLine(ans1);

            Console.WriteLine(ans2);

        }

        static List<Grid> ReadData(string[] input) 
        {
            List<Grid> grids = new List<Grid>();

            List<string> hList = new List<string>();

            foreach (string line in input) 
            {
                if (line != "") 
                {
                    hList.Add(line);
                }
                else
                {
                    Grid block = new Grid(hList);

                    grids.Add(block);

                    hList.Clear();
                }

            }

            return grids;

        }

        static int Part1(string[] ballNums, List<Grid> gridData) 
        {

            foreach (string ballNum in ballNums) 
            {
                foreach (var grid in gridData) 
                {
                    grid.Contains(ballNum);

                    if (grid.CheckIfWin()) 
                    {
                        int[] notWins = grid.GetNumbers();
                        int totalNotWin = notWins.Sum();

                        return totalNotWin * Convert.ToInt32(ballNum);

                    }
                    
                }

            }

            return 0;
        }

        static int Part2(string[] ballNums, List<Grid> gridData) 
        {

            Grid lastGridWin = new Grid();
            string lastBallNumWin = "";

            foreach (string ballNum in ballNums)
            {
                foreach (var grid in gridData)
                {
                    grid.Contains(ballNum);

                    if (grid.CheckIfWin() && grid.winner == false)
                    {
                        lastGridWin = grid;
                        lastBallNumWin = ballNum;
                        grid.winner = true;
                    }

                }

            }

            int[] notWins = lastGridWin.GetNumbers();
            int totalNotWin = notWins.Sum();

            return totalNotWin * Convert.ToInt32(lastBallNumWin);

        }
    }
}
