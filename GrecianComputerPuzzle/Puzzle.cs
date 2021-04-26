using System;
namespace GrecianComputerPuzzle
{
    public class Puzzle
    {
        private int?[][,] dials = new int?[][,]
        {
            new int?[,] //innermost dial, rotating counterclockwise
            {
                { 10, null, 7, null, 15, null, 8, null, 3, null, 6, null }
            },
            new int?[,] //second dial down, starting from the innermost ring
            {
                { 17, 7, 3, null, 6, null, 11, 11, 6, 11, null, 6 },
                { null, 4, null, 7, 15, null, null, 14, null, 9, null, 12 }
            },
            new int?[,] //third dial down
            {
                { 21, 17, 4, 5, null, 7, 8, 9, 13, 9, 7, 13 },
                { 18, 11, 26, 14, 1, 12, null, 21, 6, 15, 4, 9 },
                { null, 22, null, 16, null, 9, null, 5, null, 10, null, 8 }
            },
            new int?[,] //fourth dial down
            {
                { 16, 2, 7, null, 9, null, 7, 14, 11, null, 8, null },
                { 9, null, 9, 20, 12, 3, 6, null, 14, 12, 3, 8 },
                { 3, 12, 3, 26, 6, null, 2, 13, 9, null, 17, 19 },
                { 10, null, 1, null, 9, null, 12, null, 6, null, 10, null }
            },
            new int?[,] //fifth dial, bottom
            {
                { 11, 14, 11, 11, 14, 11, 14, 11, 14, 14, 11, 14 },
                { 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                { 9, 9, 4, 4, 6, 6, 3, 3, 14, 14, 21, 21 },
                { 7, 8, 8, 3, 4, 12, 2, 5, 10, 7, 16, 8 }
            }
        };

        public int Circumference { get { return dials[0].GetLength(1); }}

        public int Diameter { get { return dials[dials.Length - 1].GetLength(0); }}

        public int[,] GetFaceValues()
        {
            
            int[,] faceValues = new int[Diameter, Circumference];
            //for each place in faceValues, get the top available number at that level
            for (int y = 0; y < Diameter; y++)
            {
                for (int x = 0; x < Circumference; x++)
                {
                    int depth = y + 0;
                    int? value = dials[depth][y, x];
                    while (value is null)
                    {
                        depth++;
                        value = dials[depth][y, x];
                    }
                    faceValues[y, x] = (int)value;
                }
            }
            return faceValues;
        }

        //public void RotateDial(int dial, bool direction, int places)
        

        public Puzzle()
        {
            
        }

    }
}
