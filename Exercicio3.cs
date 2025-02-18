using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, M;

            Console.WriteLine("Escreva a nota n1:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a nota n2:");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a nota n3:");
            n3 = double.Parse(Console.ReadLine());

            M = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média das notas é:" + M);

        }
    }
}