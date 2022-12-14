// Задача 66: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// 3. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalNumbers(numberM, numberN);
Console.WriteLine(sum);

int SumNaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        if (numM == numN) return numN;
        return SumNaturalNumbers(numM + 1, numN) + numM;
    }
    else
    {
        if (numM == numN) return numM;
        return SumNaturalNumbers(numN + 1, numM) + numN;
    }
}

