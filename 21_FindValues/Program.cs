//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное значение отрезка");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное значение отрезка");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);

Console.WriteLine($"Получившийся массив: [{string.Join(",", array)}]");
Console.WriteLine($"Количество элементов массива, лежащих в заданном отрезке: {FindCount(FillArray(size,min,max),minValue,maxValue)}");

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
int FindCount(int[] array, int minValue, int maxValue)
{
    int count = 0;
    int i = 0;
    for(i=0;i < array.Length;i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue) count += 1;
    }
    return count;
}