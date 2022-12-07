// Задача 57:
// 1. Сосотавить частотный словарь элементов двумерного масива.
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// {1, 9, 9, 0, 2, 8, 0, 9 } -> 0 встречается 2 раза
//                              1 встречается 1 раз
//                              2 встречается 1 раз
//                              8 встречается 1 раз
//                              9 встречается 2 раза

// 1, 2, 2                   -> 1 встречается 3 раза
// 4, 6, 1                      2 встречается 2 раза
// 2, 1, 6                      3 встречается 1 раз
//                              4 встречается 1 раз
//                              6 встречается 2 раза

// Array.Sort(array); // Разворот одномерного масива.


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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i, j];
        }
    }
    return arr;
}

// int[] MatrixToArray(int[,] matrix) //преобразование двумерного массива в одномерный(вариант с переменными).
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int[] arr = new int[matrix.Length];
//     int k = 0;
//         for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             arr[k] = matrix[i, j];
//             k++;
//         }
//     }
//     return arr;
// }

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

// void CountValue(int[] arr)
// {
//     int count = 1;
//     int num = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] == num) count++;
//         else
//         {
//             Console.WriteLine($"число {num} встречается в массиве {count} раз.");
//             count = 1;
//             num = arr[i];
//         }
//     }
//     Console.WriteLine($"число {num} встречается в массиве {count} раз.");
// }

int SizeRequencyElemsArray(int[] arr) //Метод который узнает размер матрицы.
{
    int size = 0;
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != temp)
        {
            size++;
            temp = arr[i];
        }
    }
    return size;
}

int[,] RequencyElemsArray(int[] arr) //Запись подсчета в двумерный массив
{
    int size = SizeRequencyElemsArray(arr);
    int temp = 0;
    int[,] matrix = new int[size, 2];
    int index = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != temp)
        {
            index++;
            temp = arr[i];
            matrix[index, 0] = arr[i];
        }
        if (arr[i] == temp)
            matrix[index, 1]++;
    }
    return matrix;
}

void PrintMatrixSpecial(int[,] matrix, string beginRow, string firstRow, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"{matrix[i, j],2}{firstRow}");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(endRow);
    }
}

Console.WriteLine("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minMatrix, maxMatrix);
Console.WriteLine("Исходный двумерный массив:");
PrintMatrix(matrix, "|", "|", "|");
Console.WriteLine();
int[] array = MatrixToArray(matrix);
Array.Sort(array);
Console.WriteLine("Упорядоченный одномерный массив:");
PrintArray(array);
Console.WriteLine();
// CountValue(array);

int[,] requencyElemsArray = RequencyElemsArray(array);
PrintMatrixSpecial(requencyElemsArray, "Число", " повторяется", " раз");
