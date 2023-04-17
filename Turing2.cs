
class TuringSolution2
{ 
    // Maximum even number solution
    public static void Mmain(string[] args)
    {
        char [] space = new char[] {' '};
        var a = Console.ReadLine ();
        Console.WriteLine(getMaxEven(a!));
        
    }
    static string getMaxEven(String s){
        string maxEven = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string sub = s.Substring(i, j - i);
                if (int.TryParse(sub, out int num) && num % 2 == 0 && (maxEven == "" || num > int.Parse(maxEven)))
                {
                    maxEven = sub;
                }
            }
        }
    return maxEven;
    }

}