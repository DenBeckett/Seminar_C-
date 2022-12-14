//Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными
//значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат
//сравнения средних арифметических.

//[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
//[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
//[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size,min,max);

PrintArray(array);
//GetEvenOddArray(array);
PrintArray(GetEvenArray(array));
PrintArray(GetOddArray(array));
//Console.WriteLine($"{string.Join(",",GetEvenOddArray(array).Item1)}");
//Console.WriteLine($"{string.Join(",",GetEvenOddArray(array).Item2)}");

if (GetArrayAverage(GetEvenArray(array)) > GetArrayAverage(GetOddArray(array))) 
Console.WriteLine("средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами");
else if (GetArrayAverage(GetEvenArray(array)) < GetArrayAverage(GetOddArray(array))) 
Console.WriteLine("средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами");
else Console.WriteLine("средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами");




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

//(int[],int[]) GetEvenOddArray(int[] array)
//{
//    int count = 0;
//    for (int n=0; n < array.Length; n++)
//    {
//        if (array[n]%2 == 0) count++;
//    }
//
//    int[] EvenArray1 = new int[count];
//    int[] OddArray1 = new int[array.Length - count];
//
//    int j = 0;
//    int k = 0;
//    for (int i=0; i < array.Length; i++)
//    {
//        if (array[i]%2 == 0) 
//        {
//            EvenArray1[j]=array[i];
//            j++;
//        }
//        else
//        {
//            OddArray1[k]=array[i];
//            k++;
//        }
//    }
//    return (EvenArray1,OddArray1);
//};

int[] GetEvenArray(int[] array)
{
    int count = 0;
    for (int n=0; n < array.Length; n++)
    {
        if (array[n]%2 == 0) count++;
    }
    int[] EvenArray = new int[count];
    int j = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) 
        {
            EvenArray[j]=array[i];
            j++;
        }
    }
    return EvenArray;    
}

int[] GetOddArray(int[] array)
{
    int count = 0;
    for (int n=0; n < array.Length; n++)
    {
        if (array[n]%2 == 1) count++;
    }
    int[] OddArray = new int[count];
    int j = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]%2 == 1) 
        {
            OddArray[j]=array[i];
            j++;
        }
    }
    return OddArray;    
}

int GetArrayAverage(int[] array)
{
    int Average = 0;
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
        sum += array[i];
    }
    Average = sum/array.Length;
    return Average;
}