//Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа,
//необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

int AreaofCircle(int num)
{
    double result = Math.Ceiling(Math.PI * Math.Pow(num, 2));
    int result1 = Convert.ToInt32(result);
    return result1;
}

int MaxNumber(int num)
{
    int maxnum = 0;
    while (num != 0)
    {
        int digit = num%10;
        if (digit > maxnum) maxnum = digit;
        num = num/10;
    }
    return maxnum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Максимальная цифра в площади круга радиуса {num} - {MaxNumber(AreaofCircle(num))}");