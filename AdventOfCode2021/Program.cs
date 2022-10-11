namespace AdventOfCode2021
{
    internal class AdventOfCode2021
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" DAY 1");

            Day1 solution = new Day1();
            solution.SetUp();


            Console.WriteLine($"Answer to Part 1: {solution.GiveSolutionPart1()}");
            Console.WriteLine($"Answer to Part 2: {solution.GiveSolutionPart2()}");


            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" DAY 2");

            Day2 solutionDay2 = new Day2();
            solutionDay2.SetUp();

            Console.WriteLine($"Answer to Part 1 is {solutionDay2.SolutionPart1()}");
            Console.WriteLine($"Answer to Part2 is {solutionDay2.SolutionPart2()}");


            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" DAY 3");

            Day3 solutionDay3 = new Day3();
            solutionDay3.SetUp();

            Console.WriteLine($"Answer to Part 1 is {solutionDay3.SolutionPart1()}");
            Console.WriteLine($"Answer to Part2 is {solutionDay3.SolutionPart2()}");



            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" DAY 4");

            Day4 solutionDay4 = new Day4();
            solutionDay4.SetUp();


            Console.WriteLine($"Answer to Part 1 is {solutionDay4.SolutionPart1()}");






        }

    }
}
