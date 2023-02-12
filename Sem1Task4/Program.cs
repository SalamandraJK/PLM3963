// Задача на ввод трех чисел и определение маклимального из них

Console.Write("Введите число А - ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B - ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C - ");
int numC = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    if(numA>numC)
    {
        Console.WriteLine("Большее число: " +numA);
    }    

    else 
    {

        Console.WriteLine("Большее число: " +numC);
    }
}
    if(numB > numC)
    {
        Console.WriteLine("Большее число: " +numB);
    }
    else
    {
            Console.WriteLine("Большее число: " +numC);  
        }
