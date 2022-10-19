using System;



public class ArrayOfProductsProgram
{

    public static void Main(string[] args)
    {

        int[] array = new int[] { 5, 1, 4, 2 };
        int[] result = ArrayOfProductsBruteforce(array);
        foreach(int a in result){
            Console.WriteLine(a+" ");
        }
    }

    /// <summary>
    /// O(n^2) time | O(n) space
    /// </summary> 
    
    public static int[] ArrayOfProductsBruteforce(int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            int product = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j)
                {
                    product *= array[j];
                }
            }
            result[i] = product;
        }
        return result;
    }

    public static int[] ArrayOfProducts(int[] array)
    {
        // Write your code here.
        var product=array.Aggregate((total, next) => total * next);
        return new int[] { product};
    }
}
