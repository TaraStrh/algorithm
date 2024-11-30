using System;
public class Program
{
    static void Main(string[]args)
    {
        string[] input = Console.ReadLine().Split();
        int t = int.Parse(input[0]);
        int k= int.Parse(input[1]);
        List<(int a, int b)> tests = new List<(int a, int b)>();
        long[] dp = new long[100001];
        for(int i=0 ; i<t ; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            int a = int.Parse(input2[0]);
            int b = int.Parse(input2[1]);
            tests.Add((a,b));
        }
        dp[0] =1;
        for(int i=1 ; i<= 100000 ;i++)
        {
            dp[i] = dp[i-1];
            if(i>=k)
            {
                dp[i] = (dp[i]+dp[i-k]) %1000000007;
            }
        }
        long[] prefixSum = new long[100000 + 1];
        for (int i = 1; i <= 100000; i++)
        {
            prefixSum[i] = (prefixSum[i - 1] + dp[i]) % 1000000007;
        }
        foreach (var test in tests)
        {
            int a = test.a;
            int b = test.b;

            long result = (prefixSum[b] - prefixSum[a - 1] + 1000000007) % 1000000007;
            Console.WriteLine(result);
        }
    }
}