Console.WriteLine("Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double L = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

Console.WriteLine(Math.Round(L,2,MidpointRounding.ToZero));