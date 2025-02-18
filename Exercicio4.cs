using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Escreva um número inteiro:");
            N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
                {
                Console.WriteLine("O número inserido é par");
            }
            else
            {
                Console.WriteLine("O número inserido é impar");

            }
        }
    }
}
