// Задайте двумерный массив размером M x N,
// Заполненный случайными вещественными числами.

double [,] DoubleArray (int row, int col)
{
    double [,] array = new double [row, col];
    return array;
}

void FillArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = Math.Round((new Random().NextDouble()) * (new Random().Next (-9, 9)),2);
        }
    }
}

void PrintArray (double [,] matrix)
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

Console.WriteLine($"Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double [,] matrix = DoubleArray(row, col);

FillArray(matrix);
PrintArray(matrix);