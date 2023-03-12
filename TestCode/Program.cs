// // Метод, для приема данных
// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Вводим метод, заполняющий массив (генерация)
// int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
// {
//     // Проверка входных данных массива
//     if(min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }

//     Random rnd = new Random();
//     int[,] arr = new int[countRow,countColumn];

//     // 2 цикла для прохлждения по строкам и столбцам
//     for(int i=0; i<countRow; i++)
//     {
//         for(int j=0; j<countColumn; j++)
//         {
//         arr[i,j] = rnd.Next(min, max + 1);
//         }
//     }
//     return arr;
// }

// // Вводин метод, который печатает одномерный массив
// void Print2DArr(int[,] arr)
// {
//     // Вводим массив содержащий различные цвета
//     ConsoleColor[] color = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, 
//                                             ConsoleColor.Cyan, ConsoleColor.DarkBlue, 
//                                             ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
//                                             ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
//                                             ConsoleColor.DarkRed, ConsoleColor.DarkYellow,
//                                             ConsoleColor.Gray, ConsoleColor.Green,  
//                                             ConsoleColor.Magenta, ConsoleColor.Red, 
//                                             ConsoleColor.White, ConsoleColor.Yellow};
//     // Console.Write("[");
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = color[new Random().Next(0,16)];
//             Console.Write(arr[i,j] + " ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// void SortMatrix(int[,] arr)
// {
//     int[,] b = new int[,]; //массив для сортировки по строкам

//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     a[i, j] = ran.Next(-1, 5);
//                     b[i, j] = a[i, j];
//                     c[i, j] = a[i, j];
//                     Console.Write("{0}\t", a[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//             int[] temp = new int[n];
 
//             Console.WriteLine("\nСортировка по строкам: ");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                     temp[j] = b[i, j];
//                 Array.Sort(temp);
//                 for (int k = 0; k < n; k++)
//                 {
//                     b[i, k] = temp[k];
//                     Console.Write("{0}\t", b[i, k]);
//                 }
//                 Console.WriteLine();
//             }
// }
using System;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
 
            Console.WriteLine("\nМатрица A:");
            Print(A);
            Console.WriteLine("\nМатрица B:");
            Print(B);
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Multiplication(A, B);
            Print(C);
 
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
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
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}