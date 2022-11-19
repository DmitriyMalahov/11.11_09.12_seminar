// Задача 10: 
// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: "); // 456
int number = Convert.ToInt32(Console.ReadLine());

bool Check(int num)
{
    return (num >= 100) && (num < 1000);
}

bool check = Check(number);

int SecondNumber(int num)
{
num = num / 10 % 10;
return num;
}
int secondNumber = SecondNumber(number);

Console.WriteLine(check ? $"Вторая цифра введеного числа {secondNumber}" : "Введенное число не является трехзначным"); 
