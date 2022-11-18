// Задача № 16.
// Напишите программу, котрая
// 1. принимает ДВА числа и
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}

bool result = Square(number1, number2);

Console.WriteLine(result ? "да" : "нет");