// Напишите программу, которая принимает от Пользователя M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл Пользователь.

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

int CountNum(int numM)
{
    int res = 0;
    for(int i = 0; i<numM; i++)
    {
        if(ReadData("Введите число: ")>0)
        {
            res++;
        }
    }
    return res;
}

int M = ReadData("Введите колличество чисел от 0 до М : ");
int Size = CountNum(M);
PrintData($"Колличество чисел > 0: {Size}");