using System;
using System.Linq;

namespace GrecianComputerPuzzle
{
    class Program
    {
        private static int[] GetColumn(int[][] faceValues, int col)
        {
            int[] column = new int[faceValues.Length];
            for (int row = 0; row < faceValues.Length; row++)
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

        private static bool VerifyColumns(int[][] faceValues, int targetSum)
        {
            bool hittingTarget;
            int colPosition = 0;

            do
            {
                int[] column = GetColumn(faceValues, colPosition);
                hittingTarget = VerifyColumn(column, targetSum);
                Console.Write(" {0} {1}", hittingTarget ? "✅" : "❌", column.Sum());
                colPosition++;
            }
            while (hittingTarget & (colPosition < faceValues[0].Length));
            Console.Write(Environment.NewLine);
            return hittingTarget;
        }

        public static bool CheckDialRotationReady(int circumference, int[] dialRotations, int dial)
        {
            if (dial == 0)
            { return true; }
            if ((dialRotations[dial - 1] == circumference) & CheckDialRotationReady(circumference, dialRotations, dial - 1))
            { return true; }
            else
            { return false; }
        }

        static void Main(string[] args)
        {
            int targetSumOfEachColumn = 42;
            bool solved = false;

            Puzzle pozzle = new Puzzle();
            int[] dialRotations = new int[pozzle.Diameter];
            do
            {
                int[][] faceValues = pozzle.GetFaceValues();
                Console.Write(String.Join(" ", dialRotations));
                solved = VerifyColumns(faceValues, targetSumOfEachColumn);
                if (solved == false)
                {
                    for(int dial = 0; dial < dialRotations.Length; dial++)
                    {
                        if (CheckDialRotationReady(pozzle.Circumference, dialRotations, dial))
                        {
                            pozzle.RotateDialCounterClockwise(dial, 1);
                            dialRotations[dial] += 1;
                            if (dialRotations[dial] == pozzle.Circumference + 1)
                            {
                                dialRotations[dial] = 1;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("🎊🎊🎊🎊🎊🎊🎊");
                    foreach (int[] row in faceValues)
                    {
                        Console.WriteLine(String.Join(" ", row));
                    }
                    break;
                }
            }
            while (solved == false);
            
        }
    }
}
