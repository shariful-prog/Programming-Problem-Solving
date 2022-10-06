using System;

namespace _3_Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            string longest_substring = "";
            string tempString = "";
            int length = 0;
            if (s.Length == 1) return 1;
            for (int i = 0; i < s.Length; i++)
            {
                tempString = tempString.Length < longest_substring.Length ? longest_substring : tempString;
                length = tempString.Length;
                longest_substring = "";
                for (int j = i; j < s.Length; j++)
                {
                    if (isExist(longest_substring, s[j]) && i != j)
                    {
                        tempString = tempString.Length < longest_substring.Length ? longest_substring : tempString;
                        longest_substring = "";
                        break;
                    }
                    else
                    {
                        longest_substring += s[j];
                    }

                }
            }

            return length;

        }


        public static bool isExist(string s, char c)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(c))
                {
                    return true;
                }
            }

            return false;

        }
    }
}
