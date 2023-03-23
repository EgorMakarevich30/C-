//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumber(int n)
// {
//     if (n >= 1)
//     {
//         ShowNumber(n - 1);
//         Console.Write(n + ", ");
//     }
// }

// ShowNumber(5);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else return num;
// }

// Console.WriteLine(FindSum(45003));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void ShowNumbersMN(int n, int m)
// {
//     if (n != m)
//     {

//         if (n >= m)
//         {
//             ShowNumbersMN(n - 1, m);
//             Console.Write(n + ", ");
//         }
//         if (m >= n)
//         {
//             ShowNumbersMN(m - 1, n);
//             Console.Write(m + ", ");
//         }
//     }
//     else Console.Write(m + ", ");
// }

// ShowNumbersMN(4, 9);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
int Power(int A, int B) 
{
    if (B == 0) return 1;
    return A * Power(A, B - 1);
}

int A = 2;
int B = 3;

int result = Power(A, B);

Console.WriteLine($"{A} в степени {B} = {result}");
