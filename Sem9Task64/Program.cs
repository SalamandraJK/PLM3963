// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

// Метод, для приема данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void LineGenRec(int num, int Perm)
{
    Console.Write(Perm + " ");
    if(Perm >= num)
    {
    }
    else
    {
        LineGenRec(num, Perm + 1);
    }
}

int number = ReadData("Введите число N: ");
LineGenRec(number, 1);