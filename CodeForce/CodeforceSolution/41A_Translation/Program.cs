using System;

namespace _41A_Translation
{

    internal class Program
    {
    //Accepted
        static void Main(string[] args)
        {
            string tVal = Console.ReadLine();
            string reverseVal = Console.ReadLine();

            char[] str = tVal.ToCharArray();
            Array.Reverse(str);
            string strVal = new string(str);

            if (strVal.Equals(reverseVal))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }

      
    }
}
