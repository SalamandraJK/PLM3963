// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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

// Метод, переварачивающий заданный массив
void SwapArray(int[] arr)
{
    int BufElem = 0;
    for( int i = 0; i < arr.Length/2; i++)
    {
        BufElem = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = BufElem;
    }
}

// Метод, переварачивающий заданный массив
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }

    return outArr;
}

int[] testArray = Gen1DArr(20, 10, 100);
Print1DArr(testArray);
Console.WriteLine(" ");

int[] newArray = SwapNewArray(testArray);
Print1DArr(testArray);
Console.WriteLine(" ");
Print1DArr(newArray);
Console.WriteLine(" ");
