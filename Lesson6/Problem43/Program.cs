/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double[,] linesParam = TwoLinesEquations();
double[] intCoord = Intersection(linesParam);

Console.WriteLine($"Координаты точки пересечения: ({intCoord[0]}; {intCoord[1]})");
//вычисление точки пересечения
double[] Intersection(double[,] linesParamArray) //mult1, double constant1, double mult2, double constant2
{
    double[] intersectionCoord = new double[2]; //координаты точки пересечения
    string parallel = "Прямые параллельны \n";
    if (linesParamArray[0, 0] == linesParamArray[1, 0]) //k1 == k2
    {
        Console.WriteLine(parallel);
    }
    else
    {
        intersectionCoord[0] = (linesParamArray[1, 1] - linesParamArray[0, 1]) /
                                (linesParamArray[0, 0] - linesParamArray[1, 0]); //constant2 - constant1) / (mult1 - mult2)
        intersectionCoord[1] = intersectionCoord[0] * linesParamArray[0, 0]
                                + linesParamArray[0, 1]; //x *mult1 + constant1;
    }
    return intersectionCoord;
}
//параметры прямой
double[,] TwoLinesEquations()
{
    Console.Clear();
    double[] arrayToFill = new double[4];
    Console.WriteLine("Параметры прямой: y = k * x + b (k - коэффициент, b - константа):");
    bool res1 = false;
    int M = arrayToFill.Length;
    string errorMessage = "Число введено неверно";
    string secondMessage = "Введите";
    string[] prefixes = new string [4];
    prefixes[0] = "k1";
    prefixes[1] = "b1";
    prefixes[2] = "k2";
    prefixes[3] = "b2";
    int count = 0;
    while (!res1 || count < M)
    {
        Console.Write($"{secondMessage} {prefixes[count]}: ");
        res1 = double.TryParse(Console.ReadLine(), out arrayToFill[count]);
        if (!res1 == true)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            count++;
        }
    }
    double[,] outPutArray = new double[2,2];
    outPutArray[0,0] = arrayToFill[0];
    outPutArray[0,1] = arrayToFill[1];
    outPutArray[1,0] = arrayToFill[2];
    outPutArray[1,1] = arrayToFill[3];
    return outPutArray;
}
