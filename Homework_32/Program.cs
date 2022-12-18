//Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4,4];
int count = 1;
FillHelixArray(array,0,0);
PrintArray(array);

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

void FillHelixArray(int[,] array, int row, int column)
{
    if (array[row,column] == 0)
    {
        array[row,column] = count;
        count += 1;
        if (column < array.GetLength(1) - 1) FillHelixArray(array,row,column +1);
        if (row < array.GetLength(0) - 1) FillHelixArray(array,row + 1,column);
        if (column > 0) FillHelixArray(array,row,column - 1);
        if (row > 0) FillHelixArray(array,row - 1,column);
    }
}