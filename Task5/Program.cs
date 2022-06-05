//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
//456 - 6

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int result;

if (n > 99 && n < 1000)
{
    result = n % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено не правильное число");
}