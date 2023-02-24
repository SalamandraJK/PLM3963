// 

// Вводим метод для приема данных от пользователя
int ReadData(string msg)
{
    console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

// 

(int pozitiv, int negativ) NegPosSum(int[] arr)
{
    int pozitiv = 0;
    int negativ = 0;

    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]>0)
        {
            pozitiv += arr[i];
        }
        else
        {
            negativ += arr[i];
        }
    }
    return (pozitiv, negativ);
}

int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);

(int pozit, int negat) result = NegPosSum(testArr);
PrintData("Сумма положительных значений: ", result.pozit);
PrintData("Сумма отрицательных значений: ", result.negat);