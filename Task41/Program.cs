// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Укажите количество чисел которое Вы хотите ввести: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayInt(int size)
{
    int end = size;
    int[] arr = new int[size];
    for (int i = 0; i < end; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr[i] = n;
    }
    return arr;
}

void PrintArray(int[] arr, string symbol1, string symbol2)
{
    Console.Write(symbol1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write(symbol2);
}

void PositiveNumberCounter(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    Console.WriteLine(result);
}

int[] array = CreateArrayInt(number);
PrintArray(array, "", " введено чисел больше 0 -> ");
PositiveNumberCounter(array);
