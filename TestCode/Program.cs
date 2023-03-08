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