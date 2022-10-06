using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solving
{
    internal class _231A_Team
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int nOCount = 0;
            for (int i = 0; i < n; i++)
            {
                int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int vsZeroCount = (from s in items where s == 0 select s).Count();
                if (vsZeroCount > 1)
                {
                    nOCount++;
                }

            }
            Console.WriteLine(n - nOCount);

        }
    }
}

