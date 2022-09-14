/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

double[] doubleArray = FillDblArray(7, -10.0, 10.0);
PrintDbArray(doubleArray);
double arrayMin = MinSeek(doubleArray);
double arrayMax = MaxSeek(doubleArray);
double maxminusmin = arrayMax - arrayMin;

Console.WriteLine($"\r\n->min: {arrayMin} max: {arrayMax} max-min: {maxminusmin}");

double MinSeek(double[] ArrayToSeekMin)
{
    int minLn = ArrayToSeekMin.Length;
    double arrayMin = ArrayToSeekMin[0];
    for (int m = 0; m < minLn; m++)
    {
        if (ArrayToSeekMin[m] < arrayMin)
        {
            arrayMin = ArrayToSeekMin[m];
        }
    }
    return arrayMin;
}

double MaxSeek(double[] ArrayToSeekMax)
{
    int maxLn = ArrayToSeekMax.Length;
    double arrayMax = ArrayToSeekMax[0];
    for (int m = 0; m < maxLn; m++)
    {
        if (ArrayToSeekMax[m] > arrayMax)
        {
            arrayMax = ArrayToSeekMax[m];
        }
    }
    return arrayMax;
}


double[] FillDblArray(int size, double min, double max)
{
    double[] dblArrayToFill = new double[size];
    double dist = max - min;
    double rndDbl = 0;
    double scaledRndDbl = 0;
    for (int k = 0; k < size; k++)
    {
        rndDbl = new Random().NextDouble();
        scaledRndDbl = min + rndDbl * dist;
        dblArrayToFill[k] = scaledRndDbl;
    }
    return dblArrayToFill;
}

void PrintDbArray(double[] arrayToPrint)
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