// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число: ");
bool res = double.TryParse(Console.ReadLine(), out double Number);

if (!res)
{
    Console.WriteLine("Что-то пошло не так (одно из чисел введено в неправильном формате или нажат Enter)");   
}
else
{
    if (Number%2 == 0)
    {
    Console.Write($"Число {Number} - чётное");
    }
    else
    {
    Console.Write($"Число {Number} - нечётное");
    }
}