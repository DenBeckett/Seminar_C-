//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

GetNumbersList(m,n);
Console.WriteLine();

int GetNumbersList(int minValue, int maxValue)
{
    if (minValue % 2 == 0) Console.Write($"{minValue} ");
    if (minValue == maxValue) return maxValue;
    return GetNumbersList(minValue + 1,maxValue);
}