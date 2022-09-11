// See https://aka.ms/new-console-template for more information
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

//объявление переменных
bool res1 = false;
bool res2 = false;
double aVar = 1;
uint bVar = 1;
string errMess1 = "Число введено неверно.";
string firstMess = "Введите число А: ";
string secondMess = "Введите число В (натуральное число): ";

//ввод значений, вывод результата

InputCheck(errMess1, firstMess, secondMess);
Console.WriteLine($"{aVar}, {bVar} -> {Exp(aVar, bVar)}");

//основной и вспомогательный методы

void InputCheck(string errorMessage, string firstMessage, string secondMessage)
{
    Console.Clear();   
    while (!res1)
    {
        Console.WriteLine(firstMessage);
        res1 = double.TryParse(Console.ReadLine(), out aVar);
        if (!res1 == true)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            while (!res2)
            {
                Console.WriteLine(secondMessage);
                res2 = uint.TryParse(Console.ReadLine(), out bVar);
                if (!res2 == true)
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }
    }
}

double Exp(double varA, uint varB)
{
    if (varB == 0)
    {
        return 1;
    }
    else
    {
        return Exp(varA, varB - 1) * varA;
    }
}