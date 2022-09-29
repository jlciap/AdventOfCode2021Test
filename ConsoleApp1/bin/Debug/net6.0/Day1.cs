namespace AdventOfCode2021
{
    public class Day1
    {
        private const string Path = "Day1.txt";
        private List<int> depths = new List<int> { };
        public void SetUp()
        {
            try
            {
                depths = File.ReadAllLines(Path)
                    .Select(x => int.Parse(x.Trim()))
                    .ToList();

            }
            catch
            {
                Console.WriteLine("Something went wrong in trying to locate the file. Please check the path.");
            }
        }


        public int GiveSolutionPart1()
        {
            int HasIncreased = 0;

            for (int i = 1; i < depths.Count; i++)
            {
                if (depths[i] > depths[i - 1])
                {
                    HasIncreased++;
                }
            }

            return HasIncreased;
        }

        public int GiveSolutionPart2()
        {
            int HasIncreased3Window = 0;


            for (int i = 1; i < depths.Count - 3; i++)
            {
                try
                {
                    if (depths[i + 3] > depths[i])
                    {
                        HasIncreased3Window++;
                    }

                }
                catch
                {
                    Console.WriteLine($"Error:Index out of range for value of i being {i}");
                }
            }
            return HasIncreased3Window;
        }


    }
}