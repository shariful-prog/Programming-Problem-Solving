using System;
using System.Linq;

namespace _318A_EvenOdds
{
    internal class Program
    {
        //Accepted
        static void Main(string[] args)
        {
            
                long[] inp = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long value = inp[0];
                long position = (inp[1]);
                int extraval = 0;
                if (value % 2 == 0)
                {
                    extraval = 0;
                    long midVal = (value / 2) + extraval;

                    if (position <= midVal)
                    {
                        Console.WriteLine(((position * 2) + 1)-2);
                    }
                    else
                    {
                        Console.WriteLine((position - midVal) * 2);
                    }
                }
                else
                {
                    extraval = 1;
                    long midVal = (value / 2) + extraval;

                    if (position <= midVal)
                    {
                        Console.WriteLine(((position * 2) + 1)-2);
                    }
                    else
                    {
                        Console.WriteLine((position - midVal) * 2);
                    }
                }         
        }
    }
}


