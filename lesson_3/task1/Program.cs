// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите пятизначное число: ");
int temp = number;
int reversed = 0;

bool IsPolyndrom(int num)
{
    if (num >= 10000)
    {
        while (num > 0)
        {
            int dig = num % 10;
            reversed = reversed * 10 + dig;
            num = num / 10;
            if (temp == reversed)
            {
                return true;
            }
            return false;
        }
    }
    return false;
}

if (IsPolyndrom(number))
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("Введено не пятизначное число, либо оно не является полиндромом");
}
