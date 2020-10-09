using System;
using System.Collections.Generic;

namespace SetHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();
            HashSet<int> total = new HashSet<int>();
            
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                a.Add(x);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                b.Add(x);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                c.Add(x);
            }

            total.UnionWith(a);
            total.UnionWith(b);
            total.UnionWith(c);

            Console.WriteLine("Total students: " + total.Count);
        }
    }
}
