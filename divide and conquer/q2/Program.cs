using System;

class Program
{
    static void Main()
    {
         int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int target = int.Parse(Console.ReadLine());

        mergesort(array);

        Console.WriteLine(string.Join(" ", array));

        int index = binarysearch(array, target, 0, array.Length - 1);

        Console.WriteLine(index);
    }

    public static void mergesort(int[] array)
    {
        int length = array.Length;
        if(length <= 1)
        {
            return;
        }

        int middle = length / 2;
        int[] leftarray = new int[middle];
        int[] rightarray = new int[length - middle];
        for(int i = 0; i < length; i++)
        {
            if(i < middle)
            {
                leftarray[i] = array[i];
            }
            else
            {
                rightarray[i - middle] = array[i];
            }
        }

        mergesort(leftarray);
        mergesort(rightarray);
        merge(leftarray, rightarray, array);
    }

    public static void merge(int[] leftarray, int[] rightarray, int[] array)
    {
        int leftsize = leftarray.Length;
        int rightsize = rightarray.Length;

        int i = 0, l = 0, r = 0;
        while(l < leftsize && r < rightsize)
        {
            if(leftarray[l] < rightarray[r])
            {
                array[i++] = leftarray[l++];
            }
            else
            {
                array[i++] = rightarray[r++];
            }
        }

        while(l < leftsize)
        {
            array[i++] = leftarray[l++];
        }

        while(r < rightsize)
        {
            array[i++] = rightarray[r++];
        }
    }
    public static int binarysearch(int[]array , int target , int left , int right)
    {
        while(left<=right)
        {
            int middle = (left+right)/2;
            if(array[middle] == target)
            {
                return middle;
            }
            else
            {
                if(target > array[middle])
                {
                    left = middle+1;
                }
                else
                {
                    right = middle-1;
                }
            }
        }
        return -1;
    }
}
