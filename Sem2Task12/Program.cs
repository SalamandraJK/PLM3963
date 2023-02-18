// Задача, принимающая на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

// Получение рандомные числа
System.Random numSintezator = new System.Random();

// Выводим полученный результат
int rndNumber1 = numSintezator.Next(1,100);
int rndNumber2 = numSintezator.Next(1,100);

// Цикл получения результата от деления двух чисел
// Вывод результата
if(rndNumber1%rndNumber2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно" );
    Console.WriteLine(rndNumber1%rndNumber2);
}