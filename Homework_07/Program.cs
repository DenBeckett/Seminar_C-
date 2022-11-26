// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int week = Convert.ToInt32(Console.ReadLine());

if (week > 7)
{
    Console.WriteLine("Введено неправильное число");
}
    else if (week == 6 || week == 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий день");