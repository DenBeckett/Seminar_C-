Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while(b <= a)
{
    if(b%2 == 0)
    {
        Console.Write($"{b} ");
        b++;
    }
    else b++;
}
Console.WriteLine();