using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC_2021_D5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("PuzzleInput.txt");

            var coordinates = ReadData(input);

            int[] mapSize = GetHighest(coordinates);

            List<List<int>> map = CreateMap(mapSize);

            int ans1 = Part1(coordinates, map);

            map = CreateMap(mapSize);

            int ans2 = Part2(coordinates, map);

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }

        static List<Vent> ReadData(string[] input) 
        {
            List<Vent> coordinates = new List<Vent>();

            foreach (var line in input) 
            {
                string[] splitLines = line.Split(" -> ");

                string[] start = splitLines[0].Split(",");

                string[] end = splitLines[1].Split(",");

                string x1 = start[0];
                string y1 = start[1];
                string x2 = end[0];
                string y2 = end[1];

                Vent coordinatesToAdd = new Vent(x1, y1, x2, y2);
                coordinates.Add(coordinatesToAdd);
            }

            return coordinates;
        }

        static List<List<int>> CreateMap(int[] mapSize)
        {

            int x = mapSize[0];
            int y = mapSize[1];
            int[] xToAdd = new int[x];
            List<List<int>> map = new List<List<int>>();

            for (int h = 0; h < x; h++)
            {
                xToAdd[h] = 0;
            }

            for (int v = 0; v < y; v++)
            {
                map.Add(xToAdd.ToList());
            }

            return map;
        }

        static int[] GetHighest(List<Vent> coordinates) 
        {
            int x = 0;
            int y = 0;

            foreach (var vent in coordinates) 
            {
                int[] nums = vent.MapSize();

                if (nums[0] > x) 
                {
                    x = nums[0];
                }

                if (nums[1] > y)
                {
                    y = nums[1];
                }
            }

            int[] result = { x + 1, y + 1 };

            return result;
        }

        static int Part1(List<Vent> coordinates, List<List<int>> map) 
        {
            foreach (var vent in coordinates) 
            {
                if (vent.StraightLine()) 
                {
                    map = vent.StraightMark(map);
                }
            }

            int count = 0;

            for (int y = 0; y < map.Count(); y++) 
            {

                for (int x = 0; x < map[0].Count(); x++) 
                {
                    if (map[y][x] > 1) 
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static int Part2(List<Vent> coordinates, List<List<int>> map) 
        {
            foreach (var vent in coordinates)
            {
                if (vent.StraightLine())
                {
                    map = vent.StraightMark(map);
                }
                else 
                {
                    map = vent.DiagMark(map);
                }
            }

            int count = 0;

            for (int y = 0; y < map.Count(); y++)
            {

                for (int x = 0; x < map[0].Count(); x++)
                {
                    if (map[y][x] > 1)
                    {
                        count++;
                    }
                }
            }

            return count;

        }
    }
}
