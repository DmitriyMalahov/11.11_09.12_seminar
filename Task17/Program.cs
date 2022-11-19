// Задача № 17:
// Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y),
// 2. причем X не равняется 0 и Y не равняется 0 и 
// 3. выдает номер четверти плоскости, в которой находится эта точка.

//           Y
//           ^
//           |
//      2    |    1
//           |
//    ------------------> X
//           |
//      3    |     4            

// если х>0 и y>0 то будет 1 четверть
// если х<0 и y>0 то будет 2 четверть
// если х<0 и y<0 то будет 3 четверть
// если х>0 и y<0 то будет 4 четверть

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quater = Quater(x, y);

string result = quater > 0
        ? $"Указанные координаты соответсвуют четверти {quater}"
        : "Введены некорректные координаты";
Console.WriteLine(result);