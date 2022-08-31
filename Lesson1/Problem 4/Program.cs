// See https://aka.ms/new-console-template for more information
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
bool res1 = double.TryParse(Console.ReadLine(), out double firstNumber);
Console.Write("Введите второе число: ");
bool res2 = double.TryParse(Console.ReadLine(), out double secondNumber);
Console.Write("Введите третье число: ");
bool res3 = double.TryParse(Console.ReadLine(), out double thirdNumber);
double max = firstNumber;
List<double> threeNumbers = new List<double>();
threeNumbers.Add(firstNumber);
threeNumbers.Add(secondNumber);
threeNumbers.Add(thirdNumber);
int numIndex = 0;
if (!res1 || !res2 || !res3)    
{
    Console.WriteLine("Что-то пошло не так (одно из чисел введено в неправильном формате или нажат Enter)"); 
}
else
{
    while (numIndex < 3)
        {
        if (threeNumbers[numIndex] > max)
        {
        max = threeNumbers[numIndex];
        }
        numIndex++;
        }
Console.Write($"Максимальное число из трёх: {max}");
}