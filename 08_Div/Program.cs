//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите число");
int fistNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int a = 0;

if (fistNumber % secondNumber == 0)
{
    Console.WriteLine($"{fistNumber}, {secondNumber} -> кратно");

}

else
{
    a = fistNumber % secondNumber;
 Console.WriteLine($"{fistNumber}, {secondNumber} -> не кратно, остаток {a}");
}
