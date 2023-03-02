// // int FindQuart(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if(x < 0 && y > 0)
//         return 2;
//     if(x < 0 && y < 0)
//         return 3;
//     if(x > 0 && y < 0)
//         return 4;

//     return 0;

// }

// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Point located at {FindQuart(x, y)} quart");


//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// int FindQuart(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;
//     return 0;
// }
// Console.WriteLine("input x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Point locate at {FindQuart(x, y)} quart ");

// _________________________________
//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double x1, double y1, double x2, double y2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
// }

// Console.WriteLine("Input coordinate x of A point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate y of A point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate x of B point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate y of B point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double distance = FindDistance(x1, y1, x2, y2);
// Console.WriteLine($"Distance between A and B is: {distance}");


// Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindDia(int quart)
// {
//     if (quart == 1)
//         Console.WriteLine("x = (0, +∞),y = (0, +∞)");
//     if (quart == 2)
//         Console.WriteLine("x = (-∞, 0),y = (0, +∞)");
//     if (quart == 3)
//         Console.WriteLine("x = (-∞, 0),y = (-∞, 0)");
//     if (quart == 4)
//         Console.WriteLine("x = (0, +∞),y = (-∞, 0)");
//     // Console.WriteLine("0");
// }
// Console.WriteLine("input number of Quart: ");
// int quart = Convert.ToInt32(Console.ReadLine());
// if (quart > 1 && quart < 4)
// {
//     FindDia(quart);
// }
// else
// {
//     Console.WriteLine("Enter a number from 1 to 4");
// }
// Console.WriteLine($"Coordinates of Point: {FindDia}");


//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void Quad(int num)
// {
//     int current = 1;
//     while (current < num)
//     {
//         Console.Write(current * current + " ");
//         current++;
//     }
// }

// Console.WriteLine("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Quad(num);



