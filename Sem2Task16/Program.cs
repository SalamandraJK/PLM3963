// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого. 

Console.Write("Введите первое число - ");
int firstNum = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите второе число - ");
int secondNum = int.Parse(Console.ReadLine()??"0");


void SqeaTest(int firstNum, int secondNum)

{
    if(firstNum == secondNum*secondNum)
    {
        Console.WriteLine($"Число {firstNum} является квадратом числа {secondNum}");
    }

    else
    {
         Console.WriteLine($"Число {firstNum} не является квадратом числа {secondNum}");
    }
}

SqeaTest(firstNum,secondNum);

SqeaTest(secondNum,firstNum);
// int multiplication = firstNum*secondNum

