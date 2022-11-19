// Задача № 22:
// Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдает таблицу квадратов от 1 до N.

// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица квадратов от 1 до {number}: ");
void TableSquare(int num)
{
    for (int count = 1; count <= num; count++)
    {
                Console.WriteLine($" {count}   |  {count*count} ");
    }
    return;
}

TableSquare(number);


