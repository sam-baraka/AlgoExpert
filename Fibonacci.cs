using System;

public class FibonacciProgram {

    static void FMain(string[] args)
    {
        Console.WriteLine(GetNthFib(6));
    }
    // O(2^n) time | O(n) space
    // This is a recursive solution/ Brute force solution

	// public static int GetNthFib(int n) {
    //     // Write your code here.
    //     if(n==1){
    //         return 0;
    //     }else if(n==2){
    //         return 1;
    //     }else{
    //         return GetNthFib(n-1)+GetNthFib(n-2);
    //     }
		
	// }

    // O(n) time | O(n) space
    // This is a recursive solution with memoization
   
    // public static int GetNthFib(int n, Dictionary<int, int>? memoize = null) {
    //     if(memoize==null){
    //         memoize=new Dictionary<int, int>(){
    //             {1,0},
    //             {2,1}
    //         };
    //     }

    //     if(memoize.ContainsKey(n)){
    //         return memoize[n];
    //     }else{
    //         if(n==1){
    //             return 0;
    //         }else if(n==2){
    //             return 1;
    //         }else{
    //             memoize[n]=GetNthFib(n-1,memoize)+GetNthFib(n-2,memoize);
    //             return memoize[n];
    //         }
    //     }
    // }


    // O(n) time | O(1) space
    public static int GetNthFib(int n) {
        var lastTwo = new int[] {0,1};
        int counter = 3;
        while(counter<=n){
            int nextFib = lastTwo[0]+lastTwo[1];
            lastTwo[0]=lastTwo[1];
            lastTwo[1]=nextFib;
            counter++;
        }
        return n>1?lastTwo[1]:lastTwo[0];

    }
}
