// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    return (end + start) * (end - start + 1) / 2;
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
System.Console.WriteLine($"Сумма в промежутке > {SumNum(m, n)}");