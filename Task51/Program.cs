// Задача 51:
// 1. Задайте двумерный массив.
// 2. найдите сумму элементов,
// находящихся на главной диагонали 
// (с индексами (0,0); (1,1) и т.д.)

// Например:

//  1  4  7  2
//  5  9  2  3
//  8  4  2  4

//  Сумма элементов главной диагонали: 1 + 9 + 2 = 12.

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

// int SumDiagonalElMat(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) sum += matrix[i, j];
//         }
//     }
//     return sum;
// }

int SumDiagonalElMat(int[,] matrix)
{
    int sum = 0;
    int minIndex = matrix.GetLength(0);
    if (matrix.GetLength(1) < minIndex) minIndex = matrix.GetLength(1);
    for (int i = 0; i < minIndex; i++)
        sum += matrix[i, i];
    return sum;
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
int sumDiagonal = SumDiagonalElMat(array2D);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sumDiagonal}");