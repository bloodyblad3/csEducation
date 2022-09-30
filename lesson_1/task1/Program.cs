﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if (numberA < numberB)
{
    min = numberA;
    max = numberB;
    System.Console.WriteLine($"Большее число: {max}");
    System.Console.WriteLine($"Наименьшее число: {min}");
}
else
{
    min = numberB;
    max = numberA;
    System.Console.WriteLine($"Большее число: {max}");
    System.Console.WriteLine($"Наименьшее число: {min}");
}
