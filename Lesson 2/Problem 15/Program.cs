// See https://aka.ms/new-console-template for more information
//Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите номер дня недели (число от 1 до 7): ");
bool res = int.TryParse(Console.ReadLine(), out int weekdayNum);
string errorMessage = "Что-то пошло не так (нажат Enter, не введено целое число, введено число больше 7 или меньше 1)";
// int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7};
string[] weekDays = new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (!res || weekdayNum > 7 || weekdayNum < 1)
    {
        Console.WriteLine(errorMessage);
    }
else
    {
        Console.WriteLine($"{weekDays[weekdayNum-1]} - {holidayCheck(weekdayNum)}");
    }
string holidayCheck (int dayNum)
{
    int[] holidays = new int[] {6, 7};
    int holidayCount = 0;
        foreach (int day in holidays)
        {
            if (weekdayNum == day)
            {
                holidayCount++;
            }
            else
            {
                //;
            }
        }
        if (holidayCount > 0)
            {
                return "выходной день";
            }
        else
            {
                return "не выходной день";
            }
}