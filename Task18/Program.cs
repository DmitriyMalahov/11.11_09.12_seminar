// Задача № 18:
// Напишите программу, которая по 
// 1. заданному номеру четверти
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

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

Console.WriteLine("Введите номер четверти");
Console.Write("№: ");
int quater = Convert.ToInt32(Console.ReadLine());

string Range(int quater1)
{
    if (quater1 == 1) return "x > 0 и y > 0";
    if (quater1 == 2) return "x < 0 и y > 0";
    if (quater1 == 3) return "x < 0 и y < 0";
    if (quater1 == 4) return "x > 0 и y < 0";
    return "Такой четверти нет";
}

string range = Range(quater);
Console.WriteLine(range);
