//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.WriteLine("Третьей цифры нет");
else
{
    int num1 = num / 100;
    int num2 = num1 % 10;

    Console.WriteLine($"{num2}");
}