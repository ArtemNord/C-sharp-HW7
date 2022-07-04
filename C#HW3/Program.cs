// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int [,] Array (int row, int col)
{
    int [,] array = new int [row, col];
    return array;
}

void FillArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = (new Random().Next (-9, 9));
        }
    }
}

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void AverageColumns(int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = matrix [i, j] + sum;
        }
    double result = Math.Round(sum / matrix.GetLength(0), 2);
    Console.WriteLine($"Результат столбца {j + 1} = {result}");
    }
}

Console.WriteLine($"Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix = Array(row, col);

FillArray(matrix);
PrintArray(matrix);
AverageColumns(matrix);