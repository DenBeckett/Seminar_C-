//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Write("Введите число: ");
string numstring = (Console.ReadLine() ?? " ");
int i = 0;
int num;
Console.WriteLine(numstring == "" ? "Ничего не было введено!" : FindRazr(numstring));

int FindRazr(string x)
{

    num = Convert.ToInt32(x);
    while (num > 0)
    {
        i++;  // и есть разрядность
        num /= 10;
    }

    return i;
}