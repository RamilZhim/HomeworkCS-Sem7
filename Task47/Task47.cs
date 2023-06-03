// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int InputData(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    double[,] matrix = new double[rows, columns];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange) / 10.0;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] matrix = FillMatrix(InputData("Введите количество строк: "), InputData("Введите количество столбцов: "), InputData("Введите левую границу: "), InputData("Введите правую границу: "));
Console.WriteLine();
PrintMatrix(matrix);