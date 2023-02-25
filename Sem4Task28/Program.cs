// Программа, принимающая на вход число и выдающая произведение от 1 до N.

// Подключаем внешние методы и библиотеки (в конкретном случае BigInteger)
using System.Numerics; 

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

// Вводим метод посчёта произведения цифр, в введенном числе
BigInteger FactorialCalc(int num)
{
    BigInteger res = 1;

for(int i = 1; i<=num; i++)
{
    res = res*i;
}
 // Возвращаем полученное значение
    return res;
}
// Присваеваем внасимое пользователем значение в введенную переменную num.
int numN = ReadData("Введите число : ");
// Вводим переменную resSum и прередаём в нее значение, получаемое в методе DigitSum
BigInteger resFuct = FactorialCalc(numN);
// Выводим получаемый результат
PrintData("Произведенеи всех цифр от 1 до N = " + resFuct);