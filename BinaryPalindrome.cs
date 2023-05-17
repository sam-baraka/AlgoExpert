class BinaryPalindromeProgram{

    static void Main(string[] args){
        int n = 5;
        Console.WriteLine("Binary representation of {0} is {1}", n, Convert.ToString(n, 2));
        Console.WriteLine("Is {0} a binary palindrome? {1}", n, IsBinaryPalindrome(n));
    }

    static bool IsBinaryPalindrome(int n){
        // Convert the number to binary first
        string binaryNumber = Convert.ToString(n,2);
        string reverseNumber = string.Concat(binaryNumber.ToCharArray().Reverse());

        bool areEqual = binaryNumber.Equals(reverseNumber, StringComparison.OrdinalIgnoreCase);
        return areEqual;

    }
}