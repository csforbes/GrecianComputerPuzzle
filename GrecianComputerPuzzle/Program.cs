using System;

namespace GrecianComputerPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Puzzle pozzle = new Puzzle();
            int[][] pizzle = pozzle.GetFaceValues();
            pozzle.RotateDialCounterClockwise(0, 1);
            pozzle.RotateDialCounterClockwise(1, 1);
            pizzle = pozzle.GetFaceValues();
        }
    }
}
