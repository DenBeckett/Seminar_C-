// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

int num = new Random().Next(10, 100);

int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine($"Число {num}"); 

if(num1 == num2)
    Console.WriteLine("Цифры равны");  

Console.WriteLine(num1 > num2 ? $"Максимальная цифра в числе: {num1}" : $"Максимальная цифра в числе: {num2}");
// else if(num1 > num2)
//     Console.WriteLine($"Максимальная цифра в числе: {num1}");
// else
//    Console.WriteLine($"Максимальная цифра в числе: {num2}");
