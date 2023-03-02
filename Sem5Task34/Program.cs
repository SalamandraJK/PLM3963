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

int[] testArr = Gen1DArr(10, 100, 999);
Print1DArr(testArr);

int result = EverNum(testArr);
PrintData("Колличество четных значений: ", result);