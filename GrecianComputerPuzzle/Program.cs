using System;
using System.Linq;

namespace GrecianComputerPuzzle
{
    class Program
    {
        private static int[] GetColumn(int[][] faceValues, int col)
        {
            int[] column = new int[faceValues.Length];
            for (int row = 0; row < faceValues.Length; row++) //change to for st.
            {
                column[row] = faceValues[row][col];
            }
            return column;
        }

        private static bool VerifyColumn(int[] column, int targetSum)
        {
            if (targetSum == column.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Puzzle pozzle = new Puzzle();
            int[][] faceValues = pozzle.GetFaceValues();
            int[] column = GetColumn(faceValues, 0);




            foreach (int num in column)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            pozzle.RotateDialCounterClockwise(0, 1);
            pozzle.RotateDialCounterClockwise(1, 1);
            faceValues = pozzle.GetFaceValues();
            column = GetColumn(faceValues, 0);
            foreach (int[] row in faceValues)
            {
                Console.WriteLine(String.Join(" ", row));
            }
            Console.WriteLine(String.Join(" ", column));
        }
    }
}
