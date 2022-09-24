/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */
Console.Clear();
string defaultString = String.Empty;
int[,] arrayToProcess = GetArray(4, 4, 0, 9);

int[] rowminIndex = RowMinimumSumIndex(arrayToProcess);
PrintArray(arrayToProcess);
Console.WriteLine();
Console.WriteLine($"Номер строки (от 0) с наименьшей суммой: {rowminIndex[0]}. Сумма: {rowminIndex[1]}");

int[] RowMinimumSumIndex(int[,] arrayToGetMinimum)
{
    int rows = arrayToGetMinimum.GetLength(0);
    int columns = arrayToGetMinimum.GetLength(1);
    int min = RowSum(ReturnRow(arrayToGetMinimum, 0));
    int minIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        if (RowSum(ReturnRow(arrayToGetMinimum, i)) < min)
        {
            min = RowSum(ReturnRow(arrayToGetMinimum, i));
            minIndex = i;
        }
    }
    int[] minArray = new int[2];
    minArray[0] = minIndex;
    minArray[1] = min;
    return minArray;
}

int RowSum(int[] rowToSum)
{
    int len = rowToSum.Length;
    int sum = 0;
    for (int n = 0; n < len; n++)
    {
        sum = sum + rowToSum[n];
    }
    return sum;
}

int[] ReturnRow(int[,] arrayToExtract, int rowNumber)
{
    int rowsNum = arrayToExtract.GetLength(0);
    int columnsNum = arrayToExtract.GetLength(1);
    int[] outputRow = new int[columnsNum];
    for (int k = 0; k < columnsNum; k++)
    {
        outputRow[k] = arrayToExtract[rowNumber, k];
    }
    return outputRow;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int interimVar = 0;
    if (minValue > maxValue)
    {
        interimVar = maxValue;
        maxValue = minValue;
        minValue = interimVar;
    }

    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}