// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int num = 0;
while (i <= N)
{
    num = i % 2;
    if (num == 0)
    {
        Console.Write($"{i}, ");
        i++;
        Console.WriteLine();
    }
    else
    {
        i++;
    }
}
