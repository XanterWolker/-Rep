﻿using System;

namespace Учеба
{
    class Program
    {

        static void Main(string[] args)
        {
            Task4();
        }
        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] arr = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }

            }
            Console.WriteLine(min);
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] arr = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            int max = arr[0];
            int max2 = arr[1];
           
            for (int i = 2; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max2 = max;
                    max = arr[i];
                   
                }

                if (max2 < arr[i] && arr[i] != max)
                {
                    max2 = arr[i];
                }

            }

             

            Console.WriteLine(max);
            Console.WriteLine(max2);
        }

        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] arr = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            int sum = 0;
            

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                
                Console.WriteLine(sum);
            }
            

        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int[] arr = new int[101];
            for (int i = 1; i < arr.Length; i++)
            {
                
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            Random rnd = new Random();
            int r = rnd.Next(1, 10);//случайное число от 1 до 10
        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }


        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            int ostatok = 4 % 2; //будет равен нулю
        }
    }
}
