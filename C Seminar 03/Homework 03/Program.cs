// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Task 19________________________________________________________________
Console.Clear();
void PolindromeNum(int num)
{
    string inputStr = Convert.ToString(num);
    char[] inputarray = inputStr.ToCharArray();
    Array.Reverse(inputarray);
    string output = new string(inputarray);
    // Console.WriteLine(output);
    if (inputStr == output)
    {
        Console.WriteLine($"Number {num} is polindrome");
    }
    else
    {
        Console.WriteLine($"Number {num} not polindrome");
    }
}

Console.Write("Enter a number : ");
int input = Convert.ToInt32(Console.ReadLine());
if (input >= 10000 && input < 100000)
{
    PolindromeNum(input);
}
else
{
    Console.WriteLine("You entered a non-five-digit number!!!");
}



// Task 23________________________________________________________________
// void Cube(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write(Math.Pow (i,3) + " ");
//     }
// }

// Console.WriteLine("Enter a number : ");

// int number = Convert.ToInt32(Console.ReadLine());
// Cube(number);