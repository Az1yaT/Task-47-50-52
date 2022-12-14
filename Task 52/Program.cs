// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

for (int i = 0; i < 3; i++)
{
    int average = 0;
    for (int j = 0; j < 4; j++)
    {
        average += arr[i, j];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)average / 4}");
}