// Программа, принимающая на вход число А и, выдающая сумму чисел от 1 до А.

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
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Вводим метод подсчёта суммы чисел от 1 до А
long SumOfNumbers(int numA)
{
    // Вводим переменную для вывода получаемого результата
    long sum = 0;

    for(int i=1; i<=numA; i++)
    {
        sum+=i; // сокращенная форма записи "sum = sum + i".  
    }

    // Возвращаем полученную переменную с результатом
    return sum;
}

// Вводим метод подсчёта суммы чисел от 1 до А, Метод Гаусса
long SumGauss(int numA)
{
    long sum = 0;
    sum = ((1 + (long)numA)*(long)numA)/2;
    return sum;
}

// Присваеваем внасимое пользователем значение в введенную переменную numberA.
int numberA = ReadData("Введите число А: ");

// Вводим переменную res1 и прередаём в нее значение, получаемое в методе SumOfNumbers
long res1 = SumOfNumbers(numberA);

// Вводим переменную res2 и прередаём в нее значение, получаемое в методе SumGauss
long res2 = SumGauss(numberA);


// Выводим получаемый результат
PrintResult("Сумма чисел от 1 до А = " + res1);

// Выводим получаемый результат
PrintResult("Сумма чисел от 1 до А методом Гаусса = " + res2);