

class InterviewProgram{
    static void Main(string[] args){


        // Test the IsABeforeB function
        string s = "aabbb";
        Console.WriteLine("Is {0} a valid string? {1}", s, IsABeforeB(s));
        s = "abab";
        Console.WriteLine("Is {0} a valid string? {1}", s, IsABeforeB (s));
        s = "abba";
        Console.WriteLine("Is {0} a valid string? {1}", s, IsABeforeB (s));
        s = "aabbb";
        Console.WriteLine("Is {0} a valid string? {1}", s, IsABeforeB(s));
        s="aaa";
        Console.WriteLine("Is {0} a valid string? {1}", s, IsABeforeB(s));
        s="b";
        Console.WriteLine("Is {0} a valid string? {1}", s, IsABeforeB(s));

    }
    // Write a function that given a string s consisting of n letters 'a' and or 'b' returns true when all occurences of letter 'a' are before all occurences of letter 'b' and false otherwise.
    // Example: s = "aabbb", returns true, s = "ba", returns false, s = "aaa", returns true, s = "b", returns true, s = "abba", returns false
    static bool IsABeforeB(string s){

        // Convert the string to a char array
        char[] charArray = s.ToCharArray();

        // Loop through the char array
        for(int i = 0; i < charArray.Length; i++){
            // If the current char is a, check if there is a b after it
            if(charArray[i] == 'a'){
                // If there is a b after it, return false
                if(s.IndexOf('b', i) > i){
                    return false;
                }
            }
        }
        // If we get here, then all a's are before all b's
        return true;
    }

}