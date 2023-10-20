// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Программа проверяет, является ли день недели выходным.");
Console.Write("Введите день недели номером от 1 до 7: ");
int week_day = Convert.ToInt32(Console.ReadLine());

if (week_day >=1 && week_day <=7)
{
    if (week_day == 1 || week_day == 2 || week_day == 3 || week_day == 4 || week_day == 5)
    {
        Console.WriteLine($"{week_day} -> No");
    }
    else
    {
        Console.WriteLine($"{week_day} -> Yes");
    }
}
else
{
    Console.WriteLine($"{week_day} -> Нет дня недели с таким номером");
}
