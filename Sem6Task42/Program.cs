// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, для печати принятых данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод конвектирующий входящее 10-ое число в 2-ое
string DecToBin(int num)
{
    string res = String.Empty;
    while ( num>0)
    {
        res = num%2 + res;
        num = num / 2;
    }
    return res;
}

int Num = ReadData("Введите десятичное число: ");

string NumII = DecToBin(Num);

PrintData($"В двоичной системе: {NumII}");