// Задача, показать возможный диапозон координат точек,
// в заданной плоскости

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintAnswer(int num)
{
    if(num < 5 && num >0) 
    {
        if(num == 1)Console.WriteLine("Диапозон: X > 0, Y>0");
        if(num == 2)Console.WriteLine("Диапозон: X < 0, Y>0");
        if(num == 3)Console.WriteLine("Диапозон: X < 0, Y<0");
        if(num == 4)Console.WriteLine("Диапозон: X > 0, Y<0");
    }
    else{
        Console.WriteLine("Введён неверный номер четверти");
    }
}

int quarter = ReadData("Введите номер четверти:");
PrintAnswer(quarter);