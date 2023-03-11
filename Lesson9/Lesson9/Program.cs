class Program
{
    static void Main()
    {
        //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.

        void GetNatNumbers(int N)
        {
            if (N == 0) return;

            if (N != 1)
            {
                Console.Write($"{N},");
                GetNatNumbers(--N);
            }
            else
            {
                Console.Write(N);
            }
        }

        //GetNatNumbers(5);

        //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

        int GetSum(int startNum, int endNum)
        {
            if (startNum == endNum) return startNum;

            return startNum + GetSum(++startNum, endNum);
        }

        //Console.WriteLine(GetSum(2, 10));


        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


        Console.WriteLine("Введите первое число m: ");
        uint m = uint.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число n: ");
        uint n = uint.Parse(Console.ReadLine());

        uint CalculateAckerman(uint m, uint n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return CalculateAckerman(m - 1, 1);
            else if (m > 0 && n > 0) return CalculateAckerman(m - 1, CalculateAckerman(m, n - 1));
            else return 1;
        }

        Console.WriteLine(CalculateAckerman(m, n));
    }
}