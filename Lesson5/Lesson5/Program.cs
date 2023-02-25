//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

class Program
{

    static void Main()
    {
        //        Random rnd = new Random();
        //        int size = 20;
        //        int positCount = 0;
        //        int[] intArray = new int[size];

        //        for (int i=0; i < size; i++)
        //        {
        //            intArray[i] = rnd.Next(100, 1000);

        //            if (intArray[i] % 2 == 0) positCount++;
        //        }

        //        Console.WriteLine($"Массив из {size} случайных положительных трехзначных чисел: [{string.Join("; ", intArray)}]. \nКоличество четных чисел в массиве: {positCount}.");


        //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.

        //Random rnd = new Random();
        //int size = 20;
        //int sum = 0;

        //int[] intArray = new int[size];

        //for (int i = 0; i < size; i++)
        //{
        //    intArray[i] = rnd.Next(0, 21);
        //    if (i % 2 == 1) sum += intArray[i];
        //}

        //Console.WriteLine($"Массив из {size} случайных чисел: [{string.Join("; ", intArray)}]. \nСумма элементов, стоящих на нечетных позициях равна {sum}.");


        //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

        Random rnd = new Random();
        int size = 10;

        double[] array = new double[size];
        double result;

        for (int i = 0; i < size; i++)
        {
            array[i] = Math.Round(rnd.NextDouble() * 100, 4);
        }

        double minValue = array[0];
        double maxValue = array[0];

        for (int i=1; i<size; i++)
        {
            if (array[i] < minValue) minValue = array[i];

            if (array[i] > maxValue) maxValue = array[i];
        }

        result = maxValue - minValue;

        Console.WriteLine($"Разница между максимальным: {maxValue:F2} и минимальным: {minValue:F2} значением массива [{string.Join("; ", array)}] равна: {result:F2}.");
    }
}
                