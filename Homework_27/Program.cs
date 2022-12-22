//Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника.

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
GetTriangle(n);

int[] GetTriangle(int n)
{
    int[] row = new int[1];
    int[] rowPrev = new int[1];
    for (int i = 0; i < n; i++)
    {
        PrintIndent(i,n);
        row = new int[i + 1];
        for (int j = 0; j < row.Length; j++)
        {
            if (j == 0 || j == row.Length - 1) row[j] = 1;
            else
            {
                row[j] = rowPrev[j] + rowPrev[j - 1];
            }
        }
        Console.WriteLine(string.Join(" ", row));
        rowPrev = row;
    }
    return row;
}

void PrintIndent(int start, int end)
{
    while (start < end)
    {
        Console.Write(" ");
        start++;
    }
}