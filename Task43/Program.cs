// Задача 43: 
// Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double СoordinatesX(double ab, double ak, double cb, double ck)
{
double x = (b2 - b1) / (k1 - k2);
return x;
}
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (");
Console.Write($"{СoordinatesX(b1, k1, b2, k2)}; ");

double СoordinatesY(double ab, double ak, double xb)
{
double y = k1 * xb + b1;
return y;
}
Console.Write(СoordinatesY(b1, k1, СoordinatesX(b1, k1, b2, k2)));
Console.Write(")");

