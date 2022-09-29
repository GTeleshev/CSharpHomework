/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int[] number = new int[2];
Console.Clear();
Console.Write("Введите целое число (M): ");
number[0] = int.Parse(Console.ReadLine());
Console.Write("Введите целое число (N): ");
number[1] = int.Parse(Console.ReadLine());

//NumbersToN(number);
Console.WriteLine();
Console.WriteLine($"M = {number[0]}; N = {number[1]} -> {Ackermann(number[0], number[1])}");

// n + 1, m = 0
//A(m - 1, 1), m > 0, n = 0
//A(m - 1, A(m, n - 1)), m > 0, n > 0

int Ackermann(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0)
        return Ackermann(M - 1, 1);
    else
        return Ackermann(M - 1, Ackermann(M, N - 1));
}