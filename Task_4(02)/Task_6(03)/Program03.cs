// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int num = a % 2;
if (num == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число нечетное");
}

