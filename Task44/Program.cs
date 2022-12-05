// Задача 44:
// Не используя рекурсию,
// 1. выведите первые N чисел Фибоначи.
// Первые два числа Фибоначи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



int[] CreateArrayInt(int size)
{
    int end = size;
    int[] arr = new int[size];
    for (int i = 0; i < end; i++)
    {
        arr[i] = i;
    }
    return arr;
}

int[] Fibonacci(int[] arr, int num)
{

    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayInt(number);
int[] fibonacci = Fibonacci(array, number);
Console.Write($"первые {number} чисел Фибоначи -> ");
PrintArray(fibonacci);