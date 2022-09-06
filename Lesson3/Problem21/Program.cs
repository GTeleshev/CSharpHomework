/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

//
bool err1 = false;
bool err2 = false;
bool err3 = false;
bool err4 = false;

int errorCount = 0;

int[] coordNum1 = new int[] {0,0,0};
int[] coordnum2 = new int[] {0,0,0};
string[] coordinates1 = {"0","0","0"};
string[] coordinates2 = {"0","0","0"};

while (!err1 || !err2 || !err3 || !err4)
{
    Console.Write("Введите первую точку (через запятую): ");
    string point1 = Console.ReadLine();
    Console.Write("Введите вторую точку (через запятую): ");
    string point2 = Console.ReadLine();

    coordinates1 = point1.Split(',');
    Console.WriteLine(coordinates1.Length);
    if (coordinates1.Length != 3) 
    {
        err3 = false;
    }
    else
    {
        err3 = true;
    }
    coordinates2 = point2.Split(',');
    Console.WriteLine(coordinates2.Length);
    int minLength = Math.Min(coordinates1.Length, coordinates2.Length);
    if (coordinates2.Length != 3) 
    {
        err4 = false;
    }
    else
    {
        err4 = true;
    }
    for (int i = 1; i <= minLength; i++)
    {
        err1 = int.TryParse(coordinates1[i-1], out coordNum1[i-1]);
        err2 = int.TryParse(coordinates2[i-1], out coordnum2[i-1]);
    //    Console.WriteLine($"a{i} = {coordNum1[i-1]}, b{i} = {coordnum2[i-1]}");
    }
}

Console.WriteLine($"Дистанция равна: {distance(coordNum1,coordnum2, 2)}");

double distance (int[] point1Coord, int[] point2Coord, int rounding)
{
    double sumSquare = 0;
    for (int i = 1; i <= 3; i++)
    {
        sumSquare = sumSquare + Math.Pow(point1Coord[i-1] - point2Coord[i-1], 2);
    }
    double distance = Math.Sqrt(sumSquare);
    double distanceRound = Math.Round(distance, rounding);
    return distanceRound;
}