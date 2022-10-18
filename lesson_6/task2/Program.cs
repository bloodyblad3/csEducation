// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string msg)
{
    System.Console.WriteLine(msg);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double PointX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double PointY(double b1, double k1, double b2, double k2)
{
    return k1*(b2-b1)/(k1-k2)+b1;
}

double b1 = Prompt("Введите точку b1");
double k1 = Prompt("Введите точку k1");
double b2 = Prompt("Введите точку b2");
double k2 = Prompt("Введите точку k2");

System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {PointX(b1, k1, b2, k2)}; {PointY(b1, k1, b2, k2)}");