// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int outputNumber = ReadData ("Введите пятизначное число на проверку: ");

if(outputNumber>=10000 && outputNumber<=99999)
{
    Dictionary<int, int> palindrome = DictionaryFill();

    bool check = PalinTest(outputNumber, palindrome);
    if (check)
    {
        PrintData(outputNumber, " - Полиндром");
    }
    else
    {
        PrintData(outputNumber, " - Не полиндром");
    }
    }
    else{
        Console.WriteLine("Введено не то число");
    }


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}


void PrintData(int Num, string msg)
{
    Console.WriteLine(Num+msg);
}


Dictionary<int, int> DictionaryFill()
{
    var dictionary = new Dictionary<int, int>();
    int keyNumber = 1;
        for(int secondNumber = 0; secondNumber<=9; secondNumber++)
        {
            for(int firstNumber = 1; firstNumber<=9; firstNumber++)
            {
                dictionary[keyNumber] = firstNumber*1000+secondNumber*100+secondNumber*10+firstNumber;
                keyNumber++;
            }
        }
    return dictionary;    
}


bool PalinTest(int numbers, Dictionary<int, int> palindrome)
{
    bool result = false;
    if (palindrome.ContainsValue((numbers/1000)*100+(numbers%100)))
    {
        result = true;
    }
    return result;
}

// bool PalindromeTest(int num)
// {
//     Boolean result = false;
//     if(num > 9999 && num<100000)
//     {
//         if((num % 10 == num/10000) && ((num/1000)%10 == (num/10)%10)) result = true;
//     }
//     else Console.WriteLine ("Введено не пятизначное число.");
//     return result;
// }