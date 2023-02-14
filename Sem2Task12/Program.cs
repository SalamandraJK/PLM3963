// Задача, принимающая на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

System.Random numSintezator = new System.Random();

int rndNumber1 = numSintezator.Next(1,100);

int rndNumber2 = numSintezator.Next(1,100);

if(rndNumber1%rndNumber2 == 0)

{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно" );
    Console.WriteLine(rndNumber1%rndNumber2);
}