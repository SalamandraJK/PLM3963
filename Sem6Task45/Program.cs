// Напишите программу, которая будет создавать копию заданного одномерного массива
// с помощью поэлементного копирования.

// Метод, для приема данных
// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Метод, для печати принятых данных
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
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

// Метод, копирущий заданный массив
int[] CopyArray(int [] inputArray)
{
    int[] outArr = new int[inputArray.Length];
    inputArray.CopyTo(outArr,0);
    return outArr;
}

int[] testArr = Gen1DArr(40,1,50);
Print1DArr(testArr);

int[] testArrNew = CopyArray(testArr);
Print1DArr(testArrNew);