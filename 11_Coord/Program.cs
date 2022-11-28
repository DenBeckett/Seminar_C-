Console.Write("Введите X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y:");
int y = Convert.ToInt32(Console.ReadLine());

bool isPossible = IsPossibleGetQuarter(x,y);

if(isPossible){
    Console.WriteLine(GetQuarterByCoordinates(x,y));
}
else{
    Console.WriteLine("Не соответствует условию");
}


int GetQuarterByCoordinates(int coordX, int coordY)
{
    if (coordX > 0 && coordY > 0)
    {
        return 1;
    }
    else if (coordX < 0 && coordY > 0)
    {
        return 2;
    }
    else if (coordX < 0 && coordY < 0)
    {
        return 3;
    }
    else
    {
        return 4;
    }
}

bool IsPossibleGetQuarter(int coordX, int coordY){
    if (coordX == 0 || coordY == 0)
    {
        return false;
    }
    else
        return true;
}