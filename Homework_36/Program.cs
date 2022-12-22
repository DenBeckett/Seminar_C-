//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число N");
double n = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {FindAckermann(m,n)}");

double FindAckermann(double firstValue, double secondValue)
{
    if (firstValue == 0) return secondValue + 1;
    if (secondValue == 0) return FindAckermann(firstValue - 1, 1);
    else return FindAckermann(firstValue - 1, FindAckermann(firstValue, secondValue - 1));
}