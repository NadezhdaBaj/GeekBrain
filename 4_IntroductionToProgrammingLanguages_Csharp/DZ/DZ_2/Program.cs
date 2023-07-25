//ДЗ к семинару 2.

// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number=new Random().Next(100,1000);
// Console.WriteLine("Число "+number);
// int num=number/10%10;
// Console.WriteLine("Вторая цифра: "+num);


// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number=new Random().Next(10,40000);
// Console.WriteLine("Число "+number);
// while (number > 999)
//         number = number / 10;
// if (number > 99 & number < 1000)
//     Console.WriteLine($"Третья цифра {number % 10}");
// else if (number < 99)
//     Console.WriteLine("Такой цифры нет");


// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int number=new Random().Next(0,10);
// Console.WriteLine("День "+number);
// if (number > 0 && number < 6)
// Console.WriteLine("Рабочий");
// else if (number == 6 || number == 7)
// Console.WriteLine("Выходной");
// else
// Console.WriteLine("Нет такого дня недели");