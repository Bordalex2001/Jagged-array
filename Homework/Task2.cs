using System;

namespace Homework
{
    internal class Task2
    {
        static void Main()
        {
            int rows = 6; //Количество строк в массиве
            int[][] jagged_array = new int[rows][];
            Random rand = new Random();
            //Заполнение зубчатого или треугольного массива случайными числами, вывод на экран
            for (int i = 0; i < rows; i++)
            {
                jagged_array[i] = new int[rows - i];
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    jagged_array[i][j] = rand.Next(0, 100);
                    Console.Write(jagged_array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}