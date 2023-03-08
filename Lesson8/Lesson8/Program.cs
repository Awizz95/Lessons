using System.Threading;

class Homework8
{
    public static void Main()
    {
        //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

        //int[,] numbers = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

        int[,] SortArrayFromMaxToMin(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    int maxValue = array[i, j];
                    bool isValueChanded = false;
                    int maxValueIndex = j;

                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, k] > maxValue)
                        {
                            maxValue = array[i, k];
                            maxValueIndex = k;
                            isValueChanded = true;
                        }
                    }

                    if (isValueChanded)
                    {
                        int tmp = array[i, j];
                        array[i, j] = maxValue;
                        array[i, maxValueIndex] = tmp;
                    }
                }
            }

            return array;
        }

        void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],-4}");
                }

                Console.WriteLine();
            }
        }

        //Show2DArray(SortArrayFromMaxToMin(numbers)); 


        //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

        //int[,] numbers = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

        void FindRowWithMinSum(int[,] array)
        {
            int minRowIndex = -1;
            int minRowSum = int.MaxValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }

                if (sum < minRowSum)
                {
                    minRowSum = sum;
                    minRowIndex = i;
                }
            }

            Console.WriteLine("Строка #" + minRowIndex);
        }

        //FindRowWithMinSum(numbers);


        //Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.

        //int[,] numbers1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        //int[,] numbers2 = { { 4, 5, 6 }, { 7, 8, 9 } };

        int[,] MultiplyMatrix(int[,] firstArray, int[,] secondArray)
        {
            if (firstArray.GetLength(1) != secondArray.GetLength(1) || firstArray.GetLength(0) != secondArray.GetLength(0))
            {
                ApplicationException MyException = new("Размеры массивов не совпадают");
                throw MyException;
            }
            else
            {
                int rows = firstArray.GetLength(0);
                int col = firstArray.GetLength(1);

                int[,] resultArray = new int[rows, col];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        resultArray[i, j] = firstArray[i, j] * secondArray[i, j];
                    }
                }

                return resultArray;
            }
        }

        //Show2DArray(MultiplyMatrix(numbers1, numbers2));



        //Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


        int[,,] Fill3DArray(int firstIndex, int secondIndex, int thirdIndex)
        {
            Random rnd = new Random();

            int[,,] resultArray = new int[firstIndex, secondIndex, thirdIndex];

            for (int i = 0; i < firstIndex; i++)
            {
                for (int j = 0; j < secondIndex; j++)
                {
                    for (int k = 0; k < thirdIndex; k++)
                    {
                        resultArray[i, j, k] = rnd.Next(10, 100);
                    }
                }
            }

            return resultArray;
        }

        void Show3DArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
                    }
                }
            }
        }

        //Show3DArray(Fill3DArray(3, 3, 3));


        //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.


        int[,] FillSpiralArray4x4()
        {
            int rows = 4;
            int col = 4;

            int[,] array = new int[rows, col];

            int nextValue = 0;
            int maxPasses = rows / 2;

            for (int numberOfPass = 0; numberOfPass < maxPasses; numberOfPass++)
            {


                for (int i = 0 + numberOfPass; i < col - numberOfPass; i++)
                {
                    array[0 + numberOfPass, i] = nextValue;
                    nextValue++;
                }

                for (int i = 1 + numberOfPass; i < rows - numberOfPass; i++)
                {
                    array[i, col - 1 - numberOfPass] = nextValue;
                    nextValue++;
                }

                for (int i = col - 2 - numberOfPass; i >= 0 + numberOfPass; i--)
                {
                    array[rows - 1 - numberOfPass, i] = nextValue;
                    nextValue++;
                }

                for (int i = rows - 2 - numberOfPass; i >= 1 + numberOfPass; i--)
                {
                    array[i, 0 + numberOfPass] = nextValue;
                    nextValue++;
                }
            }

            return array;
        }

        //Show2DArray(FillSpiralArray4x4());
    }
}


