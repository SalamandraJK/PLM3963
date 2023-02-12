// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <1000)
{
    int res = number%10;
    Console.WriteLine("Последняя цифра числа: "+res);
}
else
Console.WriteLine("Введено не то число");