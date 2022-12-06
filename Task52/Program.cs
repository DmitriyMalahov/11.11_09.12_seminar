// Задача 52. 
// 1. Задайте двумерный массив из целых чисел. 
// 2. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] FindSumColumn(int[,] matrix)
{
    int columns = matrix.GetLength(1);

    double[] sumArr = new double[columns];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumArr[j] += matrix[i, j];
            count++;
        }
        sumArr[j] = sumArr[j] / count;
    }
    return sumArr;
}

Console.WriteLine("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minMatrix, maxMatrix);
PrintMatrix(array2D, "|", "|", "|"); ;
Console.WriteLine();
double[] findSumColumn = FindSumColumn(array2D);
Console.Write("Среднее арифметическое каждого столбца:");
PrintArray(findSumColumn, "[", "]");
