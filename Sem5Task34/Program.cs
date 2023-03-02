// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

// Вводим метод посчета колличества четных значений в массиве
int EverNum(int[] arr)
{
    int SumEven = 0;
    
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            SumEven = SumEven +1;
        }
    }

    return (SumEven);
}

void BubbleSort(int[] arr)
{
int temp = 0;
Console.Write("[");
for (int write = 0; write < arr.Length; write++) {
    for (int sort = 0; sort < arr.Length - 1; sort++) {
        if (arr[sort] > arr[sort + 1]) {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");

Console.WriteLine("]");
}

Console.WriteLine(" ");
int[] testArr = Gen1DArr(10, 100, 999);
Print1DArr(testArr);
Console.WriteLine(" ");

int result = EverNum(testArr);
PrintData("Колличество четных значений: ", result);
Console.WriteLine(" ");

Console.WriteLine("Отсортированный методои Пузырька массив: ");
Console.WriteLine(" ");
BubbleSort(testArr);
