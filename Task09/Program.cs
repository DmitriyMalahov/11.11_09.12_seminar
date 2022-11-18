// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}"); // 78

// int firstDigit = number / 10; // 7
// int secondDigit = number % 10; // 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

// System.Console.WriteLine(Math.Max(firstDigit,secondDigit)); (то же самое, находит наибольшее из двух чисел).

int MaxDigit(int num) // int num = number
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;

    // int max = firstDigit > secondDigit ? firstDigit : secondDigit; // "?" - если(if); ":" - тогда(else). Тернарный оператор.
    // return max;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
