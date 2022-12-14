//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
PrintArray(ChangeValuestoSqrs(array));

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

int[,] ChangeValuestoSqrs(int[,] inputArray)
{
    int[,] resultArray = new int[inputArray.GetLength(0),inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) resultArray[i,j] = inputArray[i,j]*inputArray[i,j];
            else resultArray[i,j] = inputArray[i,j];
        }
    }
    return resultArray;
}