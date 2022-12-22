//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} равна {GetSumList(m,n)}");

int GetSumList(int minValue, int maxValue)
{
    if (minValue == maxValue) return minValue;
    return minValue + GetSumList(minValue + 1,maxValue);
}