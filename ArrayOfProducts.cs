using System;



public class ArrayOfProductsProgram
{

    public static void Main(string[] args)
    {

        int[] array = new int[] { 5, 1, 4, 2 };
        int[] result = ArrayOfProductsBruteforce(array);
        foreach (int a in result)
        {
            Console.WriteLine(a + " ");
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
    /// Another solution
    public static int[] ArrayOfProducts(int[] array){

          //First create an empty array of the same length
        int[] result = new int[array.Length];
    
        // Create a variable to hold the left running product
        int leftRunningProduct = 1;
        // Create a variable to hold the right running product
        int rightRunningProduct = 1;
        // Loop through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Set the left products array at the current index to the left running product
            result[i] = leftRunningProduct;
            // Set the left running product to the left running product times the current index
            leftRunningProduct *= array[i];
            // Set the right products array at the current index to the right running product
            rightProducts[array.Length - 1 - i] = rightRunningProduct;
            // Set the right running product to the right running product times the current index
            rightRunningProduct *= array[array.Length - 1 - i];
        }
        // Loop through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Set the result array at the current index to the left products array at the current index times the right products array at the current index
            result[i] = leftProducts[i] * rightProducts[i];
        }
        // Return the result array


        return result;

    }




    /// More optimized solution
    public static int[] ArrayOfProducts(int[] array)
    {
        //First create an empty array of the same length
        int[] result = new int[array.Length];
        // Create an array of the products of all the numbers to the left of the current index
        int[] leftProducts = new int[array.Length];
        // Create an array of the products of all the numbers to the right of the current index
        int[] rightProducts = new int[array.Length];
        // Create a variable to hold the left running product
        int leftRunningProduct = 1;
        // Create a variable to hold the right running product
        int rightRunningProduct = 1;
        // Loop through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Set the left products array at the current index to the left running product
            leftProducts[i] = leftRunningProduct;
            // Set the left running product to the left running product times the current index
            leftRunningProduct *= array[i];
            // Set the right products array at the current index to the right running product
            rightProducts[array.Length - 1 - i] = rightRunningProduct;
            // Set the right running product to the right running product times the current index
            rightRunningProduct *= array[array.Length - 1 - i];
        }
        // Loop through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Set the result array at the current index to the left products array at the current index times the right products array at the current index
            result[i] = leftProducts[i] * rightProducts[i];
        }
        // Return the result array


        return result;
    }
}
