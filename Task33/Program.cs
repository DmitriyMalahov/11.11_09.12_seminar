// Задача 33:
// 1. Задайте массив.
// Напишите программу, которая
// 2. определяет, присуствует ли заданное число в массиве.

// 4; массив [6,7,19,345,3] -> нет 
// 3; массив [6,7,19,345,3] -> да

Console.WriteLine("Введите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое необходимо найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);

    }
    return arr;
}

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

bool PresenceNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
PrintArray(array);
Console.WriteLine(PresenceNumber (array, number) ? "Да" : "Нет");