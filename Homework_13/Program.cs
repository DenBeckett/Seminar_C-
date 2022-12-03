//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

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

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(a));