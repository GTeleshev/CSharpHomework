// See https://aka.ms/new-console-template for more information
//Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

string errorMessage = "Что-то пошло не так (нажат Enter, не введено целое число, введено число больше 7 или меньше 1)";
string[] weekDays = new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int errorCount = 0;
start:
Console.Write("Введите номер дня недели (число от 1 до 7): ");
bool res = int.TryParse(Console.ReadLine(), out int weekdayNum);


if (!res || weekdayNum > 7 || weekdayNum < 1)
    {
        Console.WriteLine(errorMessage);
        errorCount++;
        Console.WriteLine($"Количество попыток неправильного ввода: {errorCount}, для завершения программы нажмите Ctrl + C, либо повторите попытку");
        goto start;
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