// See https://aka.ms/new-console-template for more information
//Задача 10: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
string errorMessage = "Что-то пошло не так (нажат Enter, не введено целое число, введено число с количеством цифр <>3";
int errorCount = 0;
int requiredLength = 3;
int requiredPos = 2;
start:
Console.Write("Введите трёхзначное число: ");
bool res = int.TryParse(Console.ReadLine(), out int num);

//решение 1. операция с числом как с текстом

string numstring = Math.Abs(num).ToString();
int strLength = numstring.Length;
if (!res || numstring.Length != requiredLength)
    {
        Console.WriteLine(errorMessage);
        errorCount++;
        Console.WriteLine($"Количество попыток неправильного ввода: {errorCount}, для завершения программы нажмите Ctrl + C, либо повторите попытку");
        goto start;
    }
else
    {
        Console.WriteLine($"Вторая цифра числа (как строка): {numstring[requiredPos-1]}");
    }

//решение 2. операция как с натуральным числом

int outputNum = Math.Abs(retDigit(num, digitsInNum(num), requiredPos));

if (!res || digitsInNum(num) != requiredLength)
    {
        Console.WriteLine(errorMessage);
    }
    else
    {
        Console.WriteLine($"Вторая цифра число (как натуральное число) равно: {outputNum}");
    }

int digitsInNum(int number)
{   
    int count = 0;
    int absNum = Math.Abs(num);
    while (absNum > 0)
    {
    absNum = absNum / 10;
    count++;
    }
    return count;
}

int retDigit (int numbToCut, int length, int position)
{
    int countup = 0;
    int digit = 0;
    while (countup < (length - position + 1))
    {
        digit = numbToCut % 10;
        numbToCut = numbToCut / 10;
        countup++;
    }
    return digit;
}