using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC_2021_D4
{
    public class Grid
    {
        List<List<string>> gridNums;
        List<List<bool>> mark;
        public bool winner = false;

        public Grid(List<string> input) 
        {
            gridNums = new List<List<string>>();
            mark = new List<List<bool>>();

            foreach (string line in input) 
            {
                string[] nums = line.Split(" ");
                List<string> numsCleaned = nums.Where(x => !string.IsNullOrEmpty(x)).ToList();

                gridNums.Add(numsCleaned);
            }

            for (int y = 0; y < gridNums.Count(); y++)
            {
                List<bool> listMarkToAdd = new List<bool>();

                for (int x = 0; x < gridNums[0].Count(); x++)
                {
                    listMarkToAdd.Add(false);
                }

                mark.Add(listMarkToAdd);
            }

        }

        public Grid() 
        {

        }

        public bool Contains(string ballNum) 
        {

            bool check = false;

            foreach (var line in gridNums) 
            {
                if (line.Contains(ballNum)) 
                {

                    if (winner == false) 
                    {
                        Mark(ballNum);
                    }

                    check = true;

                }
            }

            return check;
        }

        public void Mark(string ballNum) 
        {
            for (int y = 0; y < gridNums.Count(); y++) 
            {
                for (int x = 0; x < gridNums[0].Count(); x++) 
                {
                    if (gridNums[y][x] == ballNum) 
                    {
                        mark[y][x] = true;
                    }
                }
            }
        }

        public bool CheckIfWin() 
        {
            for (int y = 0; y < mark.Count(); y++)
            {
                int h = 0;
                int v = 0;

                for (int x = 0; x < mark[0].Count(); x++)
                {
                    if (mark[y][x] == true) 
                    {
                        h++;                        
                    }
                    if (mark[x][y] == true)
                    {
                        v++;
                    }
                }

                if (h == 5 || v == 5)
                {
                    return true;
                }
            }

            return false;
        }

        public int[] GetNumbers() 
        {
            List<int> nums = new List<int>();

            for (int y = 0; y < gridNums.Count(); y++)
            {
                for (int x = 0; x < gridNums[0].Count(); x++)
                {
                    if (mark[y][x] == false)
                    {
                        nums.Add(Convert.ToInt32(gridNums[y][x]));
                    }
                }
            }

            int[] numsArr = nums.ToArray();
            return numsArr;
        }

    }
}
