using System;
using System.Collections.Generic;

public class Program
{
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        int position = 0;
        foreach (int arr in array)
        {
            if (position == sequence.Count)
            {
                break;
            }
            if (arr == sequence[position])
            {
                position++;
            }
            
        }
        return position==sequence.Count;
    }
}


/// Solution with two indexes

public class Program2
{
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        int positionArr = 0;
        int posiitonSeq = 0;
        /// First constrain the algo to these true values
        /// This algo will run in O(n) time and O(1) space
        while (positionArr < array.Count && sequence[posiitonSeq] < sequence.Count)
        {
            /// If we found the value increase the sequence positon
            if (array[positionArr] == sequence[posiitonSeq])
            {
                posiitonSeq++;
            }
            /// Increase the array position either way
            positionArr++;

        }
        return posiitonSeq == sequence.Count;
    }
}
