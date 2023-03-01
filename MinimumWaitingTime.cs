
class MinimumWaitingTimeProgram{
    static void MainM(string[] args){
        int[] queries = {3, 2, 1, 2, 6};
        Console.WriteLine(MinimumWaitingTime(queries));
    }
/// <summary>
/// It doesnt make sense to execute the larger queries first
/// 
/// </summary>
/// <param name="queries"></param>
/// <returns></returns>
/// 

// Greedy solution (Brute force)
    public static int MinimumWaitingTime(int[] queries){
        // First sort it
        Array.Sort(queries);
        int[] waitingTimes =new int[queries.Count()];
        for (int i = 0; i < queries.Count();i++){
         if(i==0){
                waitingTimes[i] = 0;
            }
            else{
                waitingTimes[i] =waitingTimes[i-1]+  queries[i - 1];
            }
            
        }
       
        return waitingTimes.Sum();
    }
}