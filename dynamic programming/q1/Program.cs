using System;
public class Program
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int n = s.Length;
        long[] vprefix = new long[n];
        long[] vsufix = new long[n];
        for (int i = 1; i < n; i++)
        {
            vprefix[i] = vprefix[i - 1];
            if (s[i] == 'v' && s[i - 1] == 'v')
            {
                vprefix[i]++;
            }
        }
        for (int i = n - 2; i >0; i--)
        {
            vsufix[i] = vsufix[i + 1];
            if (s[i] == 'v' && s[i + 1] == 'v')
            {
                vsufix[i]++;
            }
        }
        long count = 0;
        for (int i = 2; i < n - 2; i++) 
        {
            if (s[i] == 'o')
            {
                count += vprefix[i - 1] * vsufix[i + 1];
            }
        }
        Console.WriteLine(count);
    }
}
