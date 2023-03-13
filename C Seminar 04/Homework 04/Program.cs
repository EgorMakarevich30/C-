// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// START // ———————————————————————————————————————————————————————————————————————— 1 variant

// double NumToPower(int a, int b)
// {
//     double power = Math.Pow(a, b);
//     return power;
// }

// Console.Write("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NumToPower(numA, numB));


// START // ———————————————————————————————————————————————————————————————————————— 2 variant

// double InputNum(string num)
// {
//     Console.Write($"Input number {num}: ");
//     return Convert.ToDouble(Console.ReadLine());
// }

// double numberA = InputNum("A");
// double numberB = InputNum("B");
// double power = Math.Pow(numberA, numberB);
// Console.WriteLine($"{numberA} to the power of {numberB} -> {power}");


// START // ———————————————————————————————————————————————————————————————————————— 3 variant

// double NumToPower(int numA, int numB)
// {
//     double result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         result *= numA;
//     }
//     return result;
// }

// int InputNum(string num)
// {
//     Console.Write($"Input number {num}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int numberA = InputNum("A");
// int numberB = InputNum("B");

// Console.WriteLine($"{numberA} to the power of {numberB} -> {NumToPower(numberA, numberB)}");

// ————————————————————————————————————————————————————————————————————————// END //




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// START // ———————————————————————————————————————————————————————————————————————— 

// int SumDigit(int num)
// {
//     int sum = 0;
//     for (int i = 1; num >= 1; i++)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Enter the number: ");
// int number  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumDigit(number));
// ————————————————————————————————————————————————————————————————————————// END //



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// START // ———————————————————————————————————————————————————————————————————————— 

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Input a {i} element of array: ");
//         array[i]= Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"Input count element of array: ");
// int count = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateArray(count));

// ————————————————————————————————————————————————————————————————————————// END //