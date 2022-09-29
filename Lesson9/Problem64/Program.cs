/* Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2" */
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"N = {number} -> {NumbersToNRecursive(ProcessInput(number))}");
int ProcessInput(int N)
{
    if (N % 2 == 1)
    {
        return N - 1;
    }
    else
    {
        return N;
    }
}
string NumbersToNRecursive(int N)
{
    if (N == 0)
    {
        return String.Empty;
    }
    if (N == 2)
    {
        return 2.ToString();
    }
    if (N % 2 == 0)
    {
        return N + ", " + NumbersToNRecursive(N - 2);
    }
    else
    {
        return String.Empty;
    }
}

