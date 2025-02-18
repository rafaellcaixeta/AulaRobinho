using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            double rx, ry;
            double d;
            double R;
            Console.WriteLine("Digite o valor de x2:");
            x1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de x1:");
            x2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de y2:");
            y1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de y1:");
            y2 = double.Parse(Console.ReadLine());

            rx = (x2 - x1) * (x2 - x1);
            ry = (y2 - y1) * (y2 - y1);
            d = rx + ry;
            R = Math.Sqrt(d);
            Console.WriteLine("O Valor é:" + R);
            
        }
    }
}