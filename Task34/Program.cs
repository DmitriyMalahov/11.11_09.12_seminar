// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string symbol1, string symbol2)
{
    Console.Write(symbol1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine(symbol2);
}

int AnEvenNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = CreateArrayRndInt(sizeArray, 100, 999);
PrintArray(array, "[", "]");
int anEvenNumbers = AnEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {anEvenNumbers}");
