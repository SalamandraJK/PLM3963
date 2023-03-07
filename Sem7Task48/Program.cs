// See https://aka.ms/new-console-template for more information


// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, для печати принятых данных
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }


// Вводим метод, заполняющий массив (генерация) (с модификацией под задачу)
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Проверка входных данных массива
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    // Random rnd = new Random();
    int[,] arr = new int[countRow,countColumn];

    // 2 цикла для прохлждения по строкам и столбцам
    for(int i=0; i<countRow; i++)
    {
        for(int j=0; j<countColumn; j++)
        {
        arr[i,j] = i + j;
        }
    }
    return arr;
}

// Вводин метод, который печатает одномерный массив
void Print2DArr(int[,] arr)
{
    // Вводим массив содержащий различные цвета
    ConsoleColor[] color = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, 
                                            ConsoleColor.Cyan, ConsoleColor.DarkBlue, 
                                            ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                            ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                                            ConsoleColor.DarkRed, ConsoleColor.DarkYellow,
                                            ConsoleColor.Gray, ConsoleColor.Green,  
                                            ConsoleColor.Magenta, ConsoleColor.Red, 
                                            ConsoleColor.White, ConsoleColor.Yellow};
    // Console.Write("[");
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(0); j++)
        {
            Console.ForegroundColor = color[new Random().Next(1,1)];
            Console.Write(arr[i,j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


// Ввод параметров массива(строки с стлобцы)
int Row = ReadData("Введите колличество строк: ");
int Column = ReadData("Введите колличество столбцов: ");
// int numMin = ReadData("Введите значение Min: ");
// int numMax = ReadData("Введите значение Max: ");
// Генерация массива
int[,] arr2D = Gen2DArr(Row, Column, 10, 99);
// Вывод(печать) массива
Print2DArr(arr2D);
