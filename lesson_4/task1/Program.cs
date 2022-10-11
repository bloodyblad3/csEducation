// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). 
// Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = Prompt("Введите число A: ");
int numberB = Prompt("Введите число B: ");
double pow = 1;

double Power(int numA, int numB)
{
    for (int i = 0; i < numB; i++)
    {
        pow *= numA;
    }
    return pow;    
}

double result = Power(numberA, numberB);
System.Console.WriteLine($"{result:f2}");
