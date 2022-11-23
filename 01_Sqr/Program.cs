// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

Console.Clear();

Console.WriteLine("Введите число:");
    
string input = Console.ReadLine();
if(input == "")
{
    Console.Write("Ничего не было введено!");
}
else{
int num = Convert.ToInt32(input);

int sqr = num * num;

Console.WriteLine("Способ 1:");

Console.WriteLine("Квадрат числа " + num + " = " + sqr);

Console.WriteLine("Способ 2:");

Console.WriteLine($"Квадрат числа {num} = {Math.Pow(num,2)}");
}