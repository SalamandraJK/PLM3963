// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет

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

// // Вводим метод для ответа на вопрос задачи
// bool SearchEleme(int[,] arr, int r, int c)
// {
//     if(arr.GetLength(0)>r && arr.GetLength(1)>c)
//     {
//         Console.WriteLine(arr[r,c]);
//     }
//     else
//     {
//         Console.WriteLine("Элемент не найден");    
//     }
// }

// // Ввод параметров массива(строки с стлобцы)
// int Row = ReadData("Введите колличество строк: ");
// int Column = ReadData("Введите колличество столбцов: ");
// // Генерация массива
// int[,] arr2D = Gen2DArr(Row, Column, 10, 99);
// // Вывод(печать) массива
// // Вывод(печать) массива
// Print2DArr(arr2D);
// Console.WriteLine(" "); 

// // Ввод параметров элемента
// int R = ReadData("Введите номер строки: ");
// int C = ReadData("Введите номер столбца: ");

// // Условия для вывода полученного результата
// if(SearchEleme(arr2D, R, C))
// {
//     Console.WriteLine(arr2D[R,C]);
// }
// else
// {
//     Console.WriteLine("Такой элемент не найден.");
// }
