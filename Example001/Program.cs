// Функция для рисования елочки с заданной высотой и уровнем
void draw_tree(int height, int level)
{
   {
   // Если уровень равен высоте дерева, то возвращаемся 
    if (level == height) return;
   } 

    // Рассчитываем количество пробелов и звездочек для текущего уровня
    int spaces = height - level - 1;
    int stars = level * 2 + 1;

    // Выводим пробелы и звездочки в консоль
    for (int i = 0; i < spaces; i++) Console.Write(" ");
    for (int i = 0; i < stars; i++) Console.Write("*");
    Console.WriteLine();

    // Рекурсивно вызываем функцию для следующего уровня
    draw_tree(height, level + 1);
}
Console.WriteLine("Напиши число");
int height = Convert.ToInt32(Console.ReadLine());
int level = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


