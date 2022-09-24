/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();
int dimension0 = 4;
int dimension1 = 4;
int[,] array = new int[dimension0, dimension1];
int[] valuesToFill = Get2DArray(dimension0 * dimension1, 1, 1);
int[,] firstCoord = new int[1, 2];
firstCoord[0, 0] = 0;
firstCoord[0, 1] = 0;

int[,] seqArray = GenerateValueSequence(array, valuesToFill, firstCoord);
string format = "00";
PrintStringArray(ConvertToStringArray(array, format));
//BeepDraw(seqArray, 4, format);

int[,] GenerateValueSequence(int[,] array, int[] valuesToFill, int[,] initialCoordinates)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int step = 0;
    int[,] sequence = new int[m * n, 4];
    int[,] currentCoord = initialCoordinates;
    int direction = 0;
    while (step < m * n)
    {
        if (array[currentCoord[0, 0], currentCoord[0, 1]] == 0)
        {
            array[currentCoord[0, 0], currentCoord[0, 1]] = valuesToFill[step];
        }
        sequence[step, 0] = step;
        sequence[step, 1] = currentCoord[0, 0];
        sequence[step, 2] = currentCoord[0, 1];
        sequence[step, 3] = valuesToFill[step];
        direction = RotateDirection(array, currentCoord, direction);
        currentCoord = NextCoordinate(currentCoord, direction);
        step++;
    }
    return sequence;
}

int RotateDirection(int[,] arraytocheck, int[,] coordinates, int direction)
{
    int rows = arraytocheck.GetLength(0);
    int columns = arraytocheck.GetLength(1);
    int[,] nextCoord = NextCoordinate(coordinates, direction);
    if (nextCoord[0, 0] == rows ||
        nextCoord[0, 1] == columns ||
        nextCoord[0, 0] < 0 ||
        nextCoord[0, 1] < 0 ||
        ReturnArrayValue(arraytocheck, nextCoord) != 0)
    {
        if (direction < 3)
        {
            direction++;
        }
        else
        {
            direction = 0;
        }
    }
    return direction;
}

int ReturnArrayValue(int[,] array, int[,] coordinates)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int row = coordinates[0, 0];
    int column = coordinates[0, 1];
    int arrayValue = -1000;
    if (row < rows && column < columns && row >= 0 && column >= 0)
    {
        arrayValue = array[row, column];
    }
    else
    {
        arrayValue = -2000;
    }
    return arrayValue;
}

int[,] NextCoordinate(int[,] coordinates, int direction)
{
    // direction - направление (движения, проверки)
    //0 - направо - 0 строка, +1 столбец
    //1 - вниз - +1 строка, 0 столбец
    //2 - влево - 0 строка, -1 столбец
    //3 - наверх - -1строка, 0 столбец
    int[,] nextCoordinates = new int[1, 2];
    int[,] directionArray = new int[4, 2];
    int increment = 1;
    directionArray[0, 0] = 0;
    directionArray[1, 0] = increment;
    directionArray[2, 0] = 0;
    directionArray[3, 0] = -increment;
    directionArray[0, 1] = increment;
    directionArray[1, 1] = 0;
    directionArray[2, 1] = -increment;
    directionArray[3, 1] = 0;
    nextCoordinates[0, 0] = coordinates[0, 0] + directionArray[direction, 0];
    nextCoordinates[0, 1] = coordinates[0, 1] + directionArray[direction, 1];
    return nextCoordinates;
}

int[] Get2DArray(int size, int start, int increment)
{
    int[] consecutiveArray = new int[size];
    for (int k = 0; k < size; k++)
    {
        consecutiveArray[k] = start + increment * k;
    }
    return consecutiveArray;
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

void PrintStringArray(string[,] inArray)
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

string[,] ConvertToStringArray(int[,] array, string formatting)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    string[,] finalString = new string[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            finalString[i, j] = array[i, j].ToString(formatting);
        }
    }
    return finalString;
}

void BeepDraw(int[,] sequenceArray, int spacing, string formatting)
{
    int rows = sequenceArray.GetLength(0);
    for (int i = 0; i < rows; i++)
    {
        Console.Beep();
        Console.SetCursorPosition((spacing) * sequenceArray[i, 2], (spacing - 2) * sequenceArray[i, 1]);
        Console.Write((sequenceArray[i, 3]).ToString(formatting));
    }
}