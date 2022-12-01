using System;


public class NonConstructibleProgram {

	public int NonConstructibleChange(int[] coins) {
        Array.Sort(coins);
        int currentChangeCreated = 0;
        foreach (int coin in coins) {
            if (coin > currentChangeCreated + 1) {
                return currentChangeCreated + 1;
            }
            currentChangeCreated += coin;
        }
        return currentChangeCreated + 1;
		
	}
}
