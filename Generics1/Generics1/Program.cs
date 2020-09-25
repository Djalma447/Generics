using System;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> ps = new PrintService<string>();
            
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                ps.AddValue(x);
            }

            ps.Print();
            Console.WriteLine("First: " + ps.First());
        }
    }
}
