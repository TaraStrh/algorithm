using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        List<(int x, int y)> points = new List<(int x, int y)>();
        for (int i = 0; i < input.Length; i += 2)
        {
            int x = int.Parse(input[i]);
            int y = int.Parse(input[i + 1]);
            points.Add((x, y));
        }
         points.Sort((a, b) => a.x.CompareTo(b.x));
          double answer =  minimumintotal(points, 0, points.Count - 1);
        Console.WriteLine(answer.ToString("F5"));
    }

    public static double Distance((int x, int y) p1, (int x, int y) p2)
    {
        int dx = p1.x - p2.x;
        int dy = p1.y - p2.y;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }

    public static double minimumintotal(List<(int x, int y)> points, int left, int right)
    {
        if (right - left <= 3)
        {
            double minimum = double.MaxValue;
            for (int i = left; i < right; i++)
            {
                for (int j = i + 1; j <= right; j++)
                {
                    minimum = Math.Min(minimum, Distance(points[i], points[j]));
                }
            }
        return minimum;
        }
        else
        {
            int mid = (left + right) / 2;
            double dleft = minimumintotal(points, left, mid);
            double dright = minimumintotal(points, mid + 1, right);
            double min = Math.Min(dleft, dright);
            return min;
        }
    }
}
