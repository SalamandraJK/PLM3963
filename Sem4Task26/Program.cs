﻿// Программа, принимающая на вход число и, выдающее Колличество, содержащихся в нем цифр.

// Добавляем метод принимающий данные от пользователя
int ReadData(string line)
{
    // Вывод сообщения
    Console.Write(line);
    // Считываем данные от пользователя
    int numberP = int.Parse(Console.ReadLine()??"0");
    // Возвращаем полученное значение
    return numberP;
}
// Вводим метод вывода получаемого результата
void PrintData(string line)
{
    Console.WriteLine(line);
}
// Вводим метод, осуществляющий подсчёт колличества цифр, в веденном числе.
int DigitSum(int num)
{
    int res = 0;
    // Вводим цикл для посчета колличества цифр.
    while(num > 0)
    {
        res+=1;
        num = num/10;
    }
    // Возвращаем полученный результат.
    return res;
}
// Присваеваем внасимое пользователем значение в введенную переменную number.
int number = ReadData("Введите число : ");

// Вводим переменную resSum и прередаём в нее значение, получаемое в методе DigitSum
int resSum = DigitSum(number);

// Выводим получаемый результат
PrintData("Колличество цифр в веденном числе = " + resSum);