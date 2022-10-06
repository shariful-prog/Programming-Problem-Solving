using System;

namespace _236A_BoyorGirl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Accepted 
                string name = Console.ReadLine();
                int totalLength = name.Length;
                for (int i = 0; i < name.Length; i++)
                {
                    char c = name[i];
                    for (int j = i + 1; j < name.Length; j++)
                    {
                        if (c.Equals(name[j]))
                        {
                            totalLength = totalLength - 1;
                            break;
                        }
                    }              
            }
            if (totalLength % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");

            }




        }
    }
}
