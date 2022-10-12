using System;
using System.Linq;

public class SmallestDifferenceProgram
{
    public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
    {
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);
        int indexOne = 0;
        int indexTwo = 0;
        var smallestDifference = double.PositiveInfinity;
        var currentDifference = double.PositiveInfinity;
        int[] smallestPair = new int[2];
        while (indexOne < arrayOne.Count() && indexTwo < arrayTwo.Count())
        {
            var firstNumber = arrayOne[indexOne];
            var secondNumber = arrayTwo[indexTwo];
            currentDifference = Math.Max(firstNumber, secondNumber) - Math.Min(secondNumber, firstNumber);
            if (firstNumber == secondNumber)
            {

                return new int[] { firstNumber, secondNumber };
            }
            else if (firstNumber > secondNumber)
            {
                currentDifference = firstNumber - secondNumber;
                indexTwo++;
            }
            else if (secondNumber > firstNumber)
            {
                currentDifference = secondNumber - firstNumber;
                indexOne++;
            }
            if (smallestDifference > currentDifference)
            {
                smallestDifference = currentDifference;
                smallestPair = new int[] { firstNumber, secondNumber };
            }
        }
        return smallestPair;
    }
}


public class SmallestDifferenceProgramBruteForce
{
    // The brute force way
    public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
    {
        int[] smallestPair = new int[2];
        var smallestDifference = double.PositiveInfinity;
        var currentDifference = double.PositiveInfinity;
        for (int i = 0; i < arrayOne.Length; i++)
        {
            for (int j = 0; j < arrayTwo.Length; j++)
            {
                currentDifference = Math.Max(arrayOne[i], arrayTwo[j]) - Math.Min(arrayOne[i], arrayTwo[j]);
                if (smallestDifference > currentDifference)
                {
                    smallestDifference = currentDifference;
                    smallestPair = new int[] { arrayOne[i], arrayTwo[j] };
                }
            }
        }
        return smallestPair;

    }
}