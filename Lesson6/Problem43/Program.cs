/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/* Console.WriteLine("Hello, World!");
 */

double k1 = 1;
double k2 = 3;
double b1 = 4;
double b2 = 6;

double[] intCoord = Intersection(k1,b1,k2,b2);
Console.WriteLine($"{intCoord[0]}, {intCoord[1]}");

double[] Intersection(double mult1, double constant1, double mult2,  double constant2)
{
    double[] intersectionCoord = new double [2];
    string parallel = "Прямые параллельны \n";
    if(mult1 == mult2)
    {
        Console.WriteLine(parallel);        
    }
    else
    {
        intersectionCoord[0] = (constant2 - constant1) / (mult1 - mult2);
        intersectionCoord[1] = intersectionCoord[0] * mult1 + constant1;
    }
    return intersectionCoord;
}