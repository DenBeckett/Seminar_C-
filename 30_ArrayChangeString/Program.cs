﻿//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
PrintArray(ChangeString(array));

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
            Console.Write(arr[i,j] >= 0 ? $"  {arr[i,j]}" : $" {arr[i,j]}");
        }
        Console.WriteLine();
    }
}

int[,] ChangeString(int[,] inputArray)
{
    int value = 0;
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
       value = inputArray[0,i];
       inputArray[0,i] = inputArray[inputArray.GetLength(0)-1,i];
       inputArray[inputArray.GetLength(0)-1,i] = value;

    }
    return inputArray;
}