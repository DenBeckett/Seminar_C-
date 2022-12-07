//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] Array = FillArray(sizeArray,100,999);

PrintArray(Array);

Console.WriteLine($"Количество четных чисел в массиве - {GetCountPositiveNumbers(Array)}");

int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void PrintArray(int[] array)
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

int GetCountPositiveNumbers(int[] Array)
{
    int Count = 0;
    for (int i = 0; i < Array.Length; i++)
    if (Array[i]%2 == 0) Count++;
    return Count;
};