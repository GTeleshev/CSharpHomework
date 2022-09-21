/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */

Console.Clear();
int[] paramArray = InputCheck();

int rows = paramArray[0]; 
int columns = paramArray[1];
int min = paramArray[2];
int max = paramArray[3];
int rowNumber = paramArray[4];
int columnNumber = paramArray[5];
int[,] array = GetArray(rows, columns, min, max);

PrintArray(array);

Console.WriteLine(PrintElement(array, rowNumber, columnNumber));

int[] InputCheck()
{
    Console.Clear();
    int[] parametersArray = new int[6];
    Console.WriteLine("Введите параметры двумерного массива:");
    
    bool res1 = false;
    int M = parametersArray.Length;
    string errorMessage = "Число введено неверно.";
    string secondMessage = "-";
    string[] prefixes = new string [6];
    prefixes[0] = "количество строк массива";
    prefixes[1] = "количество столбцов массива";
    prefixes[2] = "минимум";
    prefixes[3] = "максимум";
    prefixes[4] = "номер строки (от 0)";
    prefixes[5] = "номер столбца (от 0)";
    
    int count = 0;
    while (!res1 || count < M)
    {
        Console.Write($"{secondMessage} {prefixes[count]}: ");
        res1 = int.TryParse(Console.ReadLine(), out parametersArray[count]);
        if (!res1 == true)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            count++;
        }
    }
    return parametersArray;
}

string PrintElement(int[,] arrayToCheck, int row, int column)
{
    if(IsElement(arrayToCheck, row, column) == false)
    {
        return "Элемент не существует";
    }
    else
    {
        return ReturnElement(arrayToCheck, row, column).ToString();
    }
}

bool IsElement(int[,] intArray, int row, int column)
{
    int m = intArray.GetLength(0);
    int n = intArray.GetLength(1);
    if (m <= row || n <= column) return false;
    else return true;
}

int ReturnElement(int[,] intArray, int row, int column)
{
    if (IsElement(intArray, row, column) == true)
    {
        return intArray[row, column];
    }
    else
    {
        return 0;
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int interimVar = 0;
    if(minValue > maxValue)
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
