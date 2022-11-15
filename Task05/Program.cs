// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");

int numb = Convert.ToInt32(Console.ReadLine());

if (numb > 0) {
int numb1 = -numb;

int count = numb1;

while (count <= numb)
{
    Console.Write(count + " ");
    count++;
}
}

else  Console.Write("Введено неккоректное значение");