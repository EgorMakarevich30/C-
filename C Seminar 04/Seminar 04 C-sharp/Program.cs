// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));



// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// //4  -> 24
// //5  -> 120

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

int FindSum (int num)
{
    int sum = 0;
    for (int current = 1; current <= num; current++)
    {
        sum += current;// sum = sum + current;
    }
    return sum;
}

Console.WriteLine ("Input A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (FindSum (a));