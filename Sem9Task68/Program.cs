// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

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

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(0, 0)); // 1
Console.WriteLine(Akk(1, 2)); // 4
Console.WriteLine(Akk(2, 3)); // 9
Console.WriteLine(Akk(3, 4)); // 125
Console.WriteLine(" ");
int numN = ReadData("Введите число N: ");
int numM = ReadData("Введите число M: ");

PrintData(Akk(numN, numM));


Console.ReadKey();