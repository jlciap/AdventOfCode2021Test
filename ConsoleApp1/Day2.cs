

using System.IO;
using System.Collections.Generic;


namespace AdventOfCode2021
{
    public class Day2
    {
        private const string path = "Day2.txt";
        public List<string> directions = new List<string> { };



        public void SetUp()
        {
            try
            {
                directions = File.ReadAllLines(path).ToList();

            }
            catch
            {
                throw new FileNotFoundException("Couldn't find file");
            }
        }


        public int SolutionPart1()
        {
            int horizontal = 0;
            int depth = 0;

            foreach (string line in directions)
            {
                string direction = line.Split(" ")[0];
                int distance = int.Parse(line.Split(" ")[1]);

                switch (direction.ToLower())
                {
                    case "forward":
                        horizontal += distance;
                        break;

                    case "down":
                        depth += distance;
                        break;

                    case "up":
                        depth -= distance;
                        break;
                    default:
                        break;
                }

            }

            return horizontal * depth;
        }


        public long SolutionPart2()
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (string line in directions)
            {
                string direction = line.Split(" ")[0];
                int distance = int.Parse(line.Split(" ")[1]);

                switch (direction.ToLower())
                {
                    case "forward":
                        horizontal += distance;
                        depth += aim * distance;
                        break;

                    case "down":
                        aim += distance;
                        break;

                    case "up":
                        aim -= distance;
                        break;
                    default:
                        break;
                }

            }

            return horizontal * depth;


        }




    }





}