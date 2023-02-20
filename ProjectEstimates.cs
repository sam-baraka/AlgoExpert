using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class ProjectResult
{

    /*
     * Complete the 'countPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY projectCosts
     *  2. INTEGER target
     */

    public static int countPairs(List<int> projectCosts, int target)
    {
        // The function returns the number of distinct pairs in projectCosts with an absolute difference equal to target.
        // The function accepts an integer array projectCosts and an integer target as parameters.
        // The function returns an integer denoting the number of distinct pairs in projectCosts with an absolute difference equal to target.
        
        int count = 0;
        for (int i = 0; i < projectCosts.Count; i++)
        {
            for (int j = i + 1; j < projectCosts.Count; j++)
            {
                if (Math.Abs(projectCosts[i] - projectCosts[j]) == target)
                {
                    count++;
                }
            }
        }
        return count;

}

// This is the optimal solution. It uses a dictionary to store the number of times a value appears in the array.
public static int countPairsOptimized(List<int> projectCosts, int target)
    {
        // The function returns the number of distinct pairs in projectCosts with an absolute difference equal to target.
        // The function accepts an integer array projectCosts and an integer target as parameters.
        // The function returns an integer denoting the number of distinct pairs in projectCosts with an absolute difference equal to target.
        
        int count = 0;
        var dictionaryStore = new Dictionary<int, int>();
        foreach (int x in projectCosts)
        {
            if (dictionaryStore.ContainsKey(x))
            {
                dictionaryStore[x]++;
            }
            else
            {
                dictionaryStore.Add(x, 1);
            }
        }
        foreach (int y in projectCosts)
        {
            if (target == 0)
            {
                count--;
            }
            if (dictionaryStore.ContainsKey(y + target))
            {
                count += dictionaryStore[y + target];
            }
            if (dictionaryStore.ContainsKey(y - target))
            {
                count += dictionaryStore[y - target];
            }
            
        }
        
        return count / 2;
        

}
class ProjectSolution
{
    public static void FMain(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

        int projectCostsCount = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> projectCosts = new List<int>();

        for (int i = 0; i < projectCostsCount; i++)
        {
            int projectCostsItem = Convert.ToInt32(Console.ReadLine()!.Trim());
            projectCosts.Add(projectCostsItem);
        }

        int target = Convert.ToInt32(Console.ReadLine()!.Trim());

        // int result = Result.countPairs(projectCosts, target);

        // textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}}
