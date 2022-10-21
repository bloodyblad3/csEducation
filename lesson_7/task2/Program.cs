// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

(int, int) PositionsFromUser()
{
    System.Console.WriteLine("Введите строковую позицию: ");
    int line = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите колонную позицию: ");
    int column = Convert.ToInt32(Console.ReadLine());
    return (line, column);
}

int[,] CreateArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int SearchNumber(int[,] array, (int line, int column)tuple)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == tuple.line && j == tuple.column)
            {
                return array[i, j];
            }
        }
    }
    return 0;
}

int[,] array = CreateArray(4, 5);
PrintArray(array);
(int line, int column) = PositionsFromUser();
int number = SearchNumber(array, (line, column));
if (number == 0)
{
    System.Console.WriteLine("Такой позиции в массиве не существует!");
}
else {System.Console.WriteLine($"В позиции [{line}; {column}] было найдено число > {number}");}
