// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. 
// 2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2    = 14
// 5 9 2 3    = 19
// 8 4 2 4    = 16
// 5 2 6 7    = 20

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string symbol1, string symbol2, string symbol3)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{symbol1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}{symbol2}");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine($"{symbol3}");
    }
}

void PrintArray(double[] arr, string symbol1, string symbol2)
{
    Console.Write(symbol1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero),5},");
        else Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero),5}");
    }
    Console.Write(symbol2);
}

double[] FindSumRows(int[,] matrix)
{
    int columns = matrix.GetLength(0);
    double[] sumArr = new double[columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArr[i] += matrix[i, j];
        }
    }
    return sumArr;
}

void FindeMinSumRows(double[] arr)
{
    double count = 0;
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            count = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {count + 1} строка.");
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов в массиве: {count}");

}

int[,] array2D = CreateMatrixRndInt(10, 6, 1, 9);
PrintMatrix(array2D, "|", "|", "|"); ;
Console.WriteLine();
double[] sumRows = FindSumRows(array2D);
Console.WriteLine("Сумма элементов каждой строки:");
PrintArray(sumRows, "[", "]");
Console.WriteLine();
FindeMinSumRows(sumRows);
