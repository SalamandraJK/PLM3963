// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Добавляем метод принимающий данные от пользователя
int ReadData(string line)
{
    // Вывод сообщения
    Console.Write(line);
    // Считываем данные от пользователя
    int number = int.Parse(Console.ReadLine()??"0");
    // Возвращаем полученное значение
    return number;
}

// Вводим метод вывода получаемого результата
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Вводим метод посчета суммы цифр в веденном числе
int SumNumber(int N)
{
    int res = 0;
    while(N>0)
    {
        res = res + N%10;
        N = N/10;
    }
return res;
}

// Присваеваем внасимое пользователем значение в введенную переменную numberA.
int numN = ReadData("Введите число N: ");

// Вводим переменную resSum и прередаём в нее значение, получаемое в методе SumNumber
long resSum = SumNumber(numN);

Console.WriteLine(" ");
PrintData("Сумма цифр в числе N = " + resSum);
