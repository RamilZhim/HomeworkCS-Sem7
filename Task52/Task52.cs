// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputData(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void AverageColumns(int[,] matrix)
{
    double Average = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Average += matrix[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое по столбцам: ");
        Console.WriteLine($"{Math.Round(Average / matrix.GetLength(0), 2)}");

        Average = 0;
    }
}

int[,] matrix = FillMatrix(InputData("Введите количество строк: "), InputData("Введите количество столбцов: "), InputData("Введите левую границу: "), InputData("Введите правую границу: "));
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
AverageColumns(matrix);