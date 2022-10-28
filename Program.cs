// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число № 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 2 ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"MAX={b}");
    Console.WriteLine($"MAX={a}");
}
else if (a < b)
{
    Console.WriteLine($"MIN={a}");
    Console.WriteLine($"MAX={b}");
}
else if (a == b)
{
    Console.WriteLine("Введены два равных числа MIN=MAX");
}
