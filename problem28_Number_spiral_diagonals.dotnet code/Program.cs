using System;
using System.Collections.Generic;
using System.Linq;

namespace problem28_Number_spiral_diagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GenerateSpiralMatrix(1001);
            IEnumerable<int[]> diagonals = GetDiagonals(matrix);
            var diagonalsSum = diagonals.Sum(d=>d[0]);
            Console.WriteLine($"Diagonals Sum = {diagonalsSum}");
        }

        private static IEnumerable<int[]> GetDiagonals(int[,] matrix)
        {
            var matrixLength = matrix.GetLength(0);
            var diagonals = new List<int[]>();
            diagonals.Add(new int[matrixLength]);
            diagonals.Add(new int[matrixLength]);
            return diagonals;
        }

        private static int[,] GenerateSpiralMatrix(int size)
        {
            var spiralMatrix = new int[size,size];
            return spiralMatrix;
        }
    }
}
