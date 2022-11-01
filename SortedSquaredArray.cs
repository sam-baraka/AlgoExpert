class SortedSquaredArrayProgram
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 3, 5, 6, 8, 9 };
        int[] result = OptimizedSortedSquaredArray(array);
        Console.WriteLine(string.Join(",", result));
    }

    /// Brute force solution
    /// This will run in O(n log n) time
   static public int[] SortedSquaredArray(int[] array)
    {
        int[] result=new int[array.Count()];
        for(int i=0;i<array.Count();i++){
            result[i]=array[i]*array[i];
        }
        Array.Sort(result);
        return result;
    }

    /// Optimized solution
    /// This will run in O(n) time
    static public int[] OptimizedSortedSquaredArray(int[] array){
        int[] result=new int[array.Count()];
        int startIndex=0;
        int endIndex=array.Count()-1;
        Array.Reverse(array);
        for(int i=0;i<array.Count();i++){
            var smallerValue=array[startIndex];
            var largerValue=array[endIndex];
            if (Math.Abs(smallerValue)>Math.Abs(largerValue)){
                result[i]=smallerValue*smallerValue;
                startIndex++;
            }else{
                result[i]=largerValue*largerValue;
                endIndex--;
            }
        }
        Array.Reverse(result);
        return result;
    }
}