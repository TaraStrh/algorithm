using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputs = input.Split();
        int num1 = int.Parse(inputs[0]);
        int num2 = int.Parse(inputs[1]);
        int count = 0;
            while (num2 > num1)
            {
                if (num2 % 2 == 0)
                {
                    num2 = num2 / 2; 
                    count++;
                }
                else
                {
                    num2++;
                    count++;
                }
               
            }
            if(num1 > num2)
                {
                    count += num1 - num2;
                }
               
            Console.WriteLine(count);
            }
            

    }

