// Задача 40:
// Напишите программу, которая
// 1. принимает на вход три числа и
// 2. проверяет, может ли существовать треугольник с сторонами такoй длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
// суммы двух других сторон.


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Check(int num1, int num2, int num3)
{
    return (num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num2 + num1);
}

bool check = Check(number1, number2, number3);
Console.WriteLine(check ? "треугольник со сторонами такой длинны может существовать" : "треугольник со сторонами такой длинны не может существовать");