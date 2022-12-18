//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = FillArray(x,y,z);
PrintArray(array);

int[,,] FillArray(int x, int y, int z)
{
    int[,,] filledArray = new int[x,y,z];
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                filledArray[i,j,k] = random.Next(10, 100);
            }
        }
    }
    return filledArray;
}

void PrintArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
                {
                    Console.Write($" {inputArray[i,j,k]}{(i,j,k)}");
                }
                Console.WriteLine();
        }
    }
}