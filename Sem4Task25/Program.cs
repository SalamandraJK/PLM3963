// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

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

// Вводим метод возведения в степень введенных данных
long Pow(int A, int B)
{
long res = 1;    
while(B > 0)
{
    res = res*A;
    B = B-1;
}
return res;
}

// Вводинм метод осуществляющий вычитание введенных данных
long Subtraction(int A, int B)
{
    long res = 0;
    if(B<A)
    {
        res = A - B;
    }
    else
    {
        res = B - A;
    }
return res;
}

// Вводинм метод осуществляющий суммирование введенных данных
long SumNumber(int A, int B)
{
    long res = 0;

    res = A + B;

return res;
}

// Вводинм метод осуществляющий произведение введенных данных
long Multiplication(int A, int B)
{
    long res = 0;
    if(B != 0 && A != 0)
    {
        res = A*B;
    }

return res;
}

// Вводинм метод осуществляющий деление введенных данных
long Division(int A, int B)
{
    long res = 0;
    if(B != 0 && A != 0)
    {
        res = A / B;
    }
return res;
}

// Присваеваем внасимое пользователем значение в введенную переменную numberA.
int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число B: ");

// Вводим переменную resPow и прередаём в нее значение, получаемое в методе Pow
long resPow = Pow(numA,numB);

// Вводим переменную resSubtrac и прередаём в нее значение, получаемое в методе Subtraction
long resSubtrac = Subtraction(numA,numB);

// Вводим переменную resPow и прередаём в нее значение, получаемое в методе SumNumber
long resSum = SumNumber(numA,numB);

// Вводим переменную resMulti и прередаём в нее значение, получаемое в методе Multiplication
long resMulti = Multiplication(numA,numB);

// Вводим переменную resMulti и прередаём в нее значение, получаемое в методе Multiplication
long resDiv = Division(numA,numB);

Console.WriteLine(" ");
PrintData("Число А в степени числа В = " + resPow);
Console.WriteLine(" ");
PrintData("Разница чисел А и В = " + resSubtrac);
Console.WriteLine(" ");
PrintData("Сумма чисел А и В = " + resSum);
Console.WriteLine(" ");
PrintData("Произведение чисел А и В = " + resMulti);
Console.WriteLine(" ");
PrintData("Деление чисел А и В = " + resDiv);
Console.WriteLine(" ");