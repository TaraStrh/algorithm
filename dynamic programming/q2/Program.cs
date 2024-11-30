using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
         var input = Console.ReadLine().Split();
        var freq = new long[100001];
        var dp = new long[100001];
         for (int i = 0; i < count; i++)
        {
            int num = int.Parse(input[i]);
            freq[num]++;
        }
        dp[1] = freq[1];
        for(int i=2 ; i<100001 ; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + freq[i] * i);
        }
    Console.WriteLine(dp[100000]);
    }
}



       
 

