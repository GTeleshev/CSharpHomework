/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();
int[] firstArray = FillArray(7, 0, 10);
PrintArray(firstArray);
int sumUneven = SumUnevenPosition(firstArray);
Console.WriteLine($"->{sumUneven}");

int[] FillArray(int size, int min, int max)
{
    int[] arrayToFill = new int[size];
    int elk = 0;
    for (int k = 0; k < size; k++)
    {
        elk = new Random().Next(min, max);
        arrayToFill[k] = elk;
    }
    return arrayToFill;
}

int SumUnevenPosition(int[] ArrayToSum)
{
    int len = ArrayToSum.Length;
    int sum = 0;
    for (int j = 0; j < len; j++)
    {
        if ((j + 1) % 2 != 0)
        {
            sum = sum + ArrayToSum[j];
        }
    }
    return sum;
}

void PrintArray(int[] arrayToPrint)
{
    int size = arrayToPrint.Length;
    for (int i = 0; i <= size; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{arrayToPrint[i]},");
        }
        if (i > 0 && i < size - 1)
        {
            Console.Write($"{arrayToPrint[i]},");
        }
        if (i == size - 1)
        {
            Console.Write($"{arrayToPrint[i]}]");
        }
    }
}