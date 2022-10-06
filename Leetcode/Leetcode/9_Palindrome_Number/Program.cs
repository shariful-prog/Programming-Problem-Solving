using System;

namespace _9_Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool dr = IsPalindrome(00000);
            string ds = "D";
        }

        public static bool IsPalindrome(int x)
        {
            string strV = x.ToString();
            if (strV.Equals(Reverse(strV)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string Reverse(string text)
        {
            if (text == null) return null;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
