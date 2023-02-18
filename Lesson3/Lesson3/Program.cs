//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Console.Write("Введите ПЯТИЗНАЧНОЕ число: ");

//int.TryParse(Console.ReadLine(), out int number);

//if (number < 10000 || number > 99999) Console.WriteLine("Вы ввели неверное число!");
//else
//{
//    int num1 = number % 10;
//    int num2 = number / 10 % 10;
//    int num3 = number / 100 % 10;
//    int num4 = number / 1000 % 10;
//    int num5 = number / 10000 % 10;

//    int reverseNumber = num5 + num4 * 10 + num3 * (int)Math.Pow(10, 2) + num2 * (int)Math.Pow(10, 3) + num1 * (int)Math.Pow(10, 4);

//    bool numbersIsEqual = number == reverseNumber;

//    if (numbersIsEqual) Console.WriteLine($"Число {number} является палиндромом");
//    else Console.WriteLine($"Число {number} НЕ является палиндромом");
//}


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Console.Write("Введите координату т.А по оси Х: ");
//int.TryParse(Console.ReadLine(), out int Ax);

//Console.Write("Введите координату т.А по оси Y: ");
//int.TryParse(Console.ReadLine(), out int Ay);

//Console.Write("Введите координату т.А по оси Z: ");
//int.TryParse(Console.ReadLine(), out int Az);

//Console.Write("Введите координату т.B по оси Х: ");
//int.TryParse(Console.ReadLine(), out int Bx);

//Console.Write("Введите координату т.B по оси Y: ");
//int.TryParse(Console.ReadLine(), out int By);

//Console.Write("Введите координату т.B по оси Z: ");
//int.TryParse(Console.ReadLine(), out int Bz);

//double result = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));

//Console.WriteLine($"Расстояние между т.А и т.B = {result:f3}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Console.Write("Введите число N: ");
//int.TryParse(Console.ReadLine(), out int N);

//Console.Write("1");

//for (int i = 2; i <= N; i++)
//{
//    Console.Write($", {Math.Pow(i, 3)}");
//}
//Console.Write(".");


//Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. На вход будет подаваться число (сумма вклада). 
//При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
//Отработав, программа должна вывести общую сумму с начисленными процентами.


//Console.Write("Введите число (сумму вклада): ");
//int.TryParse(Console.ReadLine(), out int deposit);

//double result;

//if (deposit < 100) result = deposit * 1.05;
//else if (deposit >= 100 && deposit < 200) result = deposit * 1.07;
//else result = deposit * 1.1;

//Console.WriteLine($"Сумма вклада через 12 месяцев будет равна {result:f2}");


//Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по величине цифре. 
//Напишите программу, которая определяет интересное число или нет. 
//Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».

//Console.Write("Введите трехзначное число: ");
//int.TryParse(Console.ReadLine(), out int number);

//if (number < 100 || number > 999) Console.WriteLine("Вы ввели неверное число!");
//else
//{
//    int num1 = number % 10;
//    int num2 = number / 10 % 10;
//    int num3 = number / 100;

//    int max = new[] { num1, num2, num3 }.Max();
//    int min = new[] { num1, num2, num3 }.Min();

//    if (max - min == ((num1 + num2 + num3) / 3)) Console.WriteLine("Число интересное");
//}

