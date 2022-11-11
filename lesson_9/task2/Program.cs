// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write(sum);
        return;
    }
    PrintSum(m, n - 1, sum);
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
System.Console.Write($"Сумма чисел в промежутке > ");
PrintSum(m, n, 0);