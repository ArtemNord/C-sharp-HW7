// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет. 

Console.WriteLine($"Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Введите номер строки элемента: ");
int rowX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите номер сстолбца элемента: ");
int colY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix = DoubleArray(row, col);

int [,] DoubleArray (int row, int col)
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
            matrix [i, j] = new Random().Next (-9, 9);
        }
    }
}

// Метод для проверки, правильности выдоваемого результата.
// 
// void PrintArray (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

void FindElement(int [,] matrix, int rowX, int colY)
{
    if (rowX > row || rowX < 0 || colY > col || colY <0)
    {
        Console.WriteLine($"Такого элемента нет");
    }
    else
    {
        rowX = rowX - 1;
        colY = colY - 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == rowX)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    if (j == colY)
                    {
                        Console.WriteLine($"Искомый элемент {matrix [i, j]}");
                    }
                }
            }
        }
    }
}

FillArray(matrix);
//PrintArray(matrix);
FindElement(matrix, rowX, colY);