//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[3,2]
{
    {2,1},
    {-3,0},
    {4,-1}
};
int[,] matrix2 = new int[2,3]
{
    {5,-1,6},
    {-3,0,7}
};

if (matrix1.GetLength(1)!= matrix2.GetLength(0)) Console.WriteLine("Заданные матрицы перемножить нельзя!");
else PrintArray(GetMatrixProduct(matrix1,matrix2));

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] >= 0 ? $"  {inputArray[i,j]}" : $" {inputArray[i,j]}");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j]; 
            }
        } 
    }
    return resultMatrix;
}