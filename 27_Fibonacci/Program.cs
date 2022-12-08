//Не используя рекурсию, выведите первые N чисел Фибоначчи.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"{string.Join(",",Fibonacci(n))}");

int[] Fibonacci(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i=1; i < n-1; i++)
    {
        array[i+1] = array[i] + array[i-1];
    }
    return array;
}