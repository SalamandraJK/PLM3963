// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string LineBuilder(int Num, int Pow)
{
    string result = String.Empty;
    for(int i = 1; i <= Num; i++)
    {
        result = result + Math.Pow(i, Pow)+"\t";
        // Console.WriteLine($"{Math.Pow(i,Pow)}\t");
    }

    return result;
}

int N = ReadInput("Введите число: ");

Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));


