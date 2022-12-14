//Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Console.WriteLine("Введите номер строки двумерного массива");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца двумерного массива");
int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckArray(array,i,j) ? $"Значение заданного элемента массива равно {ReturnValue(array,i,j)}" : "Такого элемента в массиве не существует");

int ReturnValue(int[,] array, int row, int column)
{
    int value = array[row,column];
    return value;
}

bool CheckArray(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) -1 && column <= array.GetLength(1) -1)
    return true;
    else return false;
}