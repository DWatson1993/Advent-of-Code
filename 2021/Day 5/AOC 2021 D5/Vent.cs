using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2021_D5
{
    class Vent
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public Vent(string x1, string y1, string x2, string y2) 
        {
            this.x1 = Convert.ToInt32(x1);
            this.y1 = Convert.ToInt32(y1);
            this.x2 = Convert.ToInt32(x2);
            this.y2 = Convert.ToInt32(y2);
        }

        public bool StraightLine() 
        {

            if (x1 == x2 || y1 == y2)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        public int[] MapSize() 
        {
            int[] highest = new int[2];
            
            if (x1 > x2)
            {
                highest[0] = x1;
            }
            else 
            {
                highest[0] = x2;
            }

            if (y1 > y2)
            {
                highest[1] = y1;
            }
            else
            {
                highest[1] = y2;
            }

            return highest;
        }

        public List<List<int>> StraightMark(List<List<int>> map) 
        {            
            if (x1 == x2)
            {
                int yStart = Math.Min(y1, y2);
                int yEnd = Math.Max(y1, y2);

                for (int i = yStart; i <= yEnd; i++) 
                {
                    map[i][x1]++;
                }
            }
            else 
            {
                int xStart = Math.Min(x1, x2);
                int xEnd = Math.Max(x1, x2);

                for (int i = xStart; i <= xEnd; i++)
                {
                    map[y1][i]++;
                }
            }

            return map;
        }
        public List<List<int>> DiagMark(List<List<int>> map) 
        {

            int x = x1;
            int y = y1;
            int r = 0;

            if (x1 < x2)
            {
                r = x2 + 1;
            }
            else 
            {
                r = x2 - 1;
            }

            while (x != r) 
            {
                if (x1 < x2) //direction right
                {
                    if (y1 < y2) //direction right + up
                    {
                        map[y][x]++;
                        x++;
                        y++;
                    }
                    else //direction right + down
                    {
                        map[y][x]++;
                        x++;
                        y--;
                    }
                }
                else //direction left
                {
                    if (y1 < y2) //direction left + up
                    {
                        map[y][x]++;
                        x--;
                        y++;
                    }
                    else //direction left + down
                    {
                        map[y][x]++;
                        x--;
                        y--;
                    }
                }
            }
            return map;
        }
    }
}
