//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

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
DeleteRowAndColumn(array,GetMinValueIndex(array).Item1,GetMinValueIndex(array).Item2);



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
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

(int,int) GetMinValueIndex(int[,] inputArray){
    
    int min = inputArray[0,0];
    int minRow = 0;
    int minColumn = 0;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i,j] < min)
            {
                min = inputArray[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow,minColumn);
}

void DeleteRowAndColumn(int[,] inputArray, int minRow, int minColumn)
{
    for (int i = 0; (i < inputArray.GetLength(0)); i++)
    {
        if (i == minRow) continue;
        for (int j = 0; (j < inputArray.GetLength(1)); j++)
        {
            if (j == minColumn) continue;
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}