// Задача 69:

// Напишите программу, которая на вход принимает два  числа А и В, и
// возводит число А в целую степень В с помощью рекурсии.

// А = 3; В = 5 -> 243 
// А = 2; В = 3 -> 8

Console.Write("Введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num, int degree)
{
    if (degree == 0) return 1;
    return num * Exponentiation(num, degree - 1);
}

int ExponentiationOptimized(int num, int degree)
{
    if (degree == 0) return 1;
    else if (degree % 2 == 0) return ExponentiationOptimized(num * num, degree / 2);
    else return ExponentiationOptimized(num, degree - 1) * num;
}

Console.WriteLine(Exponentiation(number1, number2));
Console.WriteLine(ExponentiationOptimized(number1, number2));
