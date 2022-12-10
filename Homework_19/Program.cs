//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(M);

Console.WriteLine($"Количество чисел, больших нуля равно {GetCountPositiveNumbers(arr)}");

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

int GetCountPositiveNumbers(int[] Array)
{
    int Count = 0;
    for (int i = 0; i < Array.Length; i++)
    if (Array[i] > 0) Count++;
    return Count;
};