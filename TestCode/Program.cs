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

// int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
// {
//     int[,,] matrix = new int[row, col, dep];
//     Random rnd = new Random();   
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//                 {
//                     matrix[i,j,k] = rnd.Next(min, max + 1);
//                 }
//         }
//     }
//     return matrix;
// } 
 
// void Print3DMatrix(int[,,] matrix)
// {
//     for (int i = 0; i <  matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//             Console.Write("|");
//             Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); 
//             Console.WriteLine();           
//             }
//         }
//         Console.WriteLine();        
//     }        
// }
 
// int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
// Print3DMatrix(array3D);

            int N = 4, M = 4;
            int[,] A = new int[N, M];
 
 
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
 
 
            Console.ReadKey();