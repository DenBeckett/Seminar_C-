//Напишите программу, которая будет преобразовывать десятичное число в двоичное

Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {n} => ");
Console.WriteLine(ValueToBinary(n));

string ValueToBinary(int a){
    string s = "";
    while (a > 0)
    {
        if (a % 2 == 0) s = "0" + s;
        else s = "1" + s; 
        a = a / 2;
    }
    return s;
}