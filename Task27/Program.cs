// Задача 27: 
// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = Math.Abs(number);
}

bool Check(int num)
{
    return (num > 0);
}

int SumDigits(int number1)
{
    number1 = number;
    int numberInv = 0;
    int sum = 0;

    while (number1 > 0)
    {
        int digit = number1 % 10;
        numberInv = numberInv * 10 + digit;
        number1 = number1 / 10;
        sum = digit + sum;
    }
    return sum;
}

int sumDigits = SumDigits(number);
bool check = Check(number);
Console.WriteLine(check ? $"Cумма цифр числа {number} равна = {sumDigits}:" : "Введено не корректное значение");
