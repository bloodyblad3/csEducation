// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double number = Prompt("Введите число: ");
for (int i = 0; i <= number; i++)
{
    System.Console.Write($"number -> {Math.Pow}");
}