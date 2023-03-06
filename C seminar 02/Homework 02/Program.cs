// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Task 10___________________________________________

// Console.Clear();
// int CutTails(int num)
// {
//     int result = num % 100;
//     int result2 = result / 10;
//     return result2;
// }

// Console.WriteLine("Enter the three-digit number");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number <= 100 || number >= 1000)
// {
//     Console.WriteLine("Invalid number");
// }
// else
// {
//     Console.WriteLine(CutTails(number));
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Task 13___________________________________________

// Console.Clear();
// Console.WriteLine("Enter any number");
// long number = Convert.ToInt64(Console.ReadLine());
// ThirdDigit(number);

// void ThirdDigit(long num)
// {
//     string numText = Convert.ToString(num);
//     if (num < 100)
//     {
//         Console.WriteLine("________________________________________________");
//         Console.WriteLine("No third digit! Try again and enter other number.");
//         Console.WriteLine();
//     }
//     else if (numText.Length > 2)
//     {
//         Console.WriteLine($"Third digit this number is: {numText[2]}");
//     }
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Task 15___________________________________________

// Console.Clear();
// Console.Write("Enter the day number: ");
// int dayNum = Convert.ToUInt16(Console.ReadLine());
// DaysOfWeek(dayNum);

// void DaysOfWeek(int dayNumber)
// {
//     if (dayNumber > 0 && dayNumber < 8)
//     {
//         if (dayNumber != 6 && dayNumber != 7)
//         {
//             Console.WriteLine("It's a work day 💪");
//         }
//         else Console.WriteLine("It's a HOLIDAY! 🛫 🏝 ⛱");
//     }
//     else
//     {
//         Console.WriteLine("Try again and enter correct number of day: 1 to 7.");
//     }
// }


// int CutTails(int num)
// {
//     int result = num % 100;
//     int result2 = result / 10;

//     if (num > -1000 && num < -99)
//     {
//         return result2 * (-1);
//     }
//     else if (num > 99 && num < 1000)
//     {
//         return result2;
//     }
//     else
//     {
//         return -1;
//     }
// }

// Console.WriteLine("Enter the three-digit number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (CutTails(number) > 0)
// {
//     Console.WriteLine(CutTails(number));
// }
// else
// {
//     Console.WriteLine("Invalid number");
// }



