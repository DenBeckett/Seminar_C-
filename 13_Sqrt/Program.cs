//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i =1; i <= N; i++)
{
    double j = Math.Pow(i,2);
    Console.Write($"{j} ");
}