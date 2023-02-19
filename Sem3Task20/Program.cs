// Получить координаты двух точек и найти расстояние между ними
// в 2D пространстве

// Вводим метод, читающий данный введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод выводит данные пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

// Метод, находящий расстояние между точками на плоскости
double CalcLen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}


int x1 = ReadData("Введите координату x точки А: ");
int y1 = ReadData("Введите координату y точки А: ");
int x2 = ReadData("Введите координату x точки В: ");
int y2 = ReadData("Введите координату y точки В: ");

double res = CalcLen2D(x1, y1, x2, y2);

PrintData($"Расстояние между точками А и В: ", res);

// int quarter = ReadData("Введите координату z1:");
// int quarter = ReadData("Введите координату z2:");