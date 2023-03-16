// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// START // ———————————————————————————————————————————————————————————————————————— 

// int[] Create3DigitPosArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
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

// int CountEvenNumsInArray(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count++;
//             Console.WriteLine($"{count}. index = {i}, number = {arr[i]}");
//         }
//     }
//     return count;
// }

// int lengthArray = new Random().Next(10, 51);
// int[] array3DigitPos = Create3DigitPosArray(lengthArray);
// ShowArray(array3DigitPos);

// Console.WriteLine($"Length of array: {lengthArray} elements");

// int countEven = CountEvenNumsInArray(array3DigitPos);
// Console.WriteLine($"Count of even elements in array: {countEven}");

// ————————————————————————————————————————————————————————————————————————// END //



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// START // ———————————————————————————————————————————————————————————————————————— 
// Console.Clear();
// int[] CreateRandomArray(int count, int start, int end)
// {
//     int[] array = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(start, end);
//     }
//     return array;
// }

// void ShowArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOddElementsOfArray(int[] array)
// {
//     Console.WriteLine($"Array elements with odd positions:");
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += array[i];
//             Console.Write(array[i] + " | ");
//         }
//     }
//     Console.WriteLine();
//     return sum;
// }

// int sizeOfArray = new Random().Next(10, 24);
// int startArray = new Random().Next(-100, 0);
// int endArray = new Random().Next(0, 100);



// int[] arrayRand = CreateRandomArray(sizeOfArray, startArray, endArray);
// Console.WriteLine($"Random array of {sizeOfArray} elements:");
// ShowArray(arrayRand);
// int sumOdd = SumOddElementsOfArray(arrayRand);
// Console.WriteLine($"Sum elements of array with odd positions = {sumOdd}");
// ————————————————————————————————————————————————————————————————————————// END //




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// START // ———————————————————————————————————————————————————————————————————————— 

// Console.Clear();

// int sizeArray = 12;
// int startArray = 0;
// int endArray = 60;
// double[] doubleArray = CreateArrDouble(sizeArray, startArray, endArray);

// Console.WriteLine($"Random array of {sizeArray} elements from {startArray} to {endArray}:");
// ShowArray(doubleArray);
// Console.WriteLine();

// double[] CreateArrDouble(int size, int start, int end)
// {
//     double[] arr = new double[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = Math.Round(rand.Next(start, end) + rand.NextDouble(), 4);
//     }
//     return arr;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " | ");
//     }
//     Console.WriteLine();
// }


// double DiffMaxMinElements(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         else if (array[i] < min) min = array[i];
//     }
//     Console.WriteLine(min + " — Minimum" + " // " + max + " — Maximum");
//     Console.WriteLine();
//     return Math.Round(max - min, 4);
// }

// double diffElements = DiffMaxMinElements(doubleArray);


// Console.WriteLine($"Difference between maximal & minimal elements of array = {diffElements}");
// Console.WriteLine();

// ————————————————————————————————————————————————————————————————————————// END //