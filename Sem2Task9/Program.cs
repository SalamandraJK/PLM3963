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

// Определяем большее число
if(FirstNum > SecondNum)
{
    Console.WriteLine("Первое число больше: " + FirstNum);
    Console.WriteLine("Второго:" + SecondNum);    
}
else
{
    Console.WriteLine("Второе число больше: " + SecondNum) ;
    Console.WriteLine("Первого: " + FirstNum);
}


// Второй варинт решения задачи

// char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
// Console.WriteLine(digits);
// int firstNum = ((int)digits[0])-48;
// int secondNum = ((int)digits[1])-48;

// int rezultNumber = (firstNum>secondNum)?rezultNumber=firstNum:rezultNumber=secondNum;

// Console.WriteLine(rezultNumber);


// Третий вариант решения зщадачи

