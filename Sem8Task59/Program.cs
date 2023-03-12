// 

// Метод удаления нужных строки и столбца
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

// Метод нахождения минимального значения в сгенерированном массиве
(int x, int y) SearchMinElementIn2Darr(int[,] martrizza)
{
    int row = 0;
    int collumn = 0;
    int minimum = int.MaxValue;
    for (int i = 0; i < martrizza.GetLength(0); i++)
    {
        for (int j = 0; j < martrizza.GetLength(1); j++)
        {
            minimum = martrizza[i,j];
            row = i;
            collumn = j;
        }
    }
    return (row, collumn);
}

// Метод удаления нужных строки и столбца
int[,] Update2Darr(int[,] arr, int x, int y)
{
    int[,] result = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int k = 0; 
    int m = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(j!=x && i!=y)
            {
                result[k,m] = arr[i,j];
            }
            if(j!=y) m++;
        }
        if(i!=x) k++;
    }
    return result;
}

// Ввод параметров массива(строки с стлобцы)
int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");
// Генерация массива
int[,] arr2D = Gen2DArr(min, max, row, col);
// Вывод(печать) массива
Console.WriteLine("Сгенерированный массив: ");
Print2DArr(arr2D);

// Вывод полученного массива после выполнения задачи
Console.WriteLine(" ");
(int x, int y) minElem = SearchMinElementIn2Darr(arr2D);
int[,] out2Darr = Update2Darr(arr2D, minElem.x, minElem.y);
Print2DArr(out2Darr);