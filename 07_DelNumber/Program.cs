//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.WriteLine();
int num = new Random().Next(100, 1000);
int num1 = num / 100;
int num2 = num % 10;
int newnum = num1 * 10 + num2;
Console.WriteLine(num);
Console.WriteLine(newnum);