using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Linq;

public class Program
{
    static void Main(string[]args)
    {
        int n = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(); 
        int[] numbers = Array.ConvertAll(input , int.Parse);
        int k= int.Parse(Console.ReadLine());
        int[] dp = new int[n+1];
        List <int> sum = new List<int>();
        for(int i=1 ; i<=n ; i++)
        {
            dp[i] = dp[i-1]+numbers[i-1];
        }
        for(int i=0 ; i<n ; i++)
        {
            for(int j=i+1 ; j<= n; j++)
            {
                sum.Add(dp[j] - dp[i]);
            }
        }
    sum.Sort((a , b)=>b.CompareTo(a));
    Console.WriteLine(sum[k-1]);

    }
}