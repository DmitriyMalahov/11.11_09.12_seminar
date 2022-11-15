// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1)
{
    max = number2;
    Console.WriteLine($"Наибольшее число {number2}, наименьшее число {number1}");
}
else
{
    Console.WriteLine($"Наибольшее число {number1}, наименьшее число {number2}");
}