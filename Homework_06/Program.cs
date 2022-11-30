//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
//double a = Convert.ToDouble(Console.ReadLine());
//string b = a.ToString();
//int[] c = new int[b.Length];
//for (int n = 0; n < b.Length; n++)
//{
//    c[n] = int.Parse(b[n].ToString());
//}
//if (c.Length < 3) Console.WriteLine("Третьей цифры в данном числе нет");
//
//else Console.WriteLine($"Третья цифра данного числа - {c[2]}");

int a = Convert.ToInt32(Console.ReadLine());

if (a < 100) Console.WriteLine("Третьей цифры в данном числе нет");
else 
{
    int b = 0;
    for (int i = 1; a/(100*i) >= 1 ; i = i*10)
    {
        b = (a/i)%10;
    }
    Console.WriteLine($"Третья цифра данного числа - {b}");
}