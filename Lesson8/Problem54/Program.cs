/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
int[,] initialArray = GetArray(4, 4, 0, 9);
PrintArray(initialArray);
Console.WriteLine();
int[,] resultingArray = ResultArray(initialArray);
PrintArray(resultingArray);

int[] SortRow(int[] rowToSort)
{
    int rowSize = rowToSort.Length;
    int storage = 0;
    for (int n = 0; n < rowSize; n++)
    {
        for (int k = 0; k < rowSize - 1 - n; k++)
        {
            if (rowToSort[k] > rowToSort[k + 1])
            {
                storage = rowToSort[k];
                rowToSort[k] = rowToSort[k + 1];
                rowToSort[k + 1] = storage;
            }
        }
    }
    return rowToSort;
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

int[,] ReplaceRow(int[,] arrayToReplaceRow, int[] inputRow, int rowNumber)
{
    int rowsNum = arrayToReplaceRow.GetLength(0);
    int columnsNum = arrayToReplaceRow.GetLength(1);
    int[] outputRow = new int[columnsNum];
    for (int k = 0; k < columnsNum; k++)
    {
        arrayToReplaceRow[rowNumber, k] = inputRow[k];
    }
    return arrayToReplaceRow;
}

int[,] ResultArray(int[,] arrayToSort)
{
    int rowsNum = arrayToSort.GetLength(0);
    int columnsNum = arrayToSort.GetLength(1);
    int[,] resultArray = new int[rowsNum, columnsNum];
    
    for (int i = 0; i < rowsNum; i++)
    {
        resultArray = ReplaceRow(arrayToSort, SortRow(ReturnRow(arrayToSort, i)),i);
    }
    return resultArray;
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
