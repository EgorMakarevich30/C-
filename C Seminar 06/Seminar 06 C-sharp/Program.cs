//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


// int[] CreateRandomArray(int size, int minValue, int maxValue)  //min нижнее ограничение max верхнее ограничение
// {
//     int[] newArray = new int[size]; //тип массива int, выделяем память под тип int size штук 

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
//     return array;
// }
// Console.Write("Получившийся массив -> ");
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// myArray = ReverseArray(myArray);
// ShowArray(myArray);



//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle (int a, int b, int c)
// {
//     if(a+b>c && a+c>b && b+c>a)
//     return true;
//     else
//     return false;
// }
// Console.WriteLine(CheckTriangle(3,4,8));






//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
// [0, 1, 1, 2, 3, 5, 8, 13, ... ]

// int Fibonacci(int n, int a, int b)
// {
//     if (n == 1 || n == 2)
//     {
//         Console.WriteLine(a, b);
//     }
// }

// int a = 0, b = 1, c;
// int n = 10; // количество чисел Фибоначчи, которые нужно вывести

// Console.Write("{0} {1} ", a, b);

// for (int i = 2; i < n; i++)
// {
//     c = a + b;
//     Console.Write("{0} ", c);
//     a = b;
//     b = c;
// }


// В данном коде мы объявляем переменные a и b, начальные значения которых равны соответственно 0 и 1.
//  Далее мы определяем количество чисел, которые нужно вывести, и выводим на экран первые два числа Фибоначчи.
// Затем мы используем цикл for для вычисления и вывода оставшихся чисел Фибоначчи. 
// Внутри цикла мы объявляем переменную c, которую мы присваиваем сумму переменных a и b (следующее число Фибоначчи). 
// Затем мы выводим на экран значение переменной c и обновляем значения переменных a и b для следующей итерации цикла.


// int[] Fibanachi(int N,int a,int b)
// {

//     int[] array = new int[N];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i<N;i++)
//     {
//         array[i]= array[i-1] + array[i-2];
//     }
//     return array;
// }


// ShowArray(Fibanachi(11,3,5));



//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

// Вот пример программы, которая преобразует десятичное число, введённое пользователем, в двоичное число:
// csharp
// using System;

    // int decimalNumber, quotient;
    // string binaryNumber = "";

    // Console.Write("Введите десятичное число: ");
    // decimalNumber = int.Parse(Console.ReadLine());

    // while (decimalNumber >= 1)
    // {
    //     quotient = decimalNumber / 2;
    //     binaryNumber = (decimalNumber % 2) + binaryNumber;
    //     decimalNumber = quotient;
    // }

    // Console.WriteLine("Двоичное число: {0}", binaryNumber);
    // Console.ReadLine();


// Программа запрашивает у пользователя десятичное число, которое необходимо преобразовать.
//  Затем она использует цикл while для получения остатка от деления числа на два и записи его в строку binaryNumber. 
//  После каждой итерации цикла десятичное число делится на два. При достижении числа вида 0.5 или меньше цикл завершается, 
//  и программа выводит полученную строку binaryNumber на экран.