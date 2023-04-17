

class PalindromeCheck{
    static void MMan(string[] args) {
        isPalindrome("abcdcba");
    }
    
    static bool isPalindrome(String val){
        return isPalindromeRecursiveHelper(val, 0);
    }
    static bool isPalindromeRecursiveHelper(String val, int i){
        int j = val.Length - 1 - i;
        return i >= j ? true : val[i] == val[j] && isPalindromeRecursiveHelper(val, i + 1);
    }
}