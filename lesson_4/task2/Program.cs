// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число: ");
int result = 0;

int SumDig(int num)
{
    while(num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

result = SumDig(number);
System.Console.WriteLine(result);