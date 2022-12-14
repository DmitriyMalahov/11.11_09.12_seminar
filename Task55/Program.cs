// Задача 55:
// 1. Задайте двумерный массив.
// Напишите программу, которая
// 2. заменяет строки на столбца.
// 3. В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.

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

// int[,] ReplacingRowsWithColumn(int[,] matrix) // метод с транспонированием.
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int[,] matrixNew = new int[columns, rows];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrixNew[j, i] = matrix[i, j];
//         }
//     }
//     return matrixNew;
// }

Console.WriteLine("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minMatrix, maxMatrix);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix, "|", "|", "|");
Console.WriteLine();

// if (matrix.GetLength(0) == matrix.GetLength(1))
// {
//     int[,] replacingMatrix = ReplacingRowsWithColumn(matrix);
//     Console.WriteLine("Массив с замененными строками на столбцы:");
//     PrintMatrix(replacingMatrix, "|", "|", "|");
// }
// else Console.WriteLine("Невозможно произвести замену.");


void ReplacingRowsWithColumnVoid(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows - 1; i++)
    {
        for (int j = i + 1; j < columns; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    ReplacingRowsWithColumnVoid(matrix);
    Console.WriteLine("Массив с замененными строками на столбцы:");
    PrintMatrix(matrix, "|", "|", "|");
}
else Console.WriteLine("Невозможно произвести замену.");
