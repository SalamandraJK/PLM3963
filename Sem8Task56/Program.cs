// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вводим метод, заполняющий массив (генерация)
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
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

// Вводин метод, который печатает одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for(int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

// Метод для посчета суммы значений в каждой строке
int[] ColMean2DArr(int[,] arr)
{
    int[] MeanArr = new int[arr.GetLength(0)];
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            MeanArr[i] = MeanArr[i] + arr[i,j];
        }
    }
    return MeanArr;
}

// Метод поиска минимального значения в одномерном массиве
int MinRow(int[] arr)
{
    int index = 0;
    int minNum = int.MaxValue;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]<minNum) 
        {
            minNum = arr[i];
            index = i;
        }
    }
    return index;
}

// Ввод параметров массива(строки с стлобцы)
int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");
// Генерация массива
int[,] arr2D = Gen2DArr(row, col, min, max);
// Вывод(печать) массива
Console.WriteLine("Сгенерированный массив: ");
Print2DArr(arr2D);
Console.WriteLine(" ");
// Вывод(печать) массива с результатом суммирования
Print1DArr(ColMean2DArr(arr2D));
Console.WriteLine(" ");
// Вывод результата
int MinCount = MinRow(ColMean2DArr(arr2D));
Console.WriteLine($"Строка с минимальной суммой элементов с индексом:" + MinCount);