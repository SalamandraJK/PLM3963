// Задача №32
// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

// Вводим метод для преобразования положительных чисел
// в массиве на отрицательные, и наоборот
void InversArr(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
    }
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);