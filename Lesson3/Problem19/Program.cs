// See https://aka.ms/new-console-template for more information
/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

// 1. объявление переменных
bool res = false;
int digiNum = 5;
int requiredLength = 5;
int errorCount = 0;
int inputNum = 0;

// 2. обработка ввода
while (!res || digiNum != requiredLength)
{
    Console.Write($"Введите пятизначное число (попыток {errorCount}): ");
    res = int.TryParse(Console.ReadLine(), out inputNum);
    digiNum = digitsInNum(inputNum);
    errorCount++;
}

// 3. вывод результата

Console.WriteLine(isPalindrome(inputNum));

// 4. проверка на палиндром

string isPalindrome(int numB)
{
    if (numB == reverseNum(numB)) 
    {
        return $"Число {numB} - палиндром";
    }
    else 
    {
        return $"Число {numB} - не палиндром";
    }
}

// 4. возврат обратного числа

int reverseNum(int num)
{
    int length = digitsInNum(num);
    int sum = 0; 
    for (int i = 1; i <= length; i++)
        {
            sum = (sum + retDigit(num, length, length - i + 1)) * 10;
        }
    return sum / 10;
}

// 5. количество цифр в числе

int digitsInNum(int number)
{   
    int count = 0;
    int absNum = Math.Abs(number);
    while (absNum > 0)
    {
    absNum = absNum / 10;
    count++;
    }
    return count;
}

// 6. возврат конкретной цифры числа

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