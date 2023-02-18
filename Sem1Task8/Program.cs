// Программа на ввод числа N и вывода всех чисел
// являющихся чётными от 1 до N

// Ввод число
Console.Write("Введите число N - ");
int numN = Convert.ToInt32(Console.ReadLine());

// Условие для проверки
for(int i = 2; i<= numN; i = i +2)
{
// Вывод результата провреки
Console.Write(i + " ");
}