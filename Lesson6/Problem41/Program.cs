/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

//объявление массива
double[] array = new double[0];
double[] newArray = InputNumberSequence(array);
int cP = CountPositive(newArray);
//вывод массива и результата
Console.WriteLine($"Массив: [{String.Join(" ", newArray)}], количество положительных -> {cP}");

//метод ввода и обработки массива
double[] InputNumberSequence(double[] arrayToFill)
{
    Console.Clear();
    bool res1 = false;
    bool res2 = false;
    int M = -1;
    string errorMessage = "Число введено неверно";
    string firstMessage = "Введите количество чисел для проверки (M): ";
    string secondMessage = "Введите число ";
    while (!res1 || M < 0)
    {
        Console.Write(firstMessage);
        res1 = int.TryParse(Console.ReadLine(), out M);
        if (!res1 == true || M < 0)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            int count = 0;
            Array.Resize(ref arrayToFill, arrayToFill.Length + M);
            while (!res2 || count < M)
            {
                Console.Write($"{secondMessage} {count + 1}: ");
                res2 = double.TryParse(Console.ReadLine(), out arrayToFill[count]);
                if (!res2 == true)
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    count++;
                }
            }

        }
    }
    return arrayToFill;
}
//метод расчёт числа положительных
int CountPositive(double[] arrayToCountPositive)
{
    int positiveCount = 0;
    int len = arrayToCountPositive.Length;
    for (int i = 0; i < len; i++)
    {
        if(arrayToCountPositive[i] > 0)
        {
            positiveCount++;
        }
    }
    return positiveCount;
}