// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int Stepen(int num1, int num2)
// {
// int result=1;
// for (int i = 0; i < num2; i++)
// {
//     result=result*num1;
// }
// return result;
// }

// System.Console.WriteLine("Введите целое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите натуральную степень: ");
// int expB = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"{numA} в степени {expB} равно {Stepen(numA,expB)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
//  сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int SumOfDigits(int number)
// {
//     int ostatok = 0;
//     int result = 0;
//     while (number > 0)
//     {
//         ostatok = number % 10;
//         result = result + ostatok;
//         number = number / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {num} равна {SumOfDigits(num)}");



// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// System.Console.WriteLine("Введите размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int [] array=new int [size];
// for (int index = 0; index < size; index++)
// {
//     array[index]= new Random().Next(1,100);
// Console.Write(array[index]+" ");
// }