// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AccermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AccermanFunc(m - 1, 1);
    }
    else
    {
        return AccermanFunc(m - 1, AccermanFunc(m, n - 1));
    }
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
System.Console.WriteLine(AccermanFunc(m, n));