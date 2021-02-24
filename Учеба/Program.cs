using System;

namespace Учеба
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double sum = 100 ;
            double div = sum / 3;
            Console.WriteLine($"Введите коэфициенты квадратного уравнения ax^2 + bx + c =0");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"Дискриминант = {d}");

            double x1 = (-b - Math.Sqrt(d)) / 2 * a;
            double x2 = (-b + Math.Sqrt(d)) / 2 * a;

            Console.WriteLine($"Корни уравнения x1 = {x1}, x2 = {x2}");

        }
    }
}
