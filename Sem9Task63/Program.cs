// Задача 63. Задайте значение N. 
// Нужно вывести все натуральные числа от 1 до N. Выполнить с помощью рекурсии.

// Метод, для приема данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод вывода результата
// void PrintData(string res, int value)
// {
//     Console.WriteLine(res + value);
// }


void LineGenRec(int num)
{
    Console.Write(num + " ");
    if(num == 1)
    {
    }
    else
    {
        LineGenRec(num - 1);
    }
}

int number = ReadData("Введите число N: ");
LineGenRec(number);