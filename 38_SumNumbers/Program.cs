//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
//453 -> 12
//45 -> 9

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

//int sum = 0;

Console.WriteLine(GetSumNumbers(num));

int GetSumNumbers(int num)
{
    if (num == 0) return 0;
    return num%10 + GetSumNumbers(num/10);
}