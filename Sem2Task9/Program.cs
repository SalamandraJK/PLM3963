// Задача, принимающая на вход 

// Задаём структуру, которая генерирует слдучайные числа
System.Random numSintezator = new System.Random();


// Первый вариант решения задачи

// Получаем случайное число от 10 до 100
int rndNumber = numSintezator.Next(10,100);
// Выводим полученное число
Console.WriteLine(rndNumber);
// Получаем старший разряд числа, путём деления на 10
int FirstNum = rndNumber/10;
// Получаем второе цифру числа, остатком от деления
int SecondNum = rndNumber%10;

// Определяем и вывлдим результат сравнения двух полученных чисел
if(FirstNum > SecondNum)
{
    Console.Write($"Первое число {FirstNum} больше ");
    Console.WriteLine($"Второго {SecondNum}");    
}
else
{
    Console.Write($"Второе число {SecondNum} больше ") ;
    Console.WriteLine($"Первого {FirstNum}");
}


// Второй варинт решения задачи

// Получаем случайное число и превращаем его в массив
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
// Выводим полученный
Console.WriteLine(digits);
// 
int firstNum = ((int)digits[0])-48;
int secondNum = ((int)digits[1])-48;
// Записываем тернарный компилятор для получения результата сравнения
int rezultNumber = (firstNum>secondNum)?rezultNumber=firstNum:rezultNumber=secondNum;
// Выводим полученный результат
Console.WriteLine(rezultNumber);



