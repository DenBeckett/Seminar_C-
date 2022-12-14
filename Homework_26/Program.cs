//Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов
// расположенных в четырех "углах" двумерного массива.

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Console.WriteLine(CompareSums(GetColumnsSum(array),GetAnglesSum(array)) ? "Да" : "Нет");

int[] GetColumnsSum(int[,] array)
{
    int[] resultArray = new int[array.GetLength(1)];
    for (int j=0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i=0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        resultArray[j] = sum;
    }
    return resultArray;
}

int GetAnglesSum(int[,] array)
{
    int sum = array[0,0] + array[array.GetLength(0) -1,0] + array[0,array.GetLength(1) -1] + array[array.GetLength(0) -1,array.GetLength(1) -1];
    return sum;
}

bool CompareSums(int[] array, int sum)
{
    bool col = false;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > sum) col = true;
    }
    return col;
}