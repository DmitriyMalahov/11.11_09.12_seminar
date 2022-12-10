// Задача 58: 
// 1. Задайте две матрицы. 
// 2. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] CompositionTwoMatrix(int[,] mat1, int[,] mat2)
{
    int row = mat1.GetLength(0);
    int column = mat2.GetLength(1);
    int[,] mat3 = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
                mat3[i,j] += mat1[i,k] * mat2[k,j];
            }
        }
    }
    return mat3;
}

int[,] matrix1 = CreateMatrixRndInt(3, 2, 1, 5);
Console.WriteLine("Исходная матрица № 1:");
PrintMatrix(matrix1, "|", "|", "|"); ;
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(2, 3, 1, 5);
Console.WriteLine("Исходная матрица № 2:");
PrintMatrix(matrix2, "|", "|", "|"); ;
Console.WriteLine();

// Матрицу 1 можно умножить на матрицу 2 только в том случае, 
// если число столбцов матрицы 1 равняется числу строк матрицы 2. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.

if (matrix1.GetLength(0) == matrix2.GetLength(1))
{
Console.WriteLine("Mатрица № 3 равная произведению Матрицы № 1 и Матрицы № 2:");
int[,] matrix3 = CompositionTwoMatrix(matrix1, matrix2);
PrintMatrix(matrix3, "|", "|", "|"); 
}
else Console.WriteLine("Невозможно вычеслить произведение Матрицы №1 и Матрицы № 2");
