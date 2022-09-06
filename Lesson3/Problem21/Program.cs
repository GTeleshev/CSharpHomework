/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите первую точку (через запятую): ");
string point1 = Console.ReadLine();
Console.Write("Введите первую точку (через запятую): ");
string point2 = Console.ReadLine();
int[] coordNum1 = {0,0,0};
int[] coordnum2 = {0,0,0};
string[] coordinates1 = point1.Split(',');
string[] coordinates2 = point2.Split(',');

for (int i = 1; i <= 3; i++)
{
    coordNum1[i-1] = int.Parse(coordinates1[i-1]);
    coordnum2[i-1] = int.Parse(coordinates2[i-1]);
    Console.WriteLine($"a{i} = {coordNum1[i-1]}, b{i} = {coordnum2[i-1]}");
}

Console.WriteLine(distance(coordNum1,coordnum2, 2));

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

/* foreach (var coord in coordinates)
{
    System.Console.WriteLine($"{coord}");
    
} */

/* Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
double roundDistance = Math.Round(distance, 3);

Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно {roundDistance}");

Console.WriteLine("Введите координаты первой точки"); */

/* string[] values = Console.ReadLine().Split(new char[] { ',' });
int ix1 = int.Parse(values[0]);
int iy1 = int.Parse(values[1]);

Console.WriteLine("Введите координаты второй точки");
string[] values_2 = Console.ReadLine().Split(new char[] { ',' });
int ix2 = int.Parse(values_2[0]);
int iy2 = int.Parse(values_2[1]);
    
double result = Math.Round(Math.Sqrt(Math.Pow(ix2 - ix1, 2) + Math.Pow(iy2 - iy1, 2)),2);

Console.WriteLine($"Расстояние между двумя точками в 2D равно: {result}"); */
