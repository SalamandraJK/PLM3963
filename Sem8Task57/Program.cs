// Задача №57
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// // Метод, для приема данных
// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Вводим метод, заполняющий массив (генерация)
// int[,] Gen2DArr( int min, int max, int RowCount, int ColCount)
// {
//     // Проверка входных данных массива
//     int buf;
//     if (min > max)
//     {
//         buf = min;
//         min = max;
//         max = buf;
//     }
//     // Генерация двумерного массива
//     int[,] binarray = new int[RowCount, ColCount];
//     System.Random numSintezator = new System.Random();
//     for (int i = 0; i < RowCount; i++)
//     {
//         for (int j = 0; j < ColCount; j++)
//         {
        
//             binarray[i,j] = numSintezator.Next(min, max);
            
//         }
//     }
//     return binarray;
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
//             Console.ForegroundColor = color[new Random().Next(2,2)];
//             Console.Write(arr[i,j] + "\t");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

