//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Console.Write("Среднее арифметическое столбцов массива - ");
PrintArray(GetColumnsAverage(array));

double[] GetColumnsAverage(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    for (int j=0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i=0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        resultArray[j] = Math.Round(sum/(array.GetLength(0)),1,MidpointRounding.ToZero);
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