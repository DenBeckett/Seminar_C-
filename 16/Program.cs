// Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsCorrectNumbers(m, n) ? $"Произведение чисел {m} и {n} = {FindProductNumbers(m, n)}" : "Введенные числа не допустимы");


int FindProductNumbers(int num1, int num2)
{
    int prod = 1;
    for (int i = num1; i <= num2; i++)
    {
        prod = prod * i;
    }
    return prod;
}

bool IsCorrectNumbers(int num1, int num2)
{
    if (num1 < num2 && num1 != 0) return true;
    else return false;
}