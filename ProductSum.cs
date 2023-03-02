class ProducrSum{
       static void MainP(string[] args){
        // The answer is 12
        
        Console.WriteLine(ProductSum(new List<object> {5, 2, new List<object> {7, -1}, 3, new List<object> {6, new List<object> {-13, 8}, 4}}));
    }

    public static int ProductSum(List<object> array){
        return ProductSumHelper(array, 1);
    }

    public static int ProductSumHelper(List<object> array, int multiplier){
        int sum = 0;
        foreach(object a in array){
            if(a is List<object>){
                sum += ProductSumHelper((List<object>)a, multiplier + 1);

            }else if(a is int){
                sum += (int)a;

            }
        }
        return sum * multiplier;
    }
}


