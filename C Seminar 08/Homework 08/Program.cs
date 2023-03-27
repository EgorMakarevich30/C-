// Урок 8. Двумерные массивы. Продолжение
// ================================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// ----------------------------------------------------------------

// int[,] Create2DArray(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SortRowsElementDecrease(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int indexMax = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, indexMax])
//                 {
//                     indexMax = k;
//                 }
//             }
//             int temp = array[i, j];
//             array[i, j] = array[i, indexMax];
//             array[i, indexMax] = temp;
//         }
//     }
//     return array;
// }

// int[,] sortArray = Create2DArray(5, 7, 0, 9);

// Show2DArray(sortArray);
// Console.WriteLine();
// Show2DArray(SortRowsElementDecrease(sortArray));

// ================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// ----------------------------------------------------------------

// int[,] Create2DArray(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ShowArray(int[] array)
// {
//     for (int j = 0; j < array.Length; j++)
//     {
//         Console.Write(array[j] + "| ");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

// int[] SumOfRowsMatrix(int[,] array)
// {
//     int[] arrayString = new int[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         arrayString[i] = sum;
//     }
//     return arrayString;
// }

// int MinumalNumberOfRows(int[] array)
// {
//     int indexMin = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < array[indexMin])
//         {
//             indexMin = i;
//         }
//     }
//     return indexMin + 1;
// }

// int[,] inputArray = Create2DArray(5, 5, 0, 9);

// Show2DArray(inputArray);
// Console.WriteLine();
// Console.Write($"Sum each row of the matrix: ");
// ShowArray(SumOfRowsMatrix(inputArray));
// Console.Write($"Row with minimal sum of elements: ");
// Console.WriteLine(MinumalNumberOfRows(SumOfRowsMatrix(inputArray)));
// Console.WriteLine();

// ================================================================
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// ----------------------------------------------------------------

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MatrixMult(int[,] matrixA, int[,] matrixB, int maxMatrix)
// {
//     int[,] matrixC = new int[maxMatrix, maxMatrix];
//     int i, j;
//     for (i = 0; i < maxMatrix; i++)
//     {
//         for (j = 0; j < maxMatrix; j++)
//         {
//             for (int m = 0; m < matrixA.GetLength(1); m++) // TODO: Количество строк первой матрицы больше количества ее столбцов.
//             {
//                 int scalarComponent = matrixA[i, m] * matrixB[m, j];
//                 matrixC[i, j] += scalarComponent;
//             }
//         }
//     }
//     return matrixC;
// }

// int MaxIndexRowOrColumn(int[,] array)
// {
//     int maxIndex = 0;
//     if (array.GetLength(0) > array.GetLength(1))
//         maxIndex = array.GetLength(0);
//     else
//         maxIndex = array.GetLength(1);
//     return maxIndex;
// }

// int[,] matrixA = new int[,]
// {
//     {1,2},
//     {3,4},
//     {5,6},
//     {7,8},
//     {9,10}
// };

// int[,] matrixB = new int[,]
// {
//     {8,7,6,5,9},
//     {4,3,2,1,0}
// };

// int maxIndexMatrixA = MaxIndexRowOrColumn(matrixA);
// int maxIndexMatrixB = MaxIndexRowOrColumn(matrixB);

// Show2DArray(matrixA);
// Console.WriteLine();
// Show2DArray(matrixB);
// Console.WriteLine();

// if (matrixA.GetLength(0) != matrixB.GetLength(1))
// {
//     Console.WriteLine("Incorrect matrix sizes");
// }
// else
// {
//     int[,] matrixC = MatrixMult(matrixA, matrixB, maxIndexMatrixA);
//     Console.WriteLine("Result of multiplying two matrices:");
//     Show2DArray(matrixC);
//     Console.WriteLine();
// }

// ================================================================
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// ----------------------------------------------------------------

// int[,,] Create3DArray(int lengthArray, int widthArray, int highArray, int minValue, int maxValue)
// {
//     int[,,] matrix3D = new int[lengthArray, widthArray, highArray];
//     for (int i = 0; i < lengthArray; i++)
//     {
//         for (int j = 0; j < widthArray; j++)
//         {
//             for (int k = 0; k < highArray; k++)
//             {
//                 matrix3D[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return matrix3D;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($" {array[i, j, k]} - ({i},{j},{k}) | ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] array3D = Create3DArray(2, 2, 2, 10, 99);

// Show3DArray(array3D);

// ================================================================
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// ----------------------------------------------------------------

// int nextNumber = 0;
// int rows = 9;
// int columns = 9;

// string GetNextNumber()
// {
//     nextNumber++;
//     return nextNumber.ToString("D2");
// }
// string[,] SpiralFillMatrix() // TODO: Корректно работает с квадратными матрицами. Для прямоугольных нужно доработать.
// {
//     string[,] matrix = new string[rows, columns];
//     int rowStart = 0, colStart = 0;
//     int rowEnd = matrix.GetLength(0) - 1;
//     int colEnd = matrix.GetLength(1) - 1;
//     while (rowStart <= rowEnd && colStart <= colEnd)
//     {
//         // LEFT -> RIGHT
//         for (int j = colStart; j <= colEnd; j++)
//         {
//             matrix[rowStart, j] = GetNextNumber();
//         }
//         rowStart++;

//         // TOP -> BOTTOM
//         for (int i = rowStart; i <= rowEnd; i++)
//         {
//             matrix[i, colEnd] = GetNextNumber();
//         }
//         colEnd--;

//         // RIGHT -> LEFT
//         for (int j = colEnd; j >= colStart; j--)
//         {
//             matrix[rowEnd, j] = GetNextNumber();
//         }
//         rowEnd--;

//         // BOTTOM -> TOP
//         for (int i = rowEnd; i >= rowStart; i--)
//         {
//             matrix[i, colStart] = GetNextNumber();
//         }
//         colStart++;
//     }
//     return matrix;
// }

// void Show2DArray(string[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Show2DArray(SpiralFillMatrix());