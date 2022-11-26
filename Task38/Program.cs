// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr, string symbol1, string symbol2)
{
    Console.Write(symbol1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}  ");
        else Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}  ");
    }
    Console.Write(symbol2);
}

double MaxArrayElement(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }

    return maxElement;
}

double MinArrayElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }

    return minElement;
}

double DifferenceMaxMin(double max, double min)
{
    double difference = max - min;
    return difference;
}

double[] array = CreateArrayRndDouble(sizeArray, minArray, maxArray);
double maxArrayElement = MaxArrayElement(array);
double minArrayElement = MinArrayElement(array);
double differenceMaxMin = DifferenceMaxMin(maxArrayElement, minArrayElement);
double differRound = Math.Round(differenceMaxMin, 1, MidpointRounding.ToZero);

PrintArray(array, "[", "] -> ");
Console.WriteLine($" Разница между максимальным и минимальным элементами массива = {differRound}");

