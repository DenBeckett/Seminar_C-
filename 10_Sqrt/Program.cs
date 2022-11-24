//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
    else if (b == a*a)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
        else Console.WriteLine("Числа не являются квадратами друг друга");
