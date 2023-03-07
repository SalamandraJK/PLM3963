// // Задача №33
// // Задайте массив. Напишите программу, которая определяет,
// // присутствует ли заданное число в массиве.

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

// Вводим метод для ответа на вопрос задачи
int SearchEleme(int[] arr, int elem)
{
    int res = -1;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] == elem)
        {
            res = i; 
            break;
        }
    }
    return res;
}

int[] testArr = Gen1DArr(12, -9, 9);

Print1DArr(testArr);

Console.Write("Введите элемент: ");

int elem = int.Parse(Console.ReadLine());

int res = SearchEleme(testArr, elem);

if(res > 0)
{
    Console.WriteLine("Эелемент находится в массиве с индексом: " +res);
}
else
{
    Console.WriteLine("Эелемент не найден");
}