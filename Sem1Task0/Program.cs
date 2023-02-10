// Задача №0
// Напишите программу, которая выводит число и
// выдаёт его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число: ");

// Считываем данные с консоли
string? inputNum = Console.ReadLine();

// Проверяем, что бы данные были не пустыми
if(inputNum != null)
{
    // Парсим введенное число
    int number = int.Parse(inputNum);

    // Находим квадрат числа
    int outNum = (int)Math.Pow(number,2);

    // Выводим данные в консоль
    Console.WriteLine("Квадрат числа: "+outNum);
}
