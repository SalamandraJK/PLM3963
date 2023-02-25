// Задача 29:
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// Ввести с клавиатуры длину массива и диапазон значений элементов.

// Добавляем метод принимающий данные от пользователя
int ReadData(string line)
{
    // Вывод сообщения
    Console.Write(line);
    // Считываем данные от пользователя
    int numberP = int.Parse(Console.ReadLine()??"0");
    // Возвращаем полученное значение
    return numberP;
}

// // Вводим метод вывода получаемого результата
// void PrintData(string line)
// {
//     Console.WriteLine(line);
// }


int[] Gen1DArr(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}  //prints 1D array into consle
void Print1DArr(int[] arr)
{
    Console.Write("[");
     for (int i = 0; i < arr.Length - 1; i++) 
     Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

// Присваеваем внасимое пользователем значение в введенную переменную numberA.
int LenArr = ReadData("Введите длинну массива: ");
int minNum = ReadData("Введите минимальное значение элемента: ");
int maxNum = ReadData("Введите максимальное значение элемента: ");

// Вводим переменную resSubtrac и прередаём в нее значение, получаемое в методе Subtraction
int[] resSubtrac = Gen1DArr(LenArr,minNum,maxNum);


Print1DArr(Gen1DArr(LenArr, minNum, maxNum));
