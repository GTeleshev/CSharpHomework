/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами 
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Clear();

int[] inputArray = InputCheck();
int rows = inputArray[0];
int columns = inputArray[1];
int min = inputArray[2];
int max = inputArray[3];
int numDecimals = inputArray[4];

double[,] array = GetArray(rows, columns, min, max, numDecimals);

PrintArray(array);

int[] InputCheck()
{
    Console.Clear();
    int[] parametersArray = new int[5];
    Console.WriteLine("Введите параметры двумерного массива:");
    
    bool res1 = false;
    int M = parametersArray.Length;
    string errorMessage = "Число введено неверно.";
    string secondMessage = "-";
    string[] prefixes = new string [5];
    prefixes[0] = "количество строк массива";
    prefixes[1] = "количество столбцов массива";
    prefixes[2] = "минимум";
    prefixes[3] = "максимум";
    prefixes[4] = "количество знаков после запятой";

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

double[,] GetArray(int m, int n, int minValue, int maxValue, int numberOfDecimals)
{
    int interimVar = 0;
    if(minValue > maxValue)
    {
        interimVar = maxValue;
        maxValue = minValue;
        minValue = interimVar;
    }
    
    double[,] result = new double[m, n];
    double interimVariable;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            interimVariable = new Random().NextDouble();
            result[i, j] = Math.Round(minValue + interimVariable * (maxValue - minValue), numberOfDecimals);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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
