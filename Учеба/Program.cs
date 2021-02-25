using System;

namespace Учеба
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite n");
            int n = Convert.ToInt32(Console.ReadLine);

            int[,] z = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    z[i, j] = (i + 1) * (j + 1);
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\t{i+1}");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"\t{z[j,i]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
