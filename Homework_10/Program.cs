// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());

if (M < N) 
{
    Console.WriteLine("Число M должно быть больше N");
}
else
{
    for (int i = N; i <= M; i++)
    {
        double j = Math.Pow(i,3);
        Console.Write($"{j} ");
    }
}