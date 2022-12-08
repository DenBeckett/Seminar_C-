//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size,min,max);

Console.WriteLine($"Исходный массив: {string.Join(",",array)}");
Console.WriteLine($"Результатирующий массив: {string.Join(",",CopyArray(array))}");

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

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
      copy[i] = array[i];
    }
    return copy;
}