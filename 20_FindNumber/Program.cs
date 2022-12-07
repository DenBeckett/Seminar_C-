//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(a);
Console.Write($"Число {num} присутствует в массиве?");
Console.WriteLine(FindNumber(arr,num) ? " да" : " нет");

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

bool FindNumber(int[] array, int num)
{
    for (int i = 0;i < array.Length;i++)
    {
        if (array[i] == num) return true;
        //else return false;
    }
    return false;
}
