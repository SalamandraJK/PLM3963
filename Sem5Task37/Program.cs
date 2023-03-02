// Найдите произведения пар чисел в одномерном массиве
// Пара - первое и последние, второе и предпоследнее.

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
// // Вводин метод, который печатает результат
// void PrintData(string lain, int num)
// {
//     Console.WriteLine(lain + num);
// }

int[] ConvertArr(int[] arr)
{
    int Len = arr.Length / 2;

    if(arr.Length % 2 == 1)
    {
        Len = Len +1;
    }

    int[] bufArr = new int[Len];

    for( int i=0; i<Len; i++) 
    {
        bufArr[i] = arr[i]*arr[Len -1 - i];
    }

return bufArr;
}


int[] testArr = Gen1DArr(7, -100, 100);
Console.WriteLine(" ");
Print1DArr(testArr);
Console.WriteLine(" ");
Print1DArr(ConvertArr(testArr));
Console.WriteLine(" ");