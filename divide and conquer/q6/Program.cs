using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] points = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        string line;
        List<Tuple<int, int>> segments = new List<Tuple<int, int>>();

        while ((line = Console.ReadLine()) != null && line != "")
        {
            var segment = line.Split(' ');
            int start = int.Parse(segment[0]);
            int end = int.Parse(segment[1]);
            segments.Add(new Tuple<int, int>(start, end));
        }
        int[] results = new int[points.Length];

        counting(segments, points, results, 0, points.Length - 1);
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    public static void counting(List<Tuple<int, int>> segments, int[] points, int[] results, int start, int end)
    {
        if (start == end)
        {
            int count = 0;
            foreach (var segment in segments)
            {
                if (points[start] >= segment.Item1 && points[start] <= segment.Item2)
                {
                    count++;
                }
            }
            results[start] = count;
        }
        else
        {
            int mid = (start + end) / 2;
            
            counting(segments, points, results, start, mid);
            counting(segments, points, results, mid + 1, end);

        }
    }
}
