// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int sumDigits = SumDigits(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} равна {sumDigits}");
}
else
    Console.WriteLine("Введено неккоректное значение");

int SumDigits(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }

    return sum;
}

