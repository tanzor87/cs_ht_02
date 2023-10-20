// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.WriteLine($"{number} - не трехзначное число!");
}
else
{
    int second_number  = number / 10;
    second_number = second_number % 10;
    Console.WriteLine($"{number} -> {second_number}");
}

