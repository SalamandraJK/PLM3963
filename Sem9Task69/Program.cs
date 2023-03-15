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


// double RecPow(double n, double m)
// {
//     if(n == 0 && m == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         return Math.Pow(n, m);
//     }
// }

double RecPow(double n, double m)
{
    if(m<=1) return n;
    
    else return n*RecPow(n, m-1);
}

int N = ReadData("Введите число N: ");
int M = ReadData("Введите число M: ");
PrintData($"Возведение в сеперь M числа N = {RecPow(N, M)}");