// // Задача №51
// // Задайте двумерный массив. Найдите сумму элементов, 
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, для печати принятых данных
void PrintData(int msg)
{
    Console.WriteLine(msg);
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
            Console.ForegroundColor = color[new Random().Next(0,16)];
            Console.Write(arr[i,j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод для посчета суммы значений на главное диагонали сгенерированного массива
int CountMainDiag(int[,] arr)
{
    int result = 0;
    // Вводим проверку на соотношение строк и столбйов в сгенерированном массиве
    // Выбираем максимальный размер массива с одинаковым соотношением строк и столбцов
    int min = arr.GetLength(0);
    if(arr.GetLength(0)>arr.GetLength(1)) min = arr.GetLength(1);

    for(int j=0; j<min; j++)
    {
        result = result + arr[j,j];
    }
    return result;
}

// Ввод параметров массива(строки с стлобцы)
int Row = ReadData("Введите колличество строк: ");
int Column = ReadData("Введите колличество столбцов: ");
// Генерация массива
int[,] arr2D = Gen2DArr(10, 99,Row, Column);
// Вывод(печать) массива
Print2DArr(arr2D);
Console.WriteLine(" ");
// Вывод полученного результата
Console.Write("Сумма значений на главное диагонали = ");
PrintData(CountMainDiag(arr2D));