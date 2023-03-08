// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// Метод сортировки пузырьком
void BubbleSort(int[,] arr)
{
int temp = 0;
int row = 0;
while ( row < arr.GetLength(0)) 
{
    for(int col = 0; col <arr.GetLength(1)-1; col++) 
    {
        if (arr[row,col] > arr[row,col + 1]) 
        {
            temp = arr[row,col + 1];
            arr[row,col + 1] = arr[row,col];
            arr[row,col] = temp;
        }
    }
     row++;
}

    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Ввод параметров массива(строки с стлобцы)
int Row = ReadData("Введите колличество строк: ");
int Column = ReadData("Введите колличество столбцов: ");
// Генерация массива
int[,] arr2D = Gen2DArr(Row, Column, 1, 9);
// Вывод(печать) массива
Print2DArr(arr2D);
Console.WriteLine(" "); 

Console.WriteLine("Отсортированный методои Пузырька массив: ");
Console.WriteLine(" ");
BubbleSort(arr2D);
// Print2DArr(arr2D);