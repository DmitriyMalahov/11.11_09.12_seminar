// Задача 43: 
// Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double СoordinateX(double ab, double ak, double cb, double ck)
{
double x = (cb - ab) / (ak - ck);
return x;
}

double СoordinateY(double ab, double ak, double xb)
{
double y = ak * xb + ab;
return y;
}

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (");
Console.Write($"{СoordinateX(b1, k1, b2, k2)}; ");

Console.Write(СoordinateY(b1, k1, СoordinateX(b1, k1, b2, k2)));
Console.Write(")");

