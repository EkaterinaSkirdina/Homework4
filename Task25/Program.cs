/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16          */

Console.Clear();

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(ExpNumber(A, B));

/*double ExpNum(int x, int y)
{
    double expon = Math.Pow(x, y);
    return expon;
} */

double ExpNumber(int x, int y)
{
    //int count = 1;
    int find = x;
    /*while (count < y)
    {
        find *= x;
        count++;
    }*/
    for (int count = 1; count < y; count++)
    {
        find *= x;
    }
    return find;
}