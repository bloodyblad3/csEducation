// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            int sum = 0;
            sum += firstMatrix[i, j] * secondMatrix[i, j];
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int[,] matrix1 = CreateArray();
int[,] matrix2 = CreateArray();
int[,] resultmatrix = MultiplyMatrix(matrix1, matrix2);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();
PrintArray(resultmatrix);
