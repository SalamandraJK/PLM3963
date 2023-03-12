// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генирации и заполнения массива по спирали
int[,] SpiralArr (int x, int y)
{
    int[,] A = new int[x, y];
int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = y;
for (int i = 0; i < A.Length; i++)
{
    A[col, row] = i + 1;
    if (--gran == 0)
        {
            gran = x * (dirChanges % 2) + y * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
    col += dx;
    row += dy;
}
return A;
}

// Метод печати массива
void PrintSpiralArr(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
    Console.WriteLine();
    }
}

// Ввод параметров массива(строки с стлобцы)
int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
Console.WriteLine(" ");
if(col == row)
{
int[,] SpArr = SpiralArr(col, row);
Console.WriteLine("Сгенерированный массив: ");
PrintSpiralArr(SpArr);
}
else
{
    Console.WriteLine("Массив не может быть сгенерирован");
}