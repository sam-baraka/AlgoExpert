class ProgramX
{
    static readonly string[] KEYS = { "0", "1", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

    static void Maain(string[] args)
    {
        string phoneNumber = "1905";
        List<string> results = new List<string>();
        GenerateMnemonics(phoneNumber, 0, new char[phoneNumber.Length], results);
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    static void GenerateMnemonics(string phoneNumber, int index, char[] current, List<string> results)
    {
        if (index == phoneNumber.Length)
        {
            results.Add(new string(current));
        }
        else
        {
            string letters = KEYS[phoneNumber[index] - '0'];
            foreach (char letter in letters)
            {
                current[index] = letter;
                GenerateMnemonics(phoneNumber, index + 1, current, results);
            }
        }
    }
}