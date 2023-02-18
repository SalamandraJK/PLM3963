// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// Ввод числа
Console.Write("Введите число: ");
// Преобразование значения в строку
string? inputLine = Console.ReadLine();

// Условие для нахождения результата
if(inputLine!=null)
{
int inputNumber = int.Parse(inputLine);
int startNumber = inputNumber*(-1);
string outline = string.Empty;

    // Цикл для записи всех чисел в диапозоне от (-N до N)
    while(startNumber < inputNumber)
    {
        outline = outline + startNumber + ", ";
        startNumber++;
    }
    outline = outline + inputNumber;
// Вывод результата
    Console.WriteLine(outline);
}