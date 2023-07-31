using System;

namespace Homework
{
    internal class Task1
    {
        static void Main()
        {
            //Шаг 1: Создание зубчатого массива
            int[][] jagged_arr = GenerateArray(6, 2, 8);
            Console.WriteLine("Original jagged array:");
            PrintArray(jagged_arr);
            //Шаг 2: Поиск элементов строки с минимальным и максимальным количеством элементов
            int min_index = 0;
            int max_index = 0;
            int min_count = jagged_arr[0].Length;
            int max_count = jagged_arr[0].Length;
            for (int i = 1; i < jagged_arr.Length; i++)
            {
                int count = jagged_arr[i].Length;
                if (count < min_count)
                {
                    min_count = count;
                    min_index = i;
                }
                if (count > max_count)
                {
                    max_count = count;
                    max_index = i;
                }
            }
            //Шаг 3: Поменять две указанные выше строки местами
            int[] temp = jagged_arr[min_index];
            jagged_arr[min_index] = jagged_arr[max_index];
            jagged_arr[max_index] = temp;
            Console.WriteLine();
            Console.WriteLine("Jagged array after row swapping:");
            PrintArray(jagged_arr);
        }
        //Генерация массива с случайным количеством элементов в каждой строке
        static int[][] GenerateArray(int rows, int minOfElements, int maxOfElements)
        {
            int[][] jagged_arr = new int[rows][];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                int elements_count = rand.Next(minOfElements, maxOfElements + 1);
                jagged_arr[i] = new int[elements_count];
                for (int j = 0; j < elements_count; j++)
                {
                    jagged_arr[i][j] = rand.Next(0, 100);
                }
            }
            return jagged_arr;
        }
        //Вывод массива на экран
        static void PrintArray(int[][] jagged_arr)
        {
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.Write(jagged_arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}