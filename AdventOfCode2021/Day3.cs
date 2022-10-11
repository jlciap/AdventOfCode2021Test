namespace AdventOfCode2021
{

    public class Day3
    {


        private const string path = "Day3.txt";
        public List<string> reports = new List<string>() { };


        public void SetUp()
        {
            try
            {
                reports = File.ReadAllLines(path).Select(x => x.Trim()).ToList();
            }
            catch
            {
                Console.WriteLine("Couldn't find the file Day3.txt");
            }

        }

        public static long Pow(int a, int b)
        {
            long result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            return result;
        }
        public static long BinToDec(long BinaryNumber)
        {
            long ValueInDecimal = 0;
            int i = BinaryNumber.ToString().Length - 1;
            foreach (char digit in BinaryNumber.ToString())
            {
                ValueInDecimal += int.Parse(digit.ToString()) * Pow(2, i);
                i--;
            }

            return ValueInDecimal;
        }

        public long SolutionPart1()
        {
            string gamma = "";
            string epsilon = "";

            //outer loop is horizontal
            for (int i = 0; i < reports[0].Length; i++)
            {
                List<int> VerticalBits = new List<int>();

                for (int j = 0; j < reports.Count; j++)
                {
                    //inner loop is vertical
                    VerticalBits.Add(int.Parse(reports[j][i].ToString()));
                }


                int CountOf0s = 0;
                int CountOf1s = 0;

                foreach (int bit in VerticalBits)
                {
                    if (bit == 0)
                        CountOf0s++;
                    else
                        CountOf1s++;
                }


                if (CountOf1s >= CountOf0s)
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

            return BinToDec(long.Parse(gamma)) * BinToDec(long.Parse(epsilon));
        }



        public long giveOxygenGenerator()
        {
            //
            List<string> OxygenGeneratorList = new List<string>();
            OxygenGeneratorList = reports;

            for (int i = 0; i < reports[0].Length; i++)
            {
                List<int> VerticalBits = new List<int>();

                for (int j = 0; j < OxygenGeneratorList.Count; j++)
                {
                    VerticalBits.Add(int.Parse(OxygenGeneratorList[j][i].ToString()));
                }


                int CountOf0s = 0;
                int CountOf1s = 0;

                foreach (int bit in VerticalBits)
                {
                    if (bit == 0)
                        CountOf0s++;
                    else
                        CountOf1s++;
                }


                if (CountOf0s > CountOf1s)
                {
                    //prune off all members of OxygenGeneratorList starting with 0

                    List<string> newOxygenGeneratorList = new List<string>();

                    foreach (string line in OxygenGeneratorList)
                    {
                        newOxygenGeneratorList.Add(line);
                    }

                    foreach (string line in OxygenGeneratorList)
                    {
                        if (line[i] == '1')
                        {
                            newOxygenGeneratorList.Remove(line);
                        }
                    }

                    OxygenGeneratorList = newOxygenGeneratorList;

                }
                else
                {
                    //pruneoff all members of OxygenGeneratorList with 0

                    List<string> newOxygenGeneratorList = new List<string>();

                    foreach (string line in OxygenGeneratorList)
                    {
                        newOxygenGeneratorList.Add(line);
                    }


                    foreach (string line in OxygenGeneratorList)
                    {
                        if (line[i] == '0')
                        {
                            newOxygenGeneratorList.Remove(line);
                        }
                    }

                    OxygenGeneratorList = newOxygenGeneratorList;


                }

                if (OxygenGeneratorList.Count == 1)
                {
                    break;
                }
            }



            return BinToDec(long.Parse(OxygenGeneratorList[0]));
        }




        private long giveC02ScrubberRating()
        {
            //
            List<string> C02ScrubberList = new List<string>();
            C02ScrubberList = reports;

            for (int i = 0; i < reports[0].Length; i++)
            {
                List<int> VerticalBits = new List<int>();

                for (int j = 0; j < C02ScrubberList.Count; j++)
                {
                    VerticalBits.Add(int.Parse(C02ScrubberList[j][i].ToString()));
                }


                int CountOf0s = 0;
                int CountOf1s = 0;

                foreach (int bit in VerticalBits)
                {
                    if (bit == 0)
                        CountOf0s++;
                    else
                        CountOf1s++;
                }


                if (CountOf1s >= CountOf0s)
                {
                    //prune off all members of OxygenGeneratorList starting with 0

                    List<string> newC02ScrubberList = new List<string>();

                    foreach (string line in C02ScrubberList)
                    {
                        newC02ScrubberList.Add(line);
                    }

                    foreach (string line in C02ScrubberList)
                    {
                        if (line[i] == '1')
                        {
                            newC02ScrubberList.Remove(line);
                        }
                    }

                    C02ScrubberList = newC02ScrubberList;

                }
                else
                {
                    //pruneoff all members of OxygenGeneratorList with 0

                    List<string> newC02ScrubberList = new List<string>();

                    foreach (string line in C02ScrubberList)
                    {
                        newC02ScrubberList.Add(line);
                    }


                    foreach (string line in C02ScrubberList)
                    {
                        if (line[i] == '0')
                        {
                            newC02ScrubberList.Remove(line);
                        }
                    }

                    C02ScrubberList = newC02ScrubberList;


                }

                if (C02ScrubberList.Count == 1)
                {
                    break;
                }
            }



            return BinToDec(long.Parse(C02ScrubberList[0]));
        }

        public long SolutionPart2()
        {


            return giveOxygenGenerator() * giveC02ScrubberRating();

        }
    }

}
