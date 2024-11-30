using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine().Trim());
        
        for (int i = 0; i < t; i++)
        {
            // Use an array to store inputs for n, m, and p
            long[] inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(), long.Parse);
            long n = inputs[0]; // Students from department 1
            long m = inputs[1]; // Students from department 2
            long p = inputs[2]; // Professors

            Console.WriteLine(MaxHappyPairs(n, m, p));
        }
    }

    static long MaxHappyPairs(long n, long m, long p)
    {
        long totalPeople = n + m + p;
        long numTables = totalPeople / 4;

        long maxPairs = 0;

        // Place as many professors as possible
        long professorsUsed = Math.Min(numTables, p);
        maxPairs += professorsUsed * 4;

        // Remaining tables to be filled with students
        long remainingTables = numTables - professorsUsed;

        // Use students from different departments
        long pairsFromDifferentStudents = Math.Min(n, m) * 2;
        long remainingPairs = remainingTables * 4 - pairsFromDifferentStudents;

        if (remainingPairs > 0)
        {
            long sameDeptPairs = Math.Min(remainingPairs, (n - pairsFromDifferentStudents / 2) + (m - pairsFromDifferentStudents / 2));
            maxPairs += sameDeptPairs;
        }

        return maxPairs;
    }
}
