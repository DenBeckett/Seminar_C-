Console.WriteLine("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1*number1)
    Console.Write($"Число {number2} - квадрат {number1}!");
else {
    Console.WriteLine($"Число {number2} не является квадратом {number1}");
};