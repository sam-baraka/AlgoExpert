using System;




class Solution
{
    static public int solution(int[] A)
    {
        int N = A.Length;
        int[] B = new int[N];
        for (int i = 0; i < N; i++)
        {
            if (A[i] > 0 && A[i] <= N)
            {
                B[A[i] - 1] = 1;
            }
        }
        for (int i = 0; i < N; i++)
        {
            if (B[i] == 0)
            {
                return i + 1;
            }
        }
        return N + 1;
    }

    public static void SMain(string[] args)
    {
        int[] A = { 1, 3, 6, 4, 1, 2 };
        Console.WriteLine(solution(A));
    }
}

