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

int[,] CreateArray(int lines = 5, int columns = 5)
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

int SearchNumber(int[,] array, (int line, int column) tuple)
{
    if (tuple.line < 0 || tuple.line >= array.GetLength(0) || tuple.column < 0 || tuple.column >= array.GetLength(1))
    {
        return -1;
    }

    return array[tuple.line, tuple.column];
}

int[,] array = CreateArray();
PrintArray(array);
(int line, int column) = PositionsFromUser();
int number = SearchNumber(array, (line, column));
if (number == -1)
{
    System.Console.WriteLine("Такой позиции в массиве не существует!");
}
else { System.Console.WriteLine($"В позиции [{line}; {column}] было найдено число > {number}"); }
