// 

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
