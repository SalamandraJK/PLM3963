// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


// // Добавляем метод принимающий данные от пользователя
// int ReadData(string line)
// {
//     // Вывод сообщения
//     Console.Write(line);
//     // Считываем данные от пользователя
//     int numberP = int.Parse(Console.ReadLine()??"0");
//     // Возвращаем полученное значение
//     return numberP;
// }

// Вводим метод, заполняющий массив (генерация)
int[] Gen1DArr(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
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

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод подсчёта суммы элементов массива на нечетных позициях
int OddSum(int[] arr)
{
    int res = 0;
    
    for(int i=1; i<arr.Length; i=i+2)
    {
       res = res + arr[i];
    }

    return res;
}

// // Присваеваем внасимое пользователем значение в введенную переменную.
// int LenArr = ReadData("Введите длинну массива: ");
// int minNum = ReadData("Введите минимальное значение элемента: ");
// int maxNum = ReadData("Введите максимальное значение элемента: ");

// // Вводим переменную testArr и прередаём в нее значение, получаемое в методе Gen1DArr
// int[] testArr = Gen1DArr(LenArr,minNum,maxNum);

int[] testArr = Gen1DArr(10, 1, 9);
Print1DArr(testArr);

int SumNum = OddSum(testArr);
PrintData("Сумма значений на нечётных позициях: ", + SumNum);