//Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Наибольший общий делитель чисел {m} и {n} - {FindDivisor(m,n)}");

int FindDivisor(int firstValue, int secondValue)
{
    if (firstValue % secondValue == 0) return n;
    n = firstValue % secondValue;
    return FindDivisor(secondValue,n);
}