// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverage(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            average += array[j, i];
        }
        average = average/array.GetLength(1);
        System.Console.WriteLine($"Среднее арифметическое элементов столбца {i + 1} = {average:f2}");
    }
}

int[,] array = CreateArray();
PrintArray(array);
FindAverage(array);