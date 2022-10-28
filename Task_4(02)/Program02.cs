// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число № 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 2 ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 3 ");
int c = Convert.ToInt32(Console.ReadLine());
int Max = a;
if (b > Max)
{
    Max = b;
}
else if (c > Max)
{
    Max = c;
}
Console.WriteLine($"Максимальное из трех чисел = {Max}");

