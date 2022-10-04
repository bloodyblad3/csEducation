// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckTheDayOfTheWeek(int number)
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine("да");
    }
    else if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Такого дня недели не существует!");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}

CheckTheDayOfTheWeek(number);