//Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива
// влево, или вправо на 1 позицию.

//[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
//[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size,min,max);

Console.WriteLine("Исходный массив: ");
PrintArray(array);

Console.WriteLine("Массив со сдвигом вправо: ");
PrintArray(GetRightShift(array));

Console.WriteLine("Массив со сдвигом влево: ");
PrintArray(GetLeftShift(array));


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

int[] GetRightShift(int [] array)
{
    int[] rightShiftArray = new int[array.Length];
    for(int i=1;i<array.Length ;i++) {
    rightShiftArray[i] = array[i-1];}
    rightShiftArray[0] = array[array.Length - 1];
    return rightShiftArray;
}

int[] GetLeftShift(int [] array)
{
    int[] leftShiftArray = new int[array.Length];
    for(int i=0;i<array.Length - 1;i++) {
    leftShiftArray[i] = array[i+1];}
    leftShiftArray[array.Length - 1] = array[0];
    return leftShiftArray;
}