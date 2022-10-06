using System;
using System.Collections;
using System.Collections.Generic;

namespace _205_Isomorphic_Strings
{

    // Accepted
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsIsomorphic("egcd", "adfd"));

        }


        public static bool IsIsomorphic(string s, string t)
        {
            if(s.Length==1) return true;
            
            Hashtable ht = new Hashtable();
            
            for(int i = 0; i < s.Length; i++)
            {

                if (ht.ContainsKey(s[i]))
                {
                    var old = ht[s[i]].ToString();
                    if (old != t[i].ToString()) return false;
                }
                else
                {
                    if (ht.ContainsValue(t[i]))
                    {
                        string vals = s[i].ToString();
                        foreach (var key in ht.Keys)
                        {
                            if (ht[key].ToString()!= vals)
                            {
                                return false;
                            }
                            
                        }
                    }
                    ht.Add(s[i], t[i]);
                }
            }
            return true;
        }
    }
}
