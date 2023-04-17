class AreaSolution{
    public static void ain(string[] args){
        Console.WriteLine(getAreaSumRecursive(2));
    }

    static int getAreaSum(int n){
        int areaSum = 0;
        for (int i = 0; i <=n;i++) {
          areaSum = areaSum +i * i * i;
        }
        return areaSum;
    }
    // Same solution as above but with recursion
    static int getAreaSumRecursive(int n){
        return n == 0 ? 0 : n * n * n + getAreaSumRecursive(n - 1);
    }
     
}