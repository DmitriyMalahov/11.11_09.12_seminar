// Задача 13: 
// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}

bool Check(int numCheck)
{
    return (numCheck >= 100);
}

bool check = Check(number);
Console.WriteLine(check ? $"третья цифра введенного числа: {ThirdDigit(number)}" : "Третьтьей цифры нет");

int ThirdDigit(int num)
{
    int result = 0;
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
    return result;
}






// int ThirdDigit(int number)
//         {
//             int result = -1;
//             if (number >= 100)
//             {
//                 while (number > 999)
//                 {
//                     number = number / 10;
//                 }
//                 result = number % 10;
//             }
//             return result; 
//         }




