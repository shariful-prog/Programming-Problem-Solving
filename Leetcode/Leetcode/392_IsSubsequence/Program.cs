using System;
using System.Linq;

namespace _392_IsSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
        }

        public static bool IsSubsequence(string s, string t)
        {

            var originalArray = t.ToCharArray();
            int count = 0;
            for (int l = 0; l < s.Length; l++)
            {
                if (originalArray.Contains(s[l]))
                {
                    count++;
                }

            }
            return count == s.Length ? true : false;

        }
    }
}
