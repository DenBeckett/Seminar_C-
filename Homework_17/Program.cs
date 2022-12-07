//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = FillArray(size, min, max);

PrintArray(array);

Console.WriteLine($"Разность между максимальным и минимальным элементов массива равна {GetDiffMaxMinValue(array)}");


double[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    double[] resultArray = new double[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void PrintArray(double[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{array[index]} ");
        index++;
    }
    Console.WriteLine();
}

double GetDiffMaxMinValue(double[] array)
{
    double MinValue = 0;
    double MaxValue = 0;
    double Diff = 0;
    for (int i=0; i < array.Length; i++)
        if (MinValue > array[i]) MinValue = array[i];
    for (int i=0; i < array.Length; i++)
        if (MaxValue < array[i]) MaxValue = array[i];
    Diff = MaxValue - MinValue;
    return Diff;

};