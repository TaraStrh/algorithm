using System;

public class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int result = majority(array, 0, array.Length - 1);
        if(result == -1)
        Console.WriteLine("0");
        else
        Console.WriteLine("1");
    }

    public static int majority(int[] array, int left, int right)
    {
        if (left == right)
        {
            return array[left];
        }

        int mid = (left + right) / 2;
        int leftMajority = majority(array, left, mid);
        int rightMajority = majority(array, mid + 1, right);

        int leftCount = 0, rightCount = 0;
        for (int i = left; i <= right; i++)
        {
            if (array[i] == leftMajority)
            {
                leftCount++;
            }
            else if (array[i] == rightMajority)
            {
                rightCount++;
            }
        }

        int majorityCount = (right - left + 1) / 2;
        if (leftCount > majorityCount) return leftMajority;
        if (rightCount > majorityCount) return rightMajority;
        
        return -1;
    }
}
