// Задача 26: Напишите программу, которая 
// 1. ринимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int NumLength(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }

//     return count == 0 ? 1 : count;
// }

// if (number < 0) number = - number;
// int numLength = NumLength(number);
// Console.WriteLine($"Количество цифр в числе {number} равно {numLength}");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumLength(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }

    return count == 0 ? 1 : count;
}

if (number < 0) number = - number;
int numLength = NumLength(number);
Console.WriteLine($"Количество цифр в числе {number} равно {numLength}");

// Math.Abs(); перевод из отрицательного числа.