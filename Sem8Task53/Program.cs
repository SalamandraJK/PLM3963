// Задача №53
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вводим метод, заполняющий массив (генерация)
int[,] Gen2DArr( int min, int max, int RowCount, int ColCount)
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
    int[,] binarray = new int[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
        
            binarray[i,j] = numSintezator.Next(min, max);
            
        }
    }
    return binarray;
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
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.ForegroundColor = color[new Random().Next(2,2)];
            Console.Write(arr[i,j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод для 
void Changr2DArr(int[,] matr)
{
    int temp = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        temp = matr[0,i];
        matr[0,i] = matr[matr.GetLength(0)-1, i];
        matr[matr.GetLength(0)-1, i] = temp;
    }
}

// Ввод параметров массива(строки с стлобцы)
int m = ReadData("Введите колличество строк: ");
int n = ReadData("Введите колличество столбцов: ");
// Генерация массива
int[,] arr2D = Gen2DArr(10, 99, m, n);
// Вывод(печать) массива
Console.WriteLine("Сгенерированный массив: ");
Print2DArr(arr2D);

Console.WriteLine(" ");
Console.WriteLine("Измененный массив: ");
Changr2DArr(arr2D);
Print2DArr(arr2D);
