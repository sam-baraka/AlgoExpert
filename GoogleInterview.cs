class GoogleInterviewProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine(Calculate());
    }

    /// Calculate value from string
    static int Calculate()
    {
        /// The answer should be 55
        /// Using a queue
        String toBeCalculated = "add(5,mul(2,pow(5,2)))";
        Queue<String> queue = new Queue<String>();
        String[] split = toBeCalculated.Split(new char[] { '(', ')', ',' });
        foreach (String s in split)
        {
            queue.Enqueue(s);
        }
        return CalculateValue(queue);

    }

    static int CalculateValue(Queue<String> queue)
    {
        String operation = queue.Dequeue();
        if (operation.Equals("add"))
        {
            return CalculateValue(queue) + CalculateValue(queue);
        }
        else if (operation.Equals("mul"))
        {
            return CalculateValue(queue) * CalculateValue(queue);
        }
        else if (operation.Equals("pow"))
        {
            return (int)Math.Pow(CalculateValue(queue), CalculateValue(queue));
        }
        else
        {
            return int.Parse(operation);
        }
    }

}