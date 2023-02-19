// Задача, принимаем на вход координаты точки (Х, Y)
// и показываем в какой плоскости находится точка

// <тип> <имя метода> (<тип><название переменной>)
// {
//     return <тип>
// }

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintQuterTest(int x, int y)
{
    if(x > 0 && y > 0)Console.WriteLine("Точка находится в Первой четверти.");
    if(x > 0 && y < 0)Console.WriteLine("Точка находится во Второй четверти.");
    if(x < 0 && y < 0)Console.WriteLine("Точка находится в Третьей четверти.");
    if(x < 0 && y > 0)Console.WriteLine("Точка находится в Четвертой четверти.");
}

int coordX = ReadData("Введите координату Х: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX, coordY);