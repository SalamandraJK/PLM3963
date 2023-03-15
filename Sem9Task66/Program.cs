// Задайте значения M и N. Напишите программу,  
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Метод, для приема данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод вывода результата
void PrintData(int value)
{
    Console.WriteLine(value);
}


int RecSum(int M, int N)
{
    if(M >= N)
    {
        return N;
    }
    else
    {
        RecSum(M + 1, N);
    }
    return M + RecSum(M + 1, N);
}

int numN = ReadData("Введите число N: ");
int numM = ReadData("Введите число M: ");
PrintData(RecSum(numM, numN));
