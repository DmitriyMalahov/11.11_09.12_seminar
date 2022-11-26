// Задача 37:
// 1. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 2. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 9 6] -> 36 21

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
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(symbol2);
}

int [] CreateNewArrayInt(int[] arr)
{
    int newSize = arr.Length / 2;
    if (arr.Length % 2 == 1) newSize +=1;
    int [] newArray = new int [newSize];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArray[i] = arr[i] * arr [arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArray[newSize - 1] = arr[arr.Length / 2];
    return newArray;
}

int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
PrintArray(array, "[", "]");
int[] newArr = CreateNewArrayInt(array);
PrintArray(newArr, " -> ", "");