using System.Globalization;

class Program
{
    static void Main()
    {
        //Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

        //Console.WriteLine("Задайте количество строк m и стобцов n:");

        //int m, n;
        //bool isNumberRight;

        //Console.Write("m = ");

        //do
        //{
        //    isNumberRight = int.TryParse(Console.ReadLine(), out m);
        //}
        //while (!isNumberRight);

        //Console.Write("n = ");

        //do
        //{
        //    isNumberRight = int.TryParse(Console.ReadLine(), out n);
        //}
        //while (!isNumberRight);

        //Random rnd = new Random();

        //double[,] Get2DDoubleArray(int m, int n)
        //{
        //    double[,] double2DArray = new double[m, n];

        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            double2DArray[i, j] = rnd.NextDouble() * 100;
        //        }
        //    }
        //    return double2DArray;
        //}

        //double[,] example = Get2DDoubleArray(m, n);

        //Console.ReadKey();



        //Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

        //int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //int GetValueInArray(int[,] intArray, int m, int n) => intArray[m, n];

        //Console.WriteLine("Введите позиции элемента (m,n): ");

        //int m, n;
        //bool isNumberRight;

        //Console.Write("m = ");

        //do
        //{
        //    isNumberRight = int.TryParse(Console.ReadLine(), out m);
        //}
        //while (!isNumberRight);

        //Console.Write("n = ");

        //do
        //{
        //    isNumberRight = int.TryParse(Console.ReadLine(), out n);
        //}
        //while (!isNumberRight);

        //if (m >= 0 && m < intArray.GetLength(0) && n >= 0 && n < intArray.GetLength(1))
        //{
        //    Console.WriteLine(GetValueInArray(intArray, m, n));
        //}
        //else
        //{
        //    Console.WriteLine("Входные данные не действительны");
        //}


        //Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.


        Console.WriteLine("Задайте количество строк m и стобцов n:");

        int m, n;
        bool isNumberRight;

        Console.Write("m = ");

        do
        {
            isNumberRight = int.TryParse(Console.ReadLine(), out m);
        }
        while (!isNumberRight);

        Console.Write("n = ");

        do
        {
            isNumberRight = int.TryParse(Console.ReadLine(), out n);
        }
        while (!isNumberRight);

        Random rnd = new Random();

        int[,] Get2DIntArray(int m, int n)
        {
            int[,] int2DArray = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int2DArray[i, j] = rnd.Next(100);
                }
            }
            return int2DArray;
        }

        int[,] intArray = Get2DIntArray(m, n);
        int sum = 0;

        for (int i=0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum += intArray[i, j];
            }
            double avrSum = sum / m;
            Console.Write($"{avrSum:F2}; ");
        }
    }
}
