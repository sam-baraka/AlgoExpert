class SplitCharsProgram{
    static void MPain(string[] args){
        string s = "abc";
        var x= splitChars(s);
         foreach(var y in x){
              Console.WriteLine(x);
         }
    }

    static List<String> splitChars(string s)
    {
        List<char> characters = s.ToCharArray().ToList();
        if (characters.Count % 2 != 0)
        {
            characters.Add("_".ToCharArray()[0]);
        }
        List<String> output = new List<String>();
        for (int i = 0; i < characters.Count(); i += 2)
        {
            output.Add(joinChars(new List<char>{characters[i], characters[i + 1]}));
        }
        return output;
    }

    static String joinChars(List<char> value){
        return value[0].ToString() + value[1].ToString();
    }
}