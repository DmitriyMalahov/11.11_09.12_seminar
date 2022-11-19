// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 & number <= 100000)
{
    Console.WriteLine("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 10000 & number <= 100000) Console.WriteLine("Введено некорректное значение"); 
}

int number1 = number;
int numberInverted = 0;

while (number1 > 0)
{
    int count = number1 % 10;
    numberInverted = numberInverted * 10 + count;
    number1 = number1 / 10;
}

Console.WriteLine(number == numberInverted ? "да" : "нет");
