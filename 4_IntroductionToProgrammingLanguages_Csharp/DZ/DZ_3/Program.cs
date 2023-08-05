//ДЗ к семинару 3.
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 9999 && N < 100000)
// {
//     int num1 = N / 10000;
//     int num2 = N % 10;
//     int num3 = N / 1000 % 10;
//     int num4 = N / 10 % 10;
//     if (num1 == num2 && num3 == num4)
//         Console.WriteLine($"{N} -> ДА");
//     else
//         Console.WriteLine($"{N} -> НЕТ");
// }

// else
//     Console.WriteLine("Это число не пятизначное");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите значение Х точки А: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение Y точки А: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение Z точки А: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение Х точки B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение Y точки B: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение Z точки B: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double num = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),2);

// Console.WriteLine($"Расстояние между точками А и В равно:{num}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

//     int num1 = 1;
//     int cube = 0;
//     while (num1 <= num)
//     {
//         cube = num1 * num1*num1;
//         Console.Write(cube+"; ");
//         num1++;
//     }