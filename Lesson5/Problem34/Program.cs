/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
Console.Clear();
int[] firstArray = FillArray(5, 100, 1000);
PrintArray(firstArray);
int cntEven = CountEven(firstArray);
Console.WriteLine($"->{cntEven}");

int CountEven(int[] ArrayToCount)
{
    int count = 0;
    int ln = ArrayToCount.Length;
    for (int m = 0; m < ln; m++)
    {
        if (ArrayToCount[m] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

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

void PrintArray(int[] arrayToPrint)
{
    int size = arrayToPrint.Length;
    for (int i = 0; i < size; i++)
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