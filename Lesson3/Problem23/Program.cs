/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

// 1. объявление переменных

bool res = false;
int errorCount = 0;
int inputNum = 0;

// 2. обработка ввода

while (!res)
{
    Console.Write($"Введите число (попыток {errorCount}): ");
    res = int.TryParse(Console.ReadLine(), out inputNum);
    errorCount++;
}

// 3. вывод 

Console.WriteLine(expString(inputNum, 3));

// 4. функция возврата строки, возведенных в степень последовательност чисел

string expString (int N, int exp)
{
    string startString = $"{N}->";
    string interString = "";
    double numExp = 0;
    for(int i = 1; i < N; i++)
    {
        numExp = Math.Pow(i, exp);
        interString = interString + numExp.ToString() + ",";
    }
    string endString = Math.Pow(N, exp).ToString();
    string outputString = startString + interString + endString;
    return outputString;
}