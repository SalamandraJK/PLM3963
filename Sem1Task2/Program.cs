// Задача на ввод дву чисел и определения
// наибольшего и наименьшего из них
Console.Write("Введите число А - ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В - ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    Console.WriteLine("Числа A > B");
}

else
{
    Console.WriteLine("Число В > A");
}
