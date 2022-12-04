// Задача 42:
// Напишите программу, которая 
// 1. будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string BinaryNum(int num)
// {
//     string bin = string.Empty;
//     while (num > 0)
//     {
//         bin = num % 2 + bin;
//         num /= 2;
//     }
// return bin;
// }

// Console.WriteLine($"Число {number} преобразованное в двоичное -> {BinaryNum(number)}");

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}");
    }
}

int[] BinaryN(int num)
{
    int n = num;
    int i = 0;
    while (n > 0)
    {
        n /= 2;
        i += 1;
    }
    int[] bin = new int[i];
    for (int j = 0; j < bin.Length; j++)
    {
        bin[j] = num % 2;
        num /= 2;
    }
    return bin;
}
int[] binaryN = BinaryN(number);
Array.Reverse(binaryN);
Console.Write($"Число {number} преобразованное в двоичное -> ");
PrintArray(binaryN);