// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

const int x = 0;
const int y = 1;
const int z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];
    answer[x] = Prompt($"Введите x {point}: ");
    answer[y] = Prompt($"Введите y {point}: ");
    answer[z] = Prompt($"Введите z {point}: ");
    return answer;
}
double Pow(int arg)
{
    return Math.Pow(arg, 2);
}
int[] pointA = InputPoint(1);
int[] pointB = InputPoint(2);

double len = Math.Sqrt(Pow(pointB[x] - pointA[x]) + Pow(pointB[y] - pointA[y]) + Pow(pointB[z] - pointA[z]));

System.Console.WriteLine($"{len:f2}");
