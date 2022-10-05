// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int result = (number / 10) % 10;
    System.Console.WriteLine($"Вторая цифра этого числа > {result}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}