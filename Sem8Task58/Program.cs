// Задача 58: 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вводим метод, заполняющий массив (генерация)
int[,] FirstGen2DArr(int countRow, int countColumn, int min, int max)
{
    // Проверка входных данных массива
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[,] arr = new int[countRow,countColumn];

    // 2 цикла для прохлждения по строкам и столбцам
    for(int i=0; i<countRow; i++)
    {
        for(int j=0; j<countColumn; j++)
        {
        arr[i,j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

// Вводим метод, заполняющий массив (генерация)
int[,] SecondGen2DArr(int countRow, int countColumn, int min, int max)
{
    // Проверка входных данных массива
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[,] arr = new int[countRow,countColumn];

    // 2 цикла для прохлждения по строкам и столбцам
    for(int i=0; i<countRow; i++)
    {
        for(int j=0; j<countColumn; j++)
        {
        arr[i,j] = rnd.Next(min, max + 1);
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
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.ForegroundColor = color[new Random().Next(2,2)];
            Console.Write(arr[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] a, int[,] b)
    {
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i,j] += a[i,k] * b[k,j];
                }
            }
        }
        return r;
}

// Ввод параметров массива(строки с стлобцы)
int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");
// Генерация массива
int[,] FirsArr2D = FirstGen2DArr(row, col, min, max);
int[,] SecArr2D = SecondGen2DArr(row, col, min, max);
// Вывод(печать) массива
Console.WriteLine("Сгенерированный первый массив: ");
Print2DArr(FirsArr2D);
Console.WriteLine(" ");
Console.WriteLine("Сгенерированный второй массив: ");
Print2DArr(SecArr2D);
Console.WriteLine(" ");
Console.WriteLine("Произведение двух введенных матриц: ");
int[,] MultiArr = Multiplication(FirsArr2D, SecArr2D);
Print2DArr(MultiArr);