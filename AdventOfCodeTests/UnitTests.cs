using AdventOfCode2021;
using Xunit;



namespace AdventOfCodeTests
{
    public class AdventOfCodeDay1
    {
        [Fact]
        public void TestDay1_Part1()
        {
            var day1 = new Day1();
            day1.SetUp();

            var result = day1.GiveSolutionPart1();

            Assert.Equal(1167, result);
        }

        [Fact]

        public void TestDay2_Part2()
        {
            var day1 = new Day1();
            day1.SetUp();


            var result = day1.GiveSolutionPart2();


            Assert.Equal(1129, result);
        }
    }


    public class AdventOfCodeDay2
    {
        [Fact]
        public void TestDay2SolutionPart1()
        {
            var day2 = new Day2();
            day2.SetUp();

            var result = day2.SolutionPart1();

            Assert.Equal(1989014, result);
        }

        [Fact]
        public void TestDay2SolutionPart2()
        {
            var day2 = new Day2();
            day2.SetUp();

            var result = day2.SolutionPart2();


            Assert.Equal(2006917119, result);
        }


    }


    public class AdventOfCodeDay3
    {
        [Fact]

        public void TestDay3SolutionPart1()
        {
            var day3 = new Day3();
            day3.SetUp();

            var result = day3.SolutionPart1();

            Assert.Equal(1131506, result);
        }

        [Fact]
        public void TestDay3SolutionPart2()
        {
            var day3 = new Day3();
            day3.SetUp();


            var result = day3.SolutionPart2();

            Assert.Equal(7863147, result);
        }






    }


    public class AdventOfCodeDay4
    {
        [Fact]

        public void TestDay4SolutionPart1()
        {
            var day4 = new Day4();
            day4.SetUp();

            var result = day4.SolutionPart1();

            Assert.Equal(54275, result);
        }

    }
}