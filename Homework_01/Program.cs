Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b) 
{
max = a;
}
    else 
    {
    max = b;
    }
Console.WriteLine($"max = {max}");