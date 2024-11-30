using System;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string[] lineSplit = line.Split(' ');
        double[] numbers = new double[lineSplit.Length];

        for (int i = 0; i < lineSplit.Length; i++)
        {
            numbers[i] = double.Parse(lineSplit[i]);
        }

        quicksort(numbers, 0, numbers.Length - 1);

        foreach (double num in numbers)
        {
            Console.Write(num + " ");
        }
    }
    public static void swap(double[] a, int i, int j)
    {
        double t = a[i];
        a[i] = a[j];
        a[j] = t;
    }
    
    public static int part(double[] a, int l, int r)
    {
        double pivot = a[l];
        int current = l;
        for (int j = l + 1; j <= r; j++)
        {
            if (a[j] < pivot)
            {
                current++;
                swap(a, current, j);
            }
        }
        swap(a, current, l);
        return current;
    }
    
    public static void quicksort(double[] a, int l, int r)
    {
        if (l < r)
        {
            int p1 = part(a, l, r);
            quicksort(a, l, p1 - 1);
            quicksort(a, p1 + 1, r);
        }
    }
}
