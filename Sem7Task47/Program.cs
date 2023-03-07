// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// // Метод, для печати принятых данных
// void PrintData(int msg)
// {
//     Console.WriteLine(msg);
// }

// Вводим метод, заполняющий массив (генерация)
double[,] Gen2DArr( int min, int max, int RowCount, int ColCount)
{
    // Проверка входных данных массива
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    // Генерация двумерного массива
    double[,] array = new double[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
            array[i,j] = numSintezator.Next(min, max) + numSintezator.NextDouble();
        }
    }
    return array;
}


// Вводин метод, который печатает одномерный массив
void Print2DArr(double[,] arr)
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
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.ForegroundColor = color[new Random().Next(0,16)];
            Console.Write($"{arr[i,j]} + ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Ввод параметров массива(строки с стлобцы)
int Row = ReadData("Введите колличество строк: ");
int Column = ReadData("Введите колличество столбцов: ");
// Генерация массива
double[,] arr2D = Gen2DArr(1, 10,Row, Column);
// Вывод(печать) массива
Print2DArr(arr2D);
Console.WriteLine(" ");