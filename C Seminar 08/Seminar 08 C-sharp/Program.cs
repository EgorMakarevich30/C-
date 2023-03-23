//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2


// int[,] ChangeRows (int[,] array, int row1, int row2)
// {
//     row1--; row2--;
//     if(row1>= array.GetLength(0) || row2 >= array.GetLength(0))
//     return array;
//     else
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
//         }
//     }
//     return array;
// }

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }
// // 1 2 3
// // 4 5 6
// // 7 8 9

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер первой строки для замены ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер второй строки для замены ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);

// myArray = ChangeRows(myArray, row1, row2);

// Show2DArray(myArray);

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

// int[,] RowsToColumns (int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Невозможно выполнить для данного массива");
//         return array;
//     }
//     else
//     {
//         for(int i = 0; i < array.GetLength(0) - 1; i++)
//             for(int j = i + 1; j < array.GetLength(0); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
//     }
//     return array;
// }

int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] myArray = new int[rows, columns];
    for(int i = 0; i < rows;i++)
    {
        for(int j = 0; j < columns;j++)
        {
            myArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return myArray;
}
// // 1 2 3
// // 4 5 6
// // 7 8 9

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);

// myArray = RowsToColumns(myArray);

// Show2DArray(myArray);




//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// занулить, а не удалить


int[,] DelMinRowAndColumn (int [,] array)
{
    int min = array[0,0];
    int minRow = 0;
    int minColumn = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(min > array[i,j])
            {
                min = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(minColumn == j || minRow == i)
            array[i,j] = 0;
        }
    }
    return array;
}

int[,] myArray = Create2DRandomArray(5,5,0,9);
DelMinRowAndColumn(myArray);
Show2DArray(myArray);