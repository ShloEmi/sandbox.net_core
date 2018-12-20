using System;
using System.Collections.Generic;
using System.Linq;


namespace problem28_Number_spiral_diagonals
{
    internal class Program
    {
        private static void Main()
        {
            int[,] matrix = GenerateSpiralMatrix(1001);
            IEnumerable<int[]> diagonals = GetDiagonals(matrix);
            var diagonalsSum = diagonals.SelectMany(d => d).Sum();
            Console.WriteLine($"Diagonals Sum = {diagonalsSum}");
        }

        private static IEnumerable<int[]> GetDiagonals(int[,] matrix)
        {
            var matrixLength = matrix.GetLength(0);
            var diagonals = new List<int[]>
            {
                new int[matrixLength],
                new int[matrixLength]
            };

            var idx = 10;
            for (int i0 = idx; i0 < 12; i0++)
            for (int i1 = 0; i1 < matrixLength; i1++)
                diagonals[i0-idx][i1] = i0 * i1;
            
            return diagonals;
        }

        private static int[,] GenerateSpiralMatrix(int size)
        {
            var spiralMatrix = new int[size, size];

            var length0 = spiralMatrix.GetLength(0);
            var length1 = spiralMatrix.GetLength(1);

            for (int i0 = 0; i0 < length0; i0++)
            for (int i1 = 0; i1 < length1; i1++)
                spiralMatrix[i0, i1] = i0 * i1;

            return spiralMatrix;
        }
    }
}