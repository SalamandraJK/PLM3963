// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерации Трехмерного массива
int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i,j,k] = rnd.Next(min, max + 1);
                }
        }
    }
    return matrix;
} 
 
// Метод печати Трехмерного массива
void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write("|");
            Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); 
            Console.WriteLine();           
            }
        }
        Console.WriteLine();        
    }        
}
 
// Ввод параметров массива(строки с стлобцы)
int length = ReadData("Введите значение длинны: ");
int width = ReadData("Введите значение ширины: ");
int height = ReadData("Введите значение высоты: ");
int min = ReadData("Введите минимальное значение элемента: ");
int max = ReadData("Введите максимальное значение элемента: ");
// Генерация и печать массива
int[,,] array3D = CreateMatrix(length, width, height, min, max);
Print3DMatrix(array3D);