// See https://aka.ms/new-console-template for more information
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Input

Console.Write("Введите первое число: ");
bool res1 = double.TryParse(Console.ReadLine(), out double firstNumber);
Console.Write("Введите второе число: ");
bool res2 = double.TryParse(Console.ReadLine(), out double secondNumber);

//variables

string numOneID = "";
string numTwoID = ""; 
string minId = "минимальное";
string maxId = "максимальное";

//conditional

if (!res1 || !res2)
{
    Console.WriteLine("Что-то пошло не так (одно из чисел введено в неправильном формате или нажат Enter)"); 
}
else
{
if (firstNumber > secondNumber)
    {
    numOneID = maxId;
    numTwoID = minId;
    }
else
    {
    numOneID = minId;
    numTwoID = maxId;    
    }
Console.Write($"Первое число ({firstNumber}) - {numOneID}, второе число ({secondNumber}) - {numTwoID}");
}