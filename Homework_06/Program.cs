//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num < 100) Console.WriteLine("Третьей цифры нет");
//else
//{
//    int num1 = num / 100;
//    int num2 = num1 % 10;
//
//    Console.WriteLine($"{num2}");
//}

Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
string b = a.ToString();
int[] c = new int[b.Length];
for (int n = 0; n < b.Length; n++)
{
    c[n] = int.Parse(b[n].ToString());
}
if (c.Length < 3) Console.WriteLine("Третьей цифры в данном числе нет");

else Console.WriteLine($"Третья цифра данного числа - {c[2]}");