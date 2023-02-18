// Задача на ввод трех чисел и определение маклимального из них

// Ввод трёх цисел для задачи
Console.Write("Введите число А - ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B - ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C - ");
int numC = Convert.ToInt32(Console.ReadLine());

// Условие для определение наибольшего числа из введненных выше
// Вывод полученного результата
if (numA > numB)
{
if (numA > numC)
{
Console.WriteLine("Большее число: " + numA);
}
else
{
Console.WriteLine("Большее число: " + numC);
}
}
else
{
if (numB > numC)
{
Console.WriteLine("Большее число: " + numB);
}
else
{
Console.WriteLine("Большее число: " + numC);
}
}
// if(numA > numB)
// {
//     if(numA>numC)
//     {
//         Console.WriteLine($"Большее число {numA} ");
//     }    
//     else 
//     {
//         Console.WriteLine($"Большее число {numC} ");
//     }
// }
//     if(numB > numC)
//     {
//         Console.WriteLine($"Большее число {numB} ");
//     }
//     else
//     {
//             Console.WriteLine($"Большее число {numC} ");  
//         }
