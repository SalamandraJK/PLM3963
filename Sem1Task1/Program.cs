// Задача №1
// Напишите программу, которая принимает на вход два числа и
// проверяет является ли первое число, квадратом второго.

// Ввод первого числа
Console.WriteLine("Введите Первое число: ");
string? numLine1 = Console.ReadLine();
// Ввод второго числа
Console.WriteLine("Введите Второе число: ");
string? numLine2 = Console.ReadLine();

// Условие для сравнения двух введенных чисел
// Получение и вывод результата
if(numLine1 != null && numLine2 != null)
{
   int num1 = int.Parse(numLine1);
   int num2 = int.Parse(numLine2);
    if(num2*num2 == num1)
    {
        Console.WriteLine ("Yes");
    }
        else
        {
        Console.WriteLine("No");
        }
}