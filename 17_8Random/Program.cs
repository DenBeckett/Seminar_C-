//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]


Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int number)
{
    int[] numbers = new int[number];
    int index = 0;
    while (index < number)
    {
        numbers[index] = new Random().Next(0, 2);
        index++;
    }
    return numbers;
}

Console.WriteLine(String.Join(" ", FillArray(number)));