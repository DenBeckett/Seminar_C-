//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int  Namber = Convert.ToInt32(Console.ReadLine());

if (Namber % 7 ==0)
{
    if (Namber % 23 ==0)
    {
        Console.WriteLine($"{Namber} -> да");
    }
    else
    {
        Console.WriteLine($"{Namber} -> нет");
    }
}
else
{
    Console.WriteLine($"{Namber} -> нет");
}