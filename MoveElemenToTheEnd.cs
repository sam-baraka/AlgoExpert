using System;
using System.Collections.Generic;


public class MoveElementToEnd
{
    public static List<int> MoveElementToEndPro(List<int> array, int toMove)
    {
        int indexOne = 0;
        int indexTwo = array.Count - 1;
        while (indexOne < indexTwo)
        {
            while (indexTwo>indexOne&& array[indexTwo] == toMove)
            {
                indexTwo--;
            }
            if ( array[indexOne] == toMove)
            {
                int temp = array[indexOne];
                array[indexOne] = array[indexTwo];
                array[indexTwo] = temp;

            }
            else
            {
                indexOne++;
            }
        }
        return array;

    }
}



