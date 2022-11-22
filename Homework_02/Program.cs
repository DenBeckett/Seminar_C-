Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b) 
{
    max = a;
}
    else if(b > c)
    {
    max = b;
    }
    else max = c;
Console.WriteLine($"max = {max}");