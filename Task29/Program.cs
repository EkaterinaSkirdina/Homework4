/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран. */

Console.Clear();

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] arg1)
{
    for (int i = 0; i < arg1.Length; i++)
    {
        arg1[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arg2)
{
    Console.Write("[");
    for (int i = 0; i < arg2.Length-1; i++)
    {
        Console.Write($"{arg2[i]}, ");
    }
    Console.Write($"{arg2.Length-1}]");
}