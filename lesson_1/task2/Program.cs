// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if (numberA > numberB && numberA > numberC)
{
    max = numberA;
    min = (numberB < numberC) ? numberB : numberC;
    System.Console.WriteLine($"Среди трех чисел, максимальное = {max}, а минимальное = {min}");
}
else if (numberB > numberA && numberB > numberC)
{
    max = numberB;
    min = (numberA < numberC) ? numberA : numberC;
    System.Console.WriteLine($"Среди трех чисел, максимальное = {max}, а минимальное = {min}");
}
else
{
    max = numberC;
    min = (numberB < numberA) ? numberB : numberA;
    System.Console.WriteLine($"Среди трех чисел, максимальное = {max}, а минимальное = {min}");
}