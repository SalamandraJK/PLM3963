﻿// Задача, принимающая на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

// Вводим число для проверки
Console.Write("Введите число - ");
// Объявляем переменную
int num = Convert.ToInt32(Console.ReadLine()??"0");
// Выполняем проверну на деление без остатка
//  и кладём результат в переменную
bool oper = (num%21 == 0) && (num%7 == 0);
// Цикл для вывода результата
// Результат без остатка
if (oper)
{
    Console.WriteLine("Кратно");  
}
// Результат с отатком. Вывод остатка от деления
else
{
    Console.WriteLine("НЕ Кратно");
    Console.WriteLine(num%23);
    Console.WriteLine(num%7);
}