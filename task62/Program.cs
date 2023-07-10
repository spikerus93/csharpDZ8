// Задача 62: Заполните спирально массив 4 на 4.

const int rows = 4;
const int columns = 4;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 20);
        }
    }
    return matrix;
}

void ChangeMatrix(int[,] matrix)
{
    int temp = 1;
    int i=0;
    int j=0;
            while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
            {
                matrix[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= matrix.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > matrix.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomArray(rows, columns);
Console.WriteLine("Вывод Основной Матрицы -");
PrintMatrix(myMatrix);
Console.WriteLine("Вывод Спиральной Матрицы -");
ChangeMatrix(myMatrix);
PrintMatrix(myMatrix);