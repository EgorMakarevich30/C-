// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// ============================================================================

double[,] Create2DArray(int m, int n)
{
    double[,] empty2DArray = new double[m, n];
    return empty2DArray;
}

double[,] Fill2DArray(double[,] newArray, int minValue, int maxValue)
{
    double[,] fill2DArray = new double[newArray.GetLength(0), newArray.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            fill2DArray[i, j] = Math.Round(
                new Random().Next(minValue, maxValue + 1)
                + new Random().NextDouble(), 1);
        }
    }
    return fill2DArray;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = 5;
int cols = 5;
int minValue = -100;
int maxValue = 100;

double[,] realNumArray = Fill2DArray(Create2DArray(rows, cols), minValue, maxValue);

Show2DArray(realNumArray);

// ----------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// ----------------------------------------------------------------
// В качестве входящего массива использовать решение задачи 47.
// ----------------------------------------------------------------

void ValueOfMatrixElement(double[,] array, int indexRow, int indexColumn)
{
    if (indexRow < array.GetLength(0) && indexColumn < array.GetLength(1))
    {
        Console.WriteLine($"Value of selected element = {array[indexRow, indexColumn]}");
    }
    else
    {
        Console.WriteLine(":( This element not exist in the matrix.");
    }
}

int indexRow = 6;
int indexColumn = 4;

Console.WriteLine($"Row index of element = {indexRow}");
Console.WriteLine($"Column index of element = {indexColumn}");
ValueOfMatrixElement(realNumArray, indexRow, indexColumn);
Console.WriteLine();

// ============================================================================
// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// ============================================================================

// int[,] Create2DIntegerArray(int rows, int columns, int startValue, int endValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = new Random().Next(startValue, endValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DIntArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowAvgValuesOfColumns(int[,] array)
// {
//     double avg = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sumColumns = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sumColumns += array[i, j];
//         }
//         avg = Math.Round(Convert.ToDouble(sumColumns) / array.GetLength(0), 2);
//         Console.Write(avg + "; ");
//     }
//     Console.WriteLine();
// }

// int row = 4;
// int column = 7;
// int minValue = 0;
// int maxValue = 9;

// int[,] arrayInteger = Create2DIntegerArray(row, column, minValue, maxValue);

// Show2DIntArray(arrayInteger);
// Console.Write($"Average values of each column: ");
// ShowAvgValuesOfColumns(arrayInteger);
