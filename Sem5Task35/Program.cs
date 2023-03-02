// Задача №35
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

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
// Вводин метод, который печатает результат
void PrintData(string lain, int num)
{
    Console.WriteLine(lain + num);
}

// Вводин метод, который находит элементы массива в промежутке
int NumElemInRang(int[] arr, int minValue, int maxValue )
{
int res = 0;
for(int i=0; i<arr.Length; i++)
{
    if((arr[i]>minValue)&&(arr[i]<maxValue))
    {
        res ++;
    }
}
return res;
}

int[] testArr = Gen1DArr(123, -100, 100);
Console.WriteLine(" ");
Print1DArr(testArr);
Console.WriteLine(" ");
PrintData("Колличество элементов находящихся в промежутке: ", NumElemInRang(testArr, 10, 99));
