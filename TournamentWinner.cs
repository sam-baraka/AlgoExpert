using System.Collections.Generic;
using System;


public class TournamentWinnerProgram
{

    static void TMain(string[] args)
    {
        List<List<string>> competitions = new List<List<string>>();
        competitions.Add(new List<string>() { "HTML", "C#" });
        competitions.Add(new List<string>() { "C#", "Python" });
        competitions.Add(new List<string>() { "Python", "HTML" });
        List<int> results = new List<int>() { 0, 0, 1 };
        Console.WriteLine(OptimizedTournamentWinner(competitions, results));
    }

    /// This is a brute force solution
    /// Runs in O(n^2) time


    static public string TournamentWinner(List<List<string>> competitions, List<int> results)
    {
        String[] winners = new String[competitions.Count()];
        int currentFrequency = 0;
        String currentString = "";
        for (int i = 0; i < competitions.Count(); i++)
        {
            if (results[i] == 0)
            {
                /// Away team won
                winners[i] = competitions[i][1];
            }
            else if (results[i] == 1)
            {
                /// Home team won
                winners[i] = competitions[i][0];
            }

        }
        foreach (String x in winners)
        {
            int xCount = winners.Where(e => e == x).Count();
            if (xCount > currentFrequency)
            {
                currentFrequency = xCount;
                currentString = x;
            }
        }
        return currentString;
    }

    /// This is a more optimal solution
    /// Will use a little bit more space
    /// Will run in O(n) time and O(k) space

    static public string OptimizedTournamentWinner(List<List<string>> competitions, List<int> results)
    {
        Dictionary<String, int> resultMap = new Dictionary<string, int> { };
        for (int i = 0; i < competitions.Count(); i++)
        {

            if (results[i] == 0)
            {
                /// Away team won
                String currentString = competitions[i][1];
                if (resultMap.ContainsKey(currentString))
                {
                    int existingValue = resultMap[currentString];
                    resultMap[currentString] = 3 + existingValue;
                }
                else
                {
                    resultMap.Add(currentString, 3);
                }

            }
            else if (results[i] == 1)
            {

                /// Home team won
                String currentString = competitions[i][0];
                if (resultMap.ContainsKey(currentString))
                {
                    int existingValue = resultMap[currentString];
                    resultMap[currentString] = 3 + existingValue;
                }
                else
                {
                    resultMap.Add(currentString, 3);
                }
            }
        }
        return resultMap.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }
}

