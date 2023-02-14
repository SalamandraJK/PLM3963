// Задача, принимающая на вход 

System.Random numSintezator = new System.Random();

// Первый вариант решения задачи

int rndNumber = numSintezator.Next(10,100);

Console.WriteLine(rndNumber);

int FirstNum = rndNumber/10;
int SecondNum = rndNumber%10;

if(FirstNum > SecondNum)
{
    Console.WriteLine("Первое число больше " + FirstNum + "Второго" + SecondNum);    
}

else
{
    Console.WriteLine("Второе число больше " + FirstNum + "Первого" + SecondNum);
}


// Второй варинт решения задачи

char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNum = ((int)digits[0])-48;
int secondNum = ((int)digits[1])-48;

int rezultNumber = (firstNum>secondNum)?rezultNumber=firstNum:rezultNumber=secondNum;

Console.WriteLine(rezultNumber);


// Третий вариант решения зщадачи

