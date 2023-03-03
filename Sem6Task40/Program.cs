// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

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

// Метод проверки равенства сторон
bool Test(int a, int b, int c)
{
    return(a<=b+c);
}

// Метод проверки существования треугольника
bool TriangleTest(int a, int b, int c)
{
    bool result = false;
    if((Test(a,b,c))&&(Test(b,a,c))&&(Test(c,b,a)))
    {
        result = true;
    }
    return result;
}

int SideA = ReadData("Введите длинну сторону а: ");
int SideB = ReadData("Введите длинну сторону b: ");
int SideC = ReadData("Введите длинну сторону c: ");

if (TriangleTest(SideA, SideB, SideC)) PrintData($"Треугольник со сторонами {SideA}, {SideB}, {SideC} Может существовать");
else PrintData($"Треугольник со сторонами {SideA}, {SideB}, {SideC} Не существует");