// 

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода результата
void PrintData(string msg)
{
    Console.WriteLine(msg);
}


string RecMiNi(int m, int n)
{
    string res = String.Empty;
    if(m>=n)
    {
        res = res + n;
    }
    else
    {
        res = res + m + " " + RecMiNi(m+1,n);
    }
    return res;
}

int N = ReadData("Введите число N: ");
int M = ReadData("Введите число M: ");

string result = N<M?RecMiNi(N, M):RecMiNi(M,N);

PrintData(result);