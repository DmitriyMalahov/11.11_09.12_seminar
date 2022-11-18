// Задача № 14.
// Напишите программу, котрая
// 1. принимает на вход число и
// 2. проверяет кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// bool Multiplicity(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0) return true;
//     return false;
// }

bool Multiplicity(int num)
{
return (num % 7 == 0) && (num % 23 == 0);
}

bool result = Multiplicity(number);

Console.WriteLine(result ? "да" : "нет");

