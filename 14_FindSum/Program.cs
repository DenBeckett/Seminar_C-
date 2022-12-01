// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if(IsPossitiveNumber(number)){
    Console.WriteLine($"Сумма от 1 до числа {number} = {FindSumToLimit(number)}");
}
else{
    Console.WriteLine("Число отрицательное");
}

int FindSumToLimit(int limit)
{
    int sum = 0;

    for (int i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}

bool IsPossitiveNumber(int num){
    if(num > 0)
        return true;
    else
        return false;
}
