// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] Gen1DArr(int len, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

// Вводин метод, который печатает одномерный массив
void Print1DArr(double[] arr)
{
    Console.Write("[");

    for(int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}



double MaxMin(double[] arr)
{
    double minNum = double.MaxValue;
    double maxNum = double.MinValue;

for(int i=0; i<arr.Length-1; i++)
{
    if(arr[i]>maxNum) maxNum = arr[i];
    if(arr[i]>minNum) minNum = arr[i];
}
return maxNum - minNum;
}

double[] testArr = Gen1DArr(4, 1, 9);

Print1DArr(testArr);

double ResSum = MaxMin(testArr);
PrintData("Разница между max и min значениями: ", + ResSum);

