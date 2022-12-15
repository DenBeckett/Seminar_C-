//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

for (int n = 0; n < max; n++)
{
    if (GetCountValues(array,max + 1)[n] == 0) continue;
    Console.WriteLine($"Число {n} встречается {GetCountValues(array,max + 1)[n]} раз");
}


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

int[] GetCountValues(int[,] inputArray, int max)
{
    int[] resultArray = new int[max];
    
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++) 
        {
            resultArray[inputArray[i,j]] += 1;
        }
    }
    return resultArray;
}