// A string str contains a list of colors separated by a single space.
// Colors in str are mixed up, but each color has its original position at the end of the color name
// positions are 1-indexed, so the first color is at position 1, the second color is at position 2, etc.

// Given str with rearanged colors, sort the colors to the original order and return the sorted string.

// Example
// str = "red2 blue5 black4 green1 gold3"
// output: "green red gold black blue"

class SOlutionClass{
    public string solution(String s){
        string[] colors = s.Split(' ');
        string[] sortedColors = new string[colors.Length];
        foreach (var color in colors)
        {
            int position = int.Parse(color.Substring(color.Length - 1));
            sortedColors[position - 1] = color.Substring(0, color.Length - 1);
        }
        return string.Join(" ", sortedColors);
    }
}


//Given an array of integers arr, a lucky integer is an integer which has a frequency (how many times an element occurs within the array) in the array equal to its value.

class Solution{
    public int solution(int[] arr){
        var dict = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }
        int max = -1;
        foreach (var key in dict.Keys)
        {
            if (key == dict[key] && key > max)
            {
                max = key;
            }
        }
        return max;
    }
}


