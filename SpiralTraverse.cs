using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;
public class SpiralTraverseProgram
{
    /// First operation with a multi dimensional array
	public static List<int> SpiralTraverse(int[,] array)
    {
        List<int> result = new List<int> { };
        int startRow = 0;
        /// The number of rows is the number of the first dimension
        int endRow = array.GetLength(0) - 1;
        int startColumn = 0;
        /// The number of colums is the number of the second dimension
        int endColumn = array.GetLength(1) - 1;

        while (startRow <= endRow && startColumn <= startRow)
        {
            /// Traverse the first row
            foreach (var col in Range(startColumn, endColumn + 1))
            {
                result.Append(array[startRow, col]);

            }
            /// Traverse the right border
            foreach (var row in Range(startRow + 1, endRow + 1))
            {
                result.Append(array[row, endColumn]);
            }

            foreach (var col in Range(startColumn, endColumn).Reverse())
            {
                result.Append(array[endRow, col]);
            }

            foreach (var row in Range(startRow + 1, endRow).Reverse())
            {
                result.Append(array[row, startColumn]);
            }

            // Move the bounds inwards
            startRow++;
            endRow--;
            startColumn++;
            endColumn--;

        }
        return result;
    }
}


/// recursive Method

/// O(n) time and O(n) space
class SpiralTraverseClass
{
    static List<int> spiralTraverse(int[,] array)
    {
        List<int> result = new List<int> { };
        fillTheLoop(array, 0, array.GetLength(0) - 1, 0, array.GetLength(1) - 1, result);
        return result;
    }

    static void fillTheLoop(int[,] array, int startRow, int endRow, int startColumn, int endColumn, List<int> result)
    {
        if (startRow > endRow || startColumn > startRow)
        {
            return;
        }
        else
        {
            foreach (var col in Range(startColumn, endColumn + 1))
            {
                result.Append(array[startRow, col]);

            }
            /// Traverse the right border
            foreach (var row in Range(startRow + 1, endRow + 1))
            {
                result.Append(array[row, endColumn]);
            }

            foreach (var col in Range(startColumn, endColumn).Reverse())
            {
                result.Append(array[endRow, col]);
            }

            foreach (var row in Range(startRow + 1, endRow).Reverse())
            {
                result.Append(array[row, startColumn]);
            }

        }
        fillTheLoop(array, startRow++, endRow--, startColumn++, endColumn--, result);
    }
}