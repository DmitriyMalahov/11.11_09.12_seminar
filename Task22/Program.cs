// Задача № 22:
// Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдает таблицу квадратов от 1 до N.

// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    Console.WriteLine("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 1) Console.WriteLine("Введено некорректное значение");
}

Console.WriteLine($"Таблица квадратов чисел от 1 до {number}: ");

void TableSquare(int num)
{
    for (int count = 1; count <= num; count++)
    {
                Console.WriteLine($"{count}|{count*count}");
    }
}

TableSquare(number);

// string TableSquare1(int num)
// {
//     int count = 1;
//     string table = "";
//     while(count <= num)
//     {
//         table = table + $"{count}|{count*count} \n";
//         count++;
//     }
//     return table;
// }

// string tableSquare = TableSquare1(number);
// Console.WriteLine(tableSquare);

