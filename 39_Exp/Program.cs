﻿//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

Console.Write("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

//int exp = 1;
Console.WriteLine(GetExp(m,n));

int GetExp(int num1, int num2)
{
    if (num2 == 0) return 1;
    return m * GetExp(num1,num2 - 1);
}