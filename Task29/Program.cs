// Задача 29: 
// Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void RandomArray(int[] arrayLocal)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arrayLocal[i] = rnd.Next(0, 33);
    }
}

void PrintArray(int[] arrayLocal)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.Write($"{arrayLocal[i]}, ");
    }
}

RandomArray(array);
PrintArray(array);
