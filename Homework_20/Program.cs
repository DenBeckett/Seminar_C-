//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Точка пересечения прямых имеет координаты {FindCoord(k1,b1,k2,b2)}");


(double,double) FindCoord(double k1, double b1, double k2, double b2)
{
        // k1*x+b1=k2*x+b2, (k1-k2)*x=b2-b1, x=(b2-b1)/(k1-k2)
        double x = (b2-b1)/(k1-k2); //<censored>!!! если аргументы деления int, результат тоже округляется до int.
        // y=k2*x+b2
        double y = k2*x+b2;
        return (x,y);
}