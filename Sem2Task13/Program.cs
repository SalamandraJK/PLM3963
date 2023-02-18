// Задача, на вывод третьёй цифры заданного числа и
// ли сообщение того, что третьей цифры нет.

// Ввод числа
Console.Write("Введите число: ");
// Считываем переменную числа
String num = Console.ReadLine()??"0";
// Преобразовываем число в массив
char[] array = num.ToCharArray();
// Находим длинну массива
int ArrayLen = array.Length;
// Условие для проверки по нахождению третьего числа цифры
if (ArrayLen > 2)
{
Console.WriteLine($"Длинна массива: {ArrayLen}");
Console.WriteLine($"Третье число: {array[2]}");
}
else
{
Console.WriteLine("Введено число, в котором нет третьей цифры");
Console.WriteLine($"Длинна массива: {ArrayLen}");
}