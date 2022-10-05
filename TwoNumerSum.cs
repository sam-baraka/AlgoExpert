/// <summary>
/// Two number sum problem.
/// Solution with hashmaps.
/// This will run in 0(n) time and O(n) space.
/// </summary>
public class TwoNumberProgram
{
    public static int[] TwoNumberSum(int[] array, int targetSum)
    {
        /// Dictionary is c#'s implementation of the hashmap
        Dictionary<int, bool> nums = new Dictionary<int, bool>();
        /// Loop through the array first
        foreach (int num in array)
        {
            if (nums.ContainsKey(targetSum - num))
            {
                return new int[] { num, targetSum - num };
            }
            else
            {
                nums.Add(num, false);
            }

        }
        return new int[] { }; // If we don't find anything, return an empty array
    }
}


/// <summary>
/// Two number sum problem.
/// Solution with two pointers.
/// This will run in 0(nlog(n)) time and O(1) space.
/// </summary>

public class TwoNumberProgram2 {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		Array.Sort(array);
        var l=0;
        var r=array.Count()-1;
        while(r>l){
            var currentSum=array[l]+array[r];
            if (currentSum==targetSum){
                return new int[] {array[l],array[r]};
            }
            else if(targetSum>currentSum){
                l++;
            }
            else if(targetSum<currentSum){
                r--;
            }
        }
        return new int[]{};
	}
}