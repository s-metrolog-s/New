// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число:");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double b = Convert.ToInt32(Console.ReadLine());

if ( a == b * b)
{
    Console.WriteLine("a является b в квадрате");
}
else
{
    Console.WriteLine("a не является b в квадрате");
}