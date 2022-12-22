//Напишите программу, которая выводит монотонную последовательность из N элементов
//в виде равностороннего треугольника с помощью рекурсии

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

GetSequence(1,n);

void GetSequence(int value1, int value2)
{
    if (value1 <= value2)
    {
        Console.WriteLine(((value1*(Math.Pow(10,value1) - 1))/9).ToString("# # # # # # # # #"));
        //Упрощенная формула работает только для одноразрядных чисел, т.е n<=9.
        GetSequence(value1 + 1,value2);
    }
}