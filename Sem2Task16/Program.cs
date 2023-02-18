// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого. 

// Ввод двух чисел для проверки
Console.Write("Введите первое число - ");
int firstNum = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число - ");
int secondNum = int.Parse(Console.ReadLine()??"0");

// Запись метода VOID
void SqeaTest(int firstNum, int secondNum)

// Условие длоя проверки
{
    if(firstNum == secondNum*secondNum)
    {
// Вывод результата, если подтвержалается условие
        Console.WriteLine($"Число {firstNum} является квадратом числа {secondNum}");
    }
    else
    {
// Вывод результата, если условие не подтвержддается
         Console.WriteLine($"Число {firstNum} не является квадратом числа {secondNum}");
    }
}
SqeaTest(firstNum,secondNum);
SqeaTest(secondNum,firstNum);
// int multiplication = firstNum*secondNum

