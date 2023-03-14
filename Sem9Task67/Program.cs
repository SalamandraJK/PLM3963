// 

// Чтение данных из консоли
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода результата
void PrintData(string msg)
{
    Console.WriteLine(msg);
}


int RecSumDigit(int num)
{
    if(num == 0)
    {
        return 0;
    }
    else
    {
        return num%10+RecSumDigit(num/10);
    }
}

int N = ReadData("Введите число N: ");
PrintData($"Сумма: {RecSumDigit(N)}");