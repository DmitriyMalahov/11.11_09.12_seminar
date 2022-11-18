// Задача № 12.
// Напишите программу, которая будет
// 1. принимать два числа и 
// 2. выводить является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num1, int num2) // bool - метод "да" или "нет" (правда/лож).
{
    if (num1 % num2 == 0) return true; // "return num1 % num2 == 0;" (можно так).
    return false;
}

int Multiplicity2(int num1, int num2)
{
    return num1 % num2;
}

bool result = Multiplicity(number1, number2);
Console.WriteLine(result ? "Кратно" : $"Некратно, остаток {number1 % number2}");

int result2 = Multiplicity2(number1, number2);
Console.WriteLine(result2 == 0 ? "Кратно" : $"Некратно, остаток {result2}");