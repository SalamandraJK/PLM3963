// Задача, на приём цифры, обозначающую день недели, и проверка его, является ли этот день выходным.

// Вводин число(день недели)
Console.Write("Введите день недели - ");
int nume = int.Parse(Console.ReadLine()??"0");
// Условия для проверки
if(nume < 8 && nume > 0)
{
    if(nume > 5)
    Console.WriteLine("Выходной день");
    
    if(nume < 5)
     Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Введено неверное число");
}