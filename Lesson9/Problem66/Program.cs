/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int[] number = new int[2];
Console.Clear();
Console.Write("Введите целое число (M): ");
number[0] = int.Parse(Console.ReadLine());
Console.Write("Введите целое число (N): ");
number[1] = int.Parse(Console.ReadLine());
number = ProcessInput(number);
//NumbersToN(number);
Console.WriteLine();
Console.WriteLine($"M = {number[0]}; N = {number[1]} -> {SumMToNRecursive(number[0], number[1])}");

int[] ProcessInput(int[] input)
{
    int temp = 0;
    if (input[0] > input[1])
    {
        temp = input[1];
        input[1] = input[0];
        input[0] = temp;
    }
    return input;
}

int SumMToNRecursive(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + SumMToNRecursive(M + 1, N);
    }
}