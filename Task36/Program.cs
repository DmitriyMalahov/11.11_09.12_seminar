// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddSumNumbers (int[] arr)
{
    int position = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        if(i % 2 == 1) position += arr[i];
    }
    return position;
}


int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
PrintArray(array, "[", "] -> ");
int oddSumNumbers = OddSumNumbers(array);
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях в массиве = {oddSumNumbers}");