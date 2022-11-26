// Задача 35:
// 1. Задайте одномерный массив из чисел 123 случайных чисел.
// 2. Найдите количество элементов массива, 
// 3. значение которых лежит в отрезке [10,99].

// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14] -> 5

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int TwoDigits(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100) result++;
    }
    return result;
}

int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
PrintArray(array);
int twoDigits = TwoDigits(array);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке от 10 до 99 = {twoDigits}");