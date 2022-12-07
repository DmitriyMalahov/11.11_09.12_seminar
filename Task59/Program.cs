// Задача 59:
// 1. Задайте двумерный массив из целых чисел.
// 2. напишите программу, которая
// удалит строку и столбец, на пересечении
// которых расположен нименьшей элемент массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим
// следующий массив:

// 9 2 3
// 4 2 4
// 2 6 7

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

void FindingMinElementIndex(int[,] matrix, out int indexRow, out int indexColumn)
{

    int min = matrix[0, 0];
    indexRow = 0;
    indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"минимальное значение в массиве: {min}");
    Console.WriteLine();
}

// int[,] DeleteRowColumns(int[,] matrix, int indexRow, int indexColumn)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int[,] matrix2 = new int[rows - 1, columns - 1];
//     int m = 0;
//     for (int i = 0; i < rows - 1; i++)
//     {
//         int n = 0;
//         if (m == indexRow) m++;
//         for (int j = 0; j < columns - 1; j++)
//         {
//             if (n == indexColumn) n++;
//             matrix2[i, j] = matrix[m, n];
//             n++;
//         }
//         m++;
//     }
//     return matrix2;
// }

int[,] DeleteRowColumns(int[,] matrix, int indexRow, int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows - 1, columns - 1];
    for (int i = 0, m = 0; i < rows - 1; i++, m++)
    {
        if (m == indexRow) m++;
        for (int j = 0, n = 0; j < columns - 1; j++, n++)
        {
            if (n == indexColumn) n++;
            matrix2[i, j] = matrix[m, n];
        }
    }
    return matrix2;
}

Console.WriteLine("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minMatrix, maxMatrix);
Console.WriteLine("Исходный двумерный массив:");
PrintMatrix(matrix, "|", "|", "|");
Console.WriteLine();

int rowIndex1, columnIndex1;
FindingMinElementIndex(matrix, out rowIndex1, out columnIndex1);

int[,] deleteRowColumns = DeleteRowColumns(matrix, rowIndex1, columnIndex1);
Console.WriteLine("Массив с удаленными строкой и столбцом, находящимеся на пересечение минимального элемента массива:");
PrintMatrix(deleteRowColumns, "|", "|", "|");