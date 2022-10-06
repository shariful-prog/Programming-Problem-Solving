using System;
using System.Linq;

namespace _977A_WrongSubtraction
{
    internal class Program
    {
        // Accepted
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int value = items[0];
            int length = items[1];
            int currentValue = value;

            for (int i = 0; i < length; i++)
            {
                if (currentValue % 10 == 0)
                {
                    currentValue = currentValue / 10;
                }
                else
                {
                    currentValue= currentValue-1;
                }

            }
           Console.WriteLine(currentValue);

        }
    }
}
