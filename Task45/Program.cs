// Задача 45:

// Напишите программу, которая
// 1. будет создавать копию заданного массива с помощью 
// поэлементного копирования.

Console.WriteLine("Введите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

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
        if (i < arr.Length - 1) Console.Write($"{arr[i]}  ");
        else Console.Write($"{arr[i]}  ");
    }
    Console.Write(symbol2);
}

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
Console.Write("Исходный массив:      ");
PrintArray(array, "[", "]");
Console.WriteLine();

int[] copyArray = CopyArray(array);
Console.Write("Скопированный массив: ");
PrintArray(copyArray, "[", "]");
