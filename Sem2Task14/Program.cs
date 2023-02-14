// Задача, принимающая на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.


Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());

bool oper = (num%21 == 0) && (num%7 == 0);

if (oper)
{

Console.WriteLine("Кратно");
    
}

else
{

Console.WriteLine("НЕ Кратно");

Console.WriteLine(num%23);

Console.WriteLine(num%7);

}