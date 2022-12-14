//Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить
//существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникальное значение.

//[1,2,3,3] -> [1,2,3,4]

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size,min,max);

Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("Проверенный на уникальность массив: ");
PrintArray(GetInique(array));



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

int[] GetInique(int[] array)
{
    int[] resultArray = new int[array.Length];
    Random random = new Random();
    int previousValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == previousValue)
            resultArray[i] = GetUniqueValue(array[i], min, max);
        previousValue = resultArray[i];
    }
    return resultArray;
}

int GetUniqueValue(int currentValue, int min, int max)
{
    int uniqueVal = new Random().Next(min, max + 1);

    if (currentValue == uniqueVal)
        return GetUniqueValue(currentValue, min, max);
    else
        return uniqueVal;
}