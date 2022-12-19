//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.Write("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

GetSequence(m,n);

void GetSequence(int min, int max)
{
    if (min > max) return;
    Console.Write($"{min} ");
    GetSequence(min + 1, max);
}