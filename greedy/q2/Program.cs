using System.Data;
using System;
public class Program
{
    static void Main(string[]args)
    {
        string input1 =Console.ReadLine();
        string input2 = Console.ReadLine();
        int start1 = input1[0]-'a';
        int start2 = input1[1]-'1';
        int finish1 = input2[0]-'a';
        int finish2 = input2[1]-'1';
        int count =0;
        string[]move = new string[64];
            while(start1 != finish1 || start2 != finish2)
            {
                if(start1 < finish1)
                {
                    if(start2 == finish2)
                    {
                        move[count++] = "R";
                        start1++;
                    }
                    else if(start2 < finish2)
                    {
                        move[count++] = "RU";
                        start1++;
                        start2++;
                    }
                    else
                    {
                        move[count++] = "RD";
                        start1++;
                        start2--;
                    }
                }
               else if(start1 > finish1)
                {
                    if(start2 == finish2)
                    {
                        move[count++] = "L";
                        start1--;
                    }
                    else if(start2 < finish2)
                    {
                        move[count++] = "LU";
                        start1--;
                        start2++;
                    }
                    else
                    {
                        move[count++] = "LD";
                        start1--;
                        start2--;
                    }
                }
                else
                {
                 if(start2 < finish2)
                    {
                        move[count++] = "U";
                        start2++;
                    }
                    else
                    {
                        move[count++] = "D";
                        start2--;
                    }
                }
                
            }
            Console.WriteLine(count);
            for(int i=0 ; i<count ; i++)
            {
                Console.WriteLine(move[i]);
            }
        }
}