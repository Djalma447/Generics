using Equality.Entities;
using System;
using System.Collections.Generic;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 2000.0));
            a.Add(new Product("Notebook", 4000.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 8));

            Product prod = new Product("Notebook", 4000.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 8);
            Console.WriteLine(b.Contains(p));
        }
    }
}
