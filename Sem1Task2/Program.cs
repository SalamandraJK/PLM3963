// Задача на ввод дву чисел и определения
// наибольшего и наименьшего из них

// Ввод числа А
Console.Write("Введите число А - ");
int numA = Convert.ToInt32(Console.ReadLine());
// Ввод числа В
Console.Write("Введите число В - ");
int numB = Convert.ToInt32(Console.ReadLine());

// Цикл для сравнения введенных чисел
// Вывод полученного резултата сравнения
if(numA > numB)
{
    Console.WriteLine("Числа A > B");
}
else
{
    Console.WriteLine("Число В > A");
}
