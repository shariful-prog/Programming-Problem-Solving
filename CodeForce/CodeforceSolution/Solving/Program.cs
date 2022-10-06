using System;

namespace Solving
{
    internal class Program
    {
        static void Maind(string[] args)
        {
           int n = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if(s.Length <= 10)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    string firstword=s.Substring(0,1);
                    string secondword=s.Substring(s.Length-1);
                    Console.WriteLine(firstword+(s.Length-2)+secondword);

                }

            }
        }
    }
}
