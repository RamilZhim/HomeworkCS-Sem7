// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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

void FindElement(int[,] matrix, int positionRow, int positionColumn)
{
    int element = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == positionRow - 1 && j == positionColumn - 1) element = matrix[i, j];
        }
    }

    if (element > 0)
    {
        Console.WriteLine("Значение выбранного элемента: " + element);
    }

    else
    {
        Console.WriteLine("Такого элемента в этом массиве нет!");
    }

}

int[,] matrix = FillMatrix(InputData("Введите количество строк: "), InputData("Введите количество столбцов: "), InputData("Введите левую границу: "), InputData("Введите правую границу: "));
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
FindElement(matrix, InputData("Введите номер строки искомого элемента: "), InputData("Введите номер столбца искомого элемента: "));

