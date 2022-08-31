// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//input
Console.Write("Введите число: ");
bool res = int.TryParse(Console.ReadLine(), out int Number);
//variables
int currentEven = 2;
int maxEven = Number - Number%2;
//conditional + embedded cycle
if (!res || Number < 0)
    {
    Console.WriteLine("Что-то пошло не так (одно из чисел введено в неправильном формате или нажат Enter или число отрицательное)");   
    }
else 
    while (currentEven <= maxEven)
        {
        Console.Write($"{currentEven} ");
        currentEven = currentEven + 2;    
        }