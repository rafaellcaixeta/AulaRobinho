using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, R, S, D;

            Console.WriteLine("Insira um numero inteiro e positivo:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero inteiro e positivo:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero inteiro e positivo:");
            C = int.Parse(Console.ReadLine());

            R = (A + B) * (A + B);
            S = (B + C) * (B + C);
            D = (R + S) / 2;

            Console.WriteLine("Valor de D é: " + D);
        }
    }
}