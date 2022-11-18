// Задача № 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число 
// 2. и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число --> {number}"); // 456

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100; // 4
    int thirdDigit = num % 10; // 6
    int removeSecondDigit = firstDigit * 10 + thirdDigit; // 4 * 10 + 6 = 46
    return removeSecondDigit;
}

// int firstDigit = number / 100;
// int secondDigit = number / 10 % 10;
// int thirdDigit = number % 10;

// Console.WriteLine($"Первая цифра --> {firstDigit}");
// Console.WriteLine($"Вторая цифра --> {secondDigit}");
// Console.WriteLine($"Третья цифра --> {thirdDigit}");

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Результат удаления второго числа --> {removeSecondDigit}");