/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

//объявление переменных
bool res1 = false;
bool res2 = false;
uint number = 1;
string errMess = "Число введено неверно.";
string firstMess = "Введите число: ";

//ввод 

InputCheck(errMess, firstMess);
Console.WriteLine($"{number} -> {SumDigits(number)}");

void InputCheck(string errorMessage, string firstMessage)
{
    Console.Clear();   
    while (!res1)
    {
        Console.WriteLine(firstMessage);
        res1 = uint.TryParse(Console.ReadLine(), out number);
        if (!res1 == true)
        {
            Console.WriteLine(errorMessage);
        }
    }
}


uint SumDigits(uint N)
{
    if (N==0)
    {
        return 0;
    }
    else
    {
        return N%10 + SumDigits(N/10);
    }
}