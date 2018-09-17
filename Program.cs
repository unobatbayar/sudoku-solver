using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Sudoku {
        private int[][] rows;

        public Sudoku(int[][] rows)
        {

            if (rows.Length != 9 && rows[rows.Length].Length != 9)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.rows = rows;
        }

        public static void Main(String[] arcs)
        {
            int[][] sudokuPuzzle = new int[][] {
                new int[]{5,3,0,0,7,0,0,0,0},
                new int[]{6,0,0,1,9,5,0,0,0},
                new int[]{0,9,8,0,0,0,0,6,0},
                new int[]{8,0,0,0,6,0,0,0,3},
                new int[]{4,0,0,8,0,3,0,0,1},
                new int[]{7,0,0,0,2,0,0,0,6},
                new int[]{0,6,0,0,0,0,2,8,0},
                new int[]{0,0,0,4,1,9,0,0,5},
                new int[]{0,0,0,0,8,0,0,7,9}};

            Sudoku s = new Sudoku(sudokuPuzzle);
            Console.Write("Solving Sudoku \n");
            s.solveSudoku();
            Console.Write("Sudoku Solved \n");
            s.printSudoku();
            Console.WriteLine("stop");
        }

        public void printSudoku()
        {
            for (int x = 0; x < rows.Length; x++)
            {
                for (int y = 0;y < rows[x].Length; y++)
                {
                    Console.Write(rows[x][y]);
                }

                Console.Write("\n");
            }
        }

        public void solveSudoku()
        {
            ArrayList emptySquares = getEmptySquares();
            int row = 0;

            while (row < emptySquares.Count)
            {
                int squarePos = 0;
                ArrayList currentRow = (ArrayList)emptySquares[row];
                while (squarePos < currentRow.Count)
                {

                    bool insertNum = allPosibilities(row, (int)currentRow[squarePos], rows[row][(int)currentRow[squarePos]]);
                    if (!insertNum)
                    {
                        if (row == 0 && squarePos == 0)
                        { throw new Exception("This soduku puzzle is unsolveable"); }
                        else if (squarePos == 0)
                        {
                            row = row -1;currentRow = (ArrayList)emptySquares[row]; squarePos = currentRow.Count - 1;
                        }
                        else
                        {
                            squarePos = squarePos -1;
                        }
                    }
                    else {
                        squarePos++;
                    }
                }
                row++;
            }


        }

        public ArrayList getEmptySquares()
        {
            ArrayList empty = new ArrayList();
            for (int x = 0; x < rows.Length; x++)
            {
                ArrayList rows = new ArrayList();
                for (int y = 0; y < this.rows[x].Length; y++)
                {
                    if (this.rows[x][y] == 0)
                    {
                        rows.Add(y);
                    }
                }
                empty.Add(rows);
            }
            return empty;
        }

        public bool allPosibilities(int row, int pos, int start)
        {
            if (start > 9)
            {
                rows[row][pos] = 0;
                return false;
            }
            else if (!isInGrid(rows[row], pos, start) && !isRowRepeated(start, rows[row]) && !isColumnRepeated(start, pos))
            {
                rows[row][pos] = start;
                return true;
            }
            return allPosibilities(row, pos, start + 1);
        }

        public bool isColumnRepeated(int target, int column)
        {
            for (int x = 0; x < rows.Length; x++)
            {
                if (rows[x][column] == target)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isRowRepeated(int target, int[] row)
        {
            for (int x = 0; x < row.Length; x++)
            {
                if (row[x] == target)
                { return true; }
            }
            return false;
        }

        public bool isInGrid(int[] row, int pos, int num)
        {
            int rowStart = 0;
            int gridStart = getStartingPos(pos);

            for (int x = 0; x < rows.Length; x++)
            {
                if (rows[x] == row)
                {
                    rowStart = getStartingPos(x);
                    break;
                }
            }

            for (int x = rowStart; x < rowStart + 3; x++)
            {
                for (int y = gridStart; y < gridStart + 3; y++)
                {
                    if (rows[x][y] == num)
                    { return true; }
                }
            }
            return false;
        }

        public int getStartingPos(int pos)
        {
            if (pos < 3)
            { return 0; }
            if (pos >= 3 && pos < 6)
            { return 3; }
            return 6;
        }
    }
}
