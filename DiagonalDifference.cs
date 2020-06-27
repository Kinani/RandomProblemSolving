using System;
using System.Collections.Generic;

namespace RandomProblemSolving
{
    // https://www.hackerrank.com/challenges/diagonal-difference
    public static class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var firstDiagonalSum = 0;
            var secondDiagonalsum = 0;

            for (var (rowIndexStart, rowIndexEnd) = (0, arr.Count - 1);
                rowIndexStart < arr.Count; rowIndexStart++, rowIndexEnd--)
            {
                firstDiagonalSum += arr[rowIndexStart][rowIndexStart];
                secondDiagonalsum += arr[rowIndexStart][rowIndexEnd];
            }

            return Math.Abs(firstDiagonalSum - secondDiagonalsum);
        }
    }
}
