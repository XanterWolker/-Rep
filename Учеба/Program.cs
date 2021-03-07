using System;

namespace Учеба
{
    class Program
    {

        static void Main(string[] args)
        {
            float[] C = new float[] { 1, 10, 5, 20, 9, 0, 6, 2, 9, 1 };
            float[] P = new float[] { 10, 3, 1, 50, 3, 70, 10, 9, 11, 7 };
            float pSum = 0;
            for (int i = 0; i < P.Length; ++i)
            {
                pSum += P[i];//сумма массива Р
            }
            int k = 0;
            for (int i = 0; i < C.Length; ++i)
            {
                if (pSum < C[i])
                {
                    k++;//переменная счетчик для проверки массива
                    break;
                }
            }
            if (k == 1)
            {
                Console.WriteLine("Не выполняется условие задачи");
            }
            else
            {
                float max = 0;
                int x = 0;
                int y = 0;
                for (int i = 0; i < P.Length; ++i)
                {
                    for (int j = 0; j < C.Length; ++j)
                    {
                        float f = (C[i] / (P[j] + C[i] * C[i]));
                        if (f > max)
                        {
                            max = f;
                            x = i;
                            y = j;
                        }
                    }
                }
                Console.WriteLine("i = " + x + " j = " + y);
            }
        }
        
    }
}
