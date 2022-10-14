// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = CreateArray(10, 0, 20);
PrintArray(array);
System.Console.WriteLine($"Сумма нечетных чисел в массиве: {SumOdd(array)}");
