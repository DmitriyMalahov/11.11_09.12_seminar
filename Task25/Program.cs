// Задача 25: 
// 1. Напишите цикл, который принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

double Power(double num1, double num2)
{
    double result = 1;

    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }

    return result;
}

if ((number1 > 0) && (number2 > 0))
{
    double pow = Power(number1, number2);
    Console.WriteLine($"Число {number1} в степени {number2} = {pow}");
}
else 
Console.WriteLine("Введено некоррекное значение");



