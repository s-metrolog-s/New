// Все целые числа от N до -N

Console.WriteLine("Введите число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int numberMinus = -Math.Abs(number);

while (numberMinus <= number)
{
    Console.Write(numberMinus);
     Console.Write(":");
    numberMinus++;
}