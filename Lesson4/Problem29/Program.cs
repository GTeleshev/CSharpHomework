/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
int[] array = new int[8];

FillArray(array, 1, 100);
PrintArray(array, 0, 7);


void FillArray(int[] collection, int lowerRange, int upperRange)
{
    int length = collection.Length;
    int index = 0;
    while (index < length) 
    {
        collection[index] = new Random().Next(lowerRange,upperRange);
        index++;
    }    
}
void PrintArray(int[] coll, int startPosition, int endPosition)
{
    int position = startPosition;
    Console.Write("[");
    while(position < endPosition && position >= startPosition)
    {
        Console.Write($"{coll[position]},"); 
        position++;
    }
    Console.WriteLine($"{coll[position]}]\r\n");
}