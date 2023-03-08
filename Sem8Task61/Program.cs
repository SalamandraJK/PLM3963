// Задача №61
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//n!/k!*(n-k)! - формула для вычисления конкретного элемента треугольника

long Factroreal(int n)
{
    long res = 1;
    for(int i=1; i<=n; i++)
    {
        res = res*i;
    }
    return res;
}

void PrintPascalTriangle(int nRow)
{
    for(int i=0; i<nRow; i++)
    {
        for(int k=0; k<(nRow)-i; k++)
        {
            Console.Write(" ");
        }
        for(int j=0; j<i; j++)
        {
            Console.Write(" ");
            Console.Write(Factroreal(i)/(Factroreal(j)*Factroreal(i-j)));
        }
        Console.WriteLine();
    }
}


int countRow = ReadData("Введите колличество строк для треугольника Паскаля: ");
PrintPascalTriangle(countRow);