/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

string errMess1 = "Число введено неверно";
string firstMess = "Введите количество чисел для проверки (M): ";
string secondMess = "Введите число ";
string thirdMess = "Количество положительных чисел во введённой последовательности: ";

CheckPositive(errMess1, firstMess, secondMess, thirdMess);

void CheckPositive(string errorMessage, string firstMessage, string secondMessage, string thirdMessage)
{
    Console.Clear();
    bool res1 = false;
    bool res2 = false;
    int M = 1;
    int posCount = 0;
    while (!res1)
    {
        Console.Write(firstMessage);
        res1 = int.TryParse(Console.ReadLine(), out M);
        if (!res1 == true)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            int count = 0;
            double[] numsToCheck = new double [M];
            
            while (!res2 || count < M)
            {
                Console.Write($"{secondMessage} {count + 1}: ");
                res2 = double.TryParse(Console.ReadLine(), out numsToCheck[count]);
                if (!res2 == true)
                {
                    Console.WriteLine(errorMessage);
                }
                else if(numsToCheck[count] > 0)
                {
                    posCount++;
                    count++;
                }
                
            }
        }
    }
    Console.WriteLine(thirdMessage + posCount.ToString());
}

