//  Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, для печати принятых данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

double K1 = ReadData("Ввидите индекс К1:");
double B1 = ReadData("Ввидите индекс В1:");
double K2 = ReadData("Ввидите индекс К2:");
double B2 = ReadData("Ввидите индекс В2:");
double K3 = ReadData("Ввидите индекс К3:");
double B3 = ReadData("Ввидите индекс В3:");

// Метод нахождения длинны между двумя точками

(double x, double y) CoordinatesOfPoints(double k1, double b1, double k2, double b2)
{
    double CoorX1 = (b2-b1)/(k2-k1);
    double CoorY1 = (k1*b2 - k2*b1)/(k1-k2);
    return(CoorX1, CoorY1);
}

// Метод, находящий расстояние между точками на плоскости
double CalcLen(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

(double x, double y) pointA = CoordinatesOfPoints(K1, B1, K2, B2);
(double x, double y) pointB = CoordinatesOfPoints(K2, B2, K3, B3);
(double x, double y) pointC = CoordinatesOfPoints(K1, B1, K3, B3);

PrintData($"Координаты точек пересечения: {pointA}, {pointB}, {pointC}");

double LenghtSegmentAB = CalcLen(pointA.x, pointA.y, pointB.x, pointB.y);
PrintData($"Длинна отрезка АВ = {LenghtSegmentAB}");

double LenghtSegmentBC = CalcLen(pointB.x, pointB.y, pointC.x, pointC.y);
PrintData($"Длинна отрезка АC = {LenghtSegmentBC}");

double LenghtSegmentCA = CalcLen(pointA.x, pointA.y, pointC.x, pointC.y);
PrintData($"Длинна отрезка CВ = {LenghtSegmentCA}");