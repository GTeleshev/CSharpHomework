/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();
int[,,] arrayToPrint = Get3DArray(2, 2, 2, 10, 99);
Print3DArray(arrayToPrint);

int[,,] Get3DArray(int x, int y, int z, int min, int max)
{
    int[,,] arrayToFill = new int[x, y, z];
    int dimension0 = arrayToFill.GetLength(0);
    int dimension1 = arrayToFill.GetLength(1);
    int dimension2 = arrayToFill.GetLength(2);
    for (int i = 0; i < dimension0; i++)
    {
        for (int j = 0; j < dimension1; j++)
        {
            for (int k = 0; k < dimension2; k++)
            {
                arrayToFill[i, j, k] = GenerateUnique(arrayToFill, i, j, k, min, max);
            }
        }
    }
    return arrayToFill;
}

int GenerateUnique(int[,,] arrayToFill, int x, int y, int z, int min, int max)
{
    while (IsUnique3D(arrayToFill, x, y, z) == false || arrayToFill[x, y, z] < min || arrayToFill[x, y, z] > max)
    {
        arrayToFill[x, y, z] = new Random().Next(min, max);
    }
    return arrayToFill[x, y, z];
}

bool IsUnique3D(int[,,] arrayToCheck, int x, int y, int z)
{
    int dimension0 = arrayToCheck.GetLength(0);
    int dimension1 = arrayToCheck.GetLength(1);
    int dimension2 = arrayToCheck.GetLength(2);
    int valueToCheck = arrayToCheck[x, y, z];
    int uniqueCount = 0;
    for (int p = 0; p < dimension0; p++)
    {
        for (int q = 0; q < dimension1; q++)
        {
            for (int r = 0; r < dimension2; r++)
            {
                if (arrayToCheck[p, q, r] == valueToCheck)
                {
                    uniqueCount++;
                }
            }
        }

    }
    if (uniqueCount > 1)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void Print3DArray(int[,,] arrayToPrint)
{
    int dimension0 = arrayToPrint.GetLength(0);
    int dimension1 = arrayToPrint.GetLength(1);
    int dimension2 = arrayToPrint.GetLength(2);
    for (int i = 0; i < dimension0; i++)
    {
        for (int j = 0; j < dimension1; j++)
        {
            for (int k = 0; k < dimension2; k++)
            {
                Console.WriteLine($"{arrayToPrint[i, j, k]}({i},{j},{k})");
            }
        }
    }
}