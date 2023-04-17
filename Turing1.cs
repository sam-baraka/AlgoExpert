class TuringSolution
{
    public static void MMain(string[] args)
    {
        var space = new char[] { ' ' };
        var input = Console.ReadLine()!.Split(space);
        var k  = input.ToList().Select(int.Parse).ToArray();
        var n = Console.ReadLine()!;
        var b = Console.ReadLine()!;
        var d = Console.ReadLine()!;
        var output = WorkoutProgress(k, int.Parse(n), int.Parse(b), int.Parse(d));
        Console.WriteLine(output);
    }


    static public int WorkoutProgress(int[] cals, int d, int min, int max)
{
    int score = 0;
    for (int i = 0; i <= cals.Length - d; i++)
    {
        int total = 0;
        for (int j = i; j < i + d; j++)
        {
            total += cals[j];
        }
        if (total < min)
            score--;
        else if (total > max)
            score++;
    }
    return score;
}
}