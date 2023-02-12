// Задача на ввод числа и определение,
// является ли это число чётным

Console.Write("Введите число - ");
int numA = Convert.ToInt32(Console.ReadLine());

if(numA %2 == 0)
{
    Console.WriteLine("Число является чётным");
}

else
{
    Console.WriteLine("Число не является чётным");
}