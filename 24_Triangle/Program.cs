//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a,b,c)? "Треугольник с заданными сторонами возможен" : "Треугольник с заданными сторонами невозможен");

bool CheckTriangle(int a, int b, int c)
{
    if (a+b>c && b+c>a && a+c>b) return true;
    else return false;
}