
public class LongestPeakProgram
{

    // public static void Main(string[] args)
    // {
    //     int[] array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
    //     Console.WriteLine(LongestPeak(array));
    // }
    public static int LongestPeak(int[] array)
    {
        /// Got this right 

        int peakLength = 0;
        // First find all the peaks, then compare to find the longest peak
        int i = 1;
        while (i < array.Length - 1)
        {
            // If its greater than the previous number and the next number
            // Then it is a peak
            // This is an if statement for peaks only
            if (array[i] > array[i-1] && array[i] > array[i+1])
            {
                int previousIndex = i - 2;
                int nextIndex = i + 2;
                while (previousIndex >= 0 && array[previousIndex] < array[previousIndex+1])
                {
                    previousIndex--;
                }
                while (nextIndex < array.Length && array[nextIndex] < array[nextIndex - 1])
                {
                    nextIndex++;
                }
                int currentPeakLength = nextIndex - previousIndex - 1;
                peakLength = Math.Max(currentPeakLength, peakLength);
                i = nextIndex;
            }else{
                i++;
            }
        }
        return peakLength;
    }
}
