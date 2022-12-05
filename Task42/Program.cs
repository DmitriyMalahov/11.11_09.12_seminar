// Задача 42:
// Напишите программу, которая 
// 1. будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

string BinaryNum(int num)
{
    string bin = string.Empty;
    while (num > 0)
    {
        bin = num % 2 + bin;
        num /= 2;
    }
    return bin;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}");
    }
}

int[] BinaryN(int num)
{
    int n = num;
    int sizeArray = 0;
    while (n > 0)
    {
        n /= 2;
        sizeArray += 1;
    }
    int[] binArray = new int[sizeArray];
    for (int i = 0; i < binArray.Length; i++)
    {
        binArray[i] = num % 2; 
        // binArray[binArray.Length - 1] = num % 2; для разворота без доп методов.
        num /= 2;
    }
    // Array.Reverse(binArray);
    return binArray;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {number} преобразованное в двоичное -> {BinaryNum(number)}");

int[] binaryN = BinaryN(number);
ReverseArray(binaryN);
Console.Write($"Число {number} преобразованное в двоичное -> ");
PrintArray(binaryN);