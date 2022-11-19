// Задача 15: 
// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число обозначающие день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Check(int numCheck)
{
    return (numCheck == 7) || (numCheck == 6);
}
bool check = Check(number);
Console.WriteLine(check ? "Да" : "Нет");

if(number <=7)Check(number);
else Console.WriteLine("Такого дня недели нет");

