// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 пример неправильный? если так то мне повезло и алгоритм работает

int[] InputNumbers (string msg)
{
    System.Console.WriteLine(msg);
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}

int Counter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

int[] array = InputNumbers("Введите числа через пробел: ");
System.Console.WriteLine(Counter(array));