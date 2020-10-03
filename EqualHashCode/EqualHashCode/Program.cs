using EqualHashCode.Entities;
using System;

namespace EqualHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };
            //Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); // Exemplo de Comparação Comum entre duas 'Classes - Referências'
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            
            /* Exemplo #1
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode()); */
        }
    }
}
