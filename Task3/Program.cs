// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");
int nameWeekDay = Convert.ToInt32(Console.ReadLine());

if ((nameWeekDay < 1) || (nameWeekDay > 7))
{
    Console.WriteLine("Введите правильно число от 1 до 7");
}
else
{
    if (nameWeekDay == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (nameWeekDay == 2)
        {
            Console.WriteLine("Вторник");
        }
    else if (nameWeekDay == 3)
        {
            Console.WriteLine("Среда");
        }
    else if (nameWeekDay == 4)
        {
            Console.WriteLine("Четверг");
        }
    else if (nameWeekDay == 5)
        {
            Console.WriteLine("Пятница");
        }
    else if (nameWeekDay == 6)
        {
            Console.WriteLine("Суббота");
        }
    else if (nameWeekDay == 7)
        {
            Console.WriteLine("Воскресенье");
        }
    }