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
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Такого дня недели не существует!");
    }
    if (number < 6) // знаю что можно через else, но почему-то выводило да-нет при вводе числа 6 или 7, поэтому заменил на конкретное условие
    {
        System.Console.WriteLine("нет");
    }
}

CheckTheDayOfTheWeek(number);