//Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
bool res = int.TryParse(Console.ReadLine(), out int num);
string errorMessage = "Что-то пошло не так (нажат Enter, не введено целое число)";
string insuffLength = "В числе нет третьей цифры";
int requiredDigit = 3;

// Решение 1 - с переводом числа в текстовую строку

if (!res)
{
    Console.WriteLine(errorMessage);
}

else 
{
    string numstring = Math.Abs(num).ToString();
    int numlength = numstring.Length;
    if (numlength < requiredDigit)
    {
        Console.WriteLine(insuffLength);
    }
    else
    {
        Console.WriteLine($"Третье число (текст) равно: {numstring[2]}");
    }
}

// Решение 2 - без перевода числа в текстовую строку

int outputNum = Math.Abs(retDigit(num, digitsInNum(num), requiredDigit));

if (digitsInNum(num) < requiredDigit)
    {
        Console.WriteLine(insuffLength);
    }
    else
    {
        Console.WriteLine($"Третье число (как натуральное число) равно: {outputNum}");
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