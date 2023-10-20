// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
string number = Console.ReadLine();
int len_number = number.Length;

if (len_number < 3)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{number} -> {number[2]}");
}

