//Задание №3
// Напишите программу, которая выводит название дня недели
// по заданному номеру

// Введения номера недели, для определения
Console.Write("Введите номер дня недели: ");
// Преобразование
string? lineDay = Console.ReadLine();
// Условие для нахождения дня недели из массива с данными
// Вывод полученного дня недели
if(lineDay != null)
{
    int day = int.Parse(lineDay);
    string[] dayWeek = new string[7];

    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";

   Console.WriteLine(dayWeek[day-1]);
// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));

// Console.WriteLine(outDayOfWeek);

}