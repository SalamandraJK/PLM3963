// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int EverNum(int[] arr)
{
    int SumEven = 0;
    
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] % 2 == 1)
        {
            SumEven = SumEven +1;
        }
    }

    return (SumEven);
}

int[] testArr = Gen1DArr(12, 100, 999);
Print1DArr(testArr);

int result = EverNum(testArr);
PrintData("Колличество четных значений: ", result);