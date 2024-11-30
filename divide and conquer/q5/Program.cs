using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(mergesort(array));
    }

    public static int mergesort(int[] array)
    {
        int length = array.Length;
        int inversion = 0;

        if (length <= 1)
        {
            return inversion;
        }

        int middle = length / 2;
        int[] leftarray = new int[middle];
        int[] rightarray = new int[length - middle];
        for (int i = 0; i < length; i++)
        {
            if (i < middle)
            {
                leftarray[i] = array[i];
            }
            else
            {
                rightarray[i - middle] = array[i];
            }
        }
        inversion += mergesort(leftarray);
        inversion += mergesort(rightarray);
        inversion += merge(leftarray, rightarray, array);
        
        return inversion;
    }

    public static int merge(int[] leftarray, int[] rightarray, int[] array)
    {
        int leftsize = leftarray.Length;
        int rightsize = rightarray.Length;

        int i = 0, l = 0, r = 0;
        int inversion = 0;
        while (l < leftsize && r < rightsize)
        {
            if (leftarray[l] <= rightarray[r])
            {
                array[i++] = leftarray[l++];
            }
            else
            {
                array[i++] = rightarray[r++];
                inversion += (leftsize - l);
            }
        }

        while (l < leftsize)
        {
            array[i++] = leftarray[l++];
        }

        while (r < rightsize)
        {
            array[i++] = rightarray[r++];
        }

        return inversion;
    }
}
