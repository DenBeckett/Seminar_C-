//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} равно {FindExpNumbers(a, b)}");

double FindExpNumbers(int num1, int num2)
{
    double exp = 1;
    for (int n = 0; n < num2; n++)
    {
        exp *= num1;
    }
    return exp;
}