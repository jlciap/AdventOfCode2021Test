using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public class Day4
    {
        private const string path = "Day4.txt";
        public List<string> lines = new List<string>();
        public List<int> bingoNumbers = new List<int>();
        public List<List<List<int>>> boards = new List<List<List<int>>>();


        public void SetUp()
        {
            try
            {
                lines = File.ReadAllLines(path).ToList();
               
            }
            catch
            {
                throw new FileNotFoundException("Couldn't find file");
            }

            bingoNumbers = lines[0].Split(",").Select(x => int.Parse(x)).ToList();


            int i = 2;
            //start on first line of first board
            while (i < lines.Count - 4)
            {
                List<List<int>> newBoard = new List<List<int>>();
                for (int j = 0; j < 5; j++)
                {   //each line gets added to the new board
                    newBoard.Add(lines[i].Split(" ").Where(x => x != "").Select(x => int.Parse(x)).ToList());
                    i++;
                }

                boards.Add(newBoard);
                //this skips the empty line between boards in the text file
                i++;
            }



        }


        private static bool checkBoard(List<List<int>> board)
        {
            //checks whether any rows or any columns match 500(i.e there is a hit on all numbers on a row and a colum)

            //row check

            for(int i = 0; i < 5; i++)
            {
                int rowSum = 0;

                for (int j = 0;j < 5;j++)
                {
                    rowSum += board[i][j];
                }

                if(rowSum == 500)
                {
                    return true;
                }
            }



            //column check

            for (int j = 0; j < 5; j++)
            {
                int columnSum = 0;

                for (int i=0; i<5; i++)
                {
                   columnSum += board[i][j];
                }

                if(columnSum == 500)
                {
                    return true;
                }
                

            }
            return false;
        }

        public int SolutionPart1()
        {


            foreach(var num in bingoNumbers)
            {
                // loop through each board and mark each matchin number in the board with a 100 to indicate a hit

                foreach (var board in boards)
                {
                    for(int i=0; i < 5; i++)
                    {
                        for(int j=0; j < 5; j++)
                        {
                            if(board[i][j] == num)
                            {
                                board[i][j] = 100;
                            }
                        }
                    }

                }

                // check which boards are "done"
                foreach(var board in boards)
                {
                    if (checkBoard(board))
                    {
                        int sum = 0;

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (board[i][j] != 100)
                                {
                                    sum += board[i][j];
                                }
                            }
                        }

                        return sum * num;
                    }

                }


            }


            return 0;
        }
    }
}
