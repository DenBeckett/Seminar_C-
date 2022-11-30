//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int temp = 0;
while (num != 0)
{
    int digit = num%10;
    temp = temp*10 + digit;
    num = num/10;
}
Console.WriteLine($"Перевернутое число: {temp}");
if (num1==temp) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");