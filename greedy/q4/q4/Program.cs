using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        if (k > n || k > (n / 2))
        {
            Console.WriteLine("Impossible");
            return;
        }

        List<int> result = new List<int>();

        for (int start = 1; start <= k; start++)
        {
            for (int i = start; i <= n; i += k)
            {
                result.Add(i);
            }
        }
        for (int i = 1; i < result.Count; i++)
        {
            if (Math.Abs(result[i] - result[i - 1]) < k)
            {
                Console.WriteLine("Impossible");
                return;
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
