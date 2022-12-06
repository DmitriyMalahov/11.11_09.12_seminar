// Задача 50. 
// Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, 
// 2. и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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

void FiendElement(int[,] matrix, int fiendRow, int fiendColumn)
{
    if (fiendRow < matrix.GetLength(0) && fiendColumn < matrix.GetLength(1))
        Console.WriteLine($"Такой элемент в массиве есть, он равен {matrix[fiendRow, fiendColumn]}");
    else Console.WriteLine($"{fiendRow}, {fiendColumn} -> такого элемента в массиве нет");
}


Console.WriteLine("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строк где располагается искомый элемент массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца где располагается искомый элемент массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minMatrix, maxMatrix);
PrintMatrix(array2D, "|", "|", "|"); ;
Console.WriteLine();
FiendElement(array2D, row, column);


