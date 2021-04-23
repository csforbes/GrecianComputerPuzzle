﻿using System;

namespace GrecianComputerPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //innermost dial, rotating counterclockwise
            int?[,] dial1 =
            {
                { 10, null, 7, null, 15, null, 8, null, 3, null, 6, null },
                { null, null, null, null, null, null, null, null, null, null, null, null}
            };

            //second dial down, starting from the innermost ring
            int?[,] dial2 =
            {
                { 17, 7, 3, null, 6, null, 11, 11, 6, 11, null, 6 },
                { null, 4, null, 7, 15, null, null, 14, null, 9, null, 12 }
            };

            //third dial down
            int?[,] dial3 =
            {
                { 21, 17, 4, 5, null, 7, 8, 9, 13, 9, 7, 13 },
                { 18, 11, 26, 14, 1, 12, null, 21, 6, 15, 4, 9 },
                { null, 22, null, 16, null, 9, null, 5, null, 10, null, 8 }
            };

            //fourth dial down
            int?[,] dial4 =
            {
                { 16, 2, 7, null, 9, null, 7, 14, 11, null, 8, null },
                { 9, null, 9, 20, 12, 3, 6, null, 14, 12, 3, 8 },
                { 3, 12, 3, 26, 6, null, 2, 13, 9, null, 17, 19 },
                { 10, null, 1, null, 9, null, 12, null, 6, null, 10, null }
            };

            //fifth dial, bottom
            int?[,] dial5 =
            {
                { 11, 14, 11, 11, 14, 11, 14, 11, 14, 14, 11, 14 },
                { 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                { 9, 9, 4, 4, 6, 6, 3, 3, 14, 14, 21, 21 },
                { 7, 8, 8, 3, 4, 12, 2, 5, 10, 7, 16, 8 }
            };

            int?[][,] puzzle = { dial1, dial2, dial3, dial4, dial5 };



            Console.WriteLine("Hello World!");
        }
    }
}