// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Solutions––––––––––––––––––––––––––––––––––––––

//Task 2:
// Console.Clear();
// Console.WriteLine("Input first number, please:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You first input -> {num1}");
// Console.WriteLine("Input second number, please:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You second input -> {num2}");
// int max = 0;
// int min = 0;

// if (num1 > num2)
// {
//     max = num1;
//     min = num2;
// }
// else
// {
//     max = num2;
//     min = num1;
// }
// Console.WriteLine($"Maximum number -> {max}");
// Console.WriteLine($"Minimum number -> {min}");



//_________________________________________
//Task 4:
// Console.Clear();
// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number:");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if (num1 > num2)
// {
//     if (num1 > num3)
//     {
//         max = num1;
//     }
//     else
//     {
//         max = num3;
//     }
// }
// else
// {
//     if (num2 > num3)
//     {
//         max = num2;
//     }
//     else
//     {
//         max = num3;
//     }
// }    
// Console.WriteLine($"Maximum number -> {max}");


//Task 6:
//__________________________________________________
Console.Clear();
 Console.WriteLine("Input a number:");
 int num = Convert.ToInt32(Console.ReadLine());

 if (num % 2 == 0)
 {
    Console.Write($"Is the number {num} even (is it divisible by two without a remainder)-> -=Yes=-");
 }
 else
 {
    Console.Write($"Is the number {num} even (is it divisible by two without a remainder)-> -=No=-");
 }