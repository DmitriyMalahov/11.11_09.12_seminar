// Задача № 20:
// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит растояние между ними в 2D пространстве.

// А (3,6); В(2,1) -> 5,09
// А (7,-5); В(1,-1) -> 7,21 

// Теорема Пифагора - квадрат гипотенузы равен сумме квадратов катета:
// d = √ (х А – х В) 2 + (у А – у В) 2)

// int n = (3-2)*(3-2)+(6-1)*(6-1); // "26"
// double res = Math.Sqrt(n); // вычесление квадратного корня // "5,0990195135927845"

// double n1 = res;
// double nRound = Math.Round(n1, 2, MidpointRounding.ToZero); //Округление до 2 знаков // "5,09"


Console.WriteLine("Введите координаты X точки A");
Console.Write("XA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A");
Console.Write("YA: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты X точки B");
Console.Write("XB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B");
Console.Write("YB: ");
double yB = Convert.ToDouble(Console.ReadLine());

double Distans(double xAc, double yAc, double xBc, double yBc)
{
double rootX = ((xAc-xBc)*(xAc-xBc));
double rootY = ((yAc-yBc)*(yAc-yBc));
return Math.Sqrt(rootX+rootY);
}

double distans = Distans(xA,yA,xB,yB);
double distansRound = Math.Round(distans, 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние между точками А и В равно {distansRound}");
 