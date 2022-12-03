//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа равна {SumNumbers(number)}");

int SumNumbers(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int digit = num%10;
        sum = sum + digit;
        num = num/10;
    }
    return sum;
}