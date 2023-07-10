// Задача 58: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.

const int rowsFirstMatrix = 2;
const int columnsFirstMatrix = 2;
const int rowsSecondMatrix = 2;
const int columnsSecondMatrix = 2;

int[,] FirstMatrix(int rowsFirstMatrix, int columnsFirstMatrix)
{
    int[,] matrix1 = new int[rowsFirstMatrix, columnsFirstMatrix];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix1;
}

int[,] SeconMatrix(int rowsSecondMatrix, int columnsSecondMatrix)
{
    int[,] matrix2 = new int[rowsSecondMatrix, columnsSecondMatrix];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix2;
}

void MultiplyFirstSecondMatrix(int[,] FirstMatrix, int[,] SecondMatrix, int[,] ResultMatrix)
{
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            {
                sum = FirstMatrix[i, j] * SecondMatrix[i, j];
                ResultMatrix[i, j] = sum;
            }
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] myFirstMatrix = FirstMatrix(rowsFirstMatrix, columnsFirstMatrix);
Console.WriteLine($"\nВывод Первой Матрицы -");
PrintMatrix(myFirstMatrix);
int[,] mySecondMatrix = SeconMatrix(rowsSecondMatrix, columnsSecondMatrix);
Console.WriteLine($"\nВывод Второй Матрицы -");
PrintMatrix(mySecondMatrix);
int[,] ResultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];
MultiplyFirstSecondMatrix(myFirstMatrix, mySecondMatrix, ResultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(ResultMatrix);