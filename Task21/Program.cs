// Задача 21
// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X точки A");
Console.Write("XA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A");
Console.Write("YA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки A");
Console.Write("ZA: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты X точки B");
Console.Write("XB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B");
Console.Write("YB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки B");
Console.Write("ZB: ");
double zB = Convert.ToDouble(Console.ReadLine());



double Distans(double xAc, double yAc, double zAc, double xBc, double yBc, double zBc)
{
    double rootX = ((xAc - xBc) * (xAc - xBc));
    double rootY = ((yAc - yBc) * (yAc - yBc));
    double rootZ = ((zAc - zBc) * (zAc - zBc));
    return Math.Sqrt(rootX + rootY + rootZ);
}

double distans = Distans(xA, yA, zA, xB, yB, zB);
double distansRound = Math.Round(distans, 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние между точками А, В и Z в 3D пространстве равно {distansRound}");