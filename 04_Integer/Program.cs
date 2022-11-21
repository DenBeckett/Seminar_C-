/ Напишите программу, которая на вход принимает одно число(N),а на
//выходе показывает все целые числа от -N до N

Console.Clear();

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());
int i=(-1)*num;

while(i <= num)
{
    Console.WriteLine(i);
    i++;
}