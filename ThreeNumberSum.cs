public class ThreeNumberProgram
{

    public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
    {
        /// First sort the array
        Array.Sort(array);
        List<int[]> res = new List<int[]> { };
        /// Loop through the array first
        for (int i = 0; i < array.Length - 2; i++)
        {
            int indexL = i + 1;
            int indexR = array.Length - 1;

            // Constrain everything to R being greater than L
            while (indexR > indexL)
            {
                int sum = array[indexL] + array[indexR] + array[i];
                if (sum == targetSum)
                {
                    res.Add(new int[] { array[i], array[indexL], array[indexR] });
                    indexL++;
                    indexR--;
                }
                else if (sum > targetSum)
                {
                    indexR--;
                }
                else if (sum < targetSum)
                {
                    indexL++;
                }

            }


        }
        return res;
    }
}

/// <summary>
/// Three number sum problem.
/// Solution the brute force way
/// This will run in 0(n^3) time and O(n) space.
/// </summary>
public class ThreeNumberProgramBruteForce
{
    public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
    {
        List<int[]> res = new List<int[]> { };
        /// Loop through the array first
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == targetSum)
                    {
                        res.Add(new int[] { array[i], array[j], array[k] });
                    }
                }
            }
        }
        return res;
    }
}
