// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; - заданная длина

// int[] array1 = new int[size]; - вводимый параметр

// int[] array2 = {3, 5, 7, 8};

// int[] array3 = new int[4]{3, 5, 7, 8};

// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next();
// }

int[] array = new int[8];

void RandomArray(int[] arrayLocal)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arrayLocal[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] arrayLocal)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{arrayLocal[i]} ");
    }
}

RandomArray(array);
PrintArray(array);
