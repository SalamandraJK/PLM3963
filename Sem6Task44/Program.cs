// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Метод, для приема данных
long ReadData(string message)
{
    Console.Write(message);
    return long.Parse(Console.ReadLine() ?? "0");
}

// Метод, для печати принятых данных
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }

// Метод записи Чисел фибаначи

string FibonNum(long num)
{
    string res = "0 1";
    long first = 0; long last = 1;
    for (long i = 2; i < num; i++)
    {
        res = res + " " + (first + last).ToString();
        (first, last) = (last, first + last);
    }
    return res;
}

long num = ReadData("Введите номер числа Фибаначи: ");
Console.WriteLine(FibonNum(num));