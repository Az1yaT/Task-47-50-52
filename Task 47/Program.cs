// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = rnd.Next(1,100);
        Console.Write("{0,4}", arr[i, j]);
    }
    Console.WriteLine();
}