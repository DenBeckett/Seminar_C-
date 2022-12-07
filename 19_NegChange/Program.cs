//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] FillArray(int number)
{
    int[] numbers = new int[number];
    int index = 0;
    while (index < number)
    {
        Console.WriteLine($"Введите элемент массива №{index}");
        numbers[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    return numbers;
}

int[] NegChange(int[] array)
{
    int[] negarray = new int[array.Length];
    int i = 0;
    for(i=0;i < array.Length;i++)
        negarray[i]= -1*array[i];
    return negarray;
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

Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);
Console.WriteLine($"Исходный массив ");
PrintArray(arr);
Console.WriteLine($"Измененный массив ");
PrintArray(NegChange(arr));