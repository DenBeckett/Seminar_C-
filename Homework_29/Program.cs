//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());


int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Наименьшей суммой элементов ({GetMinSumRow(array).Item2}) обладает строка №{GetMinSumRow(array).Item1}");


int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] >= 0 ? $"  {inputArray[i,j]}" : $" {inputArray[i,j]}");
        }
        Console.WriteLine();
    }
}

(int,int) GetMinSumRow(int[,] inputArray)
{
    int min = 999999;
    int row = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++) 
        {
            sum += inputArray[i,j];
        }
        if (sum < min) 
            {
                min = sum;
                row = i;
            }
    }
    return (row,min);
}