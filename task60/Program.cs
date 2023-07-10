// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] matrix = new int[4, 5, 4];
FillMatrixMyNumbers(matrix);
PrintMatrix(matrix);

void FillMatrixMyNumbers(int[,,] matrix)
{
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"X({i},{j},{k}) Y({i},{j},{k}) ");
                Console.Write($"Z({i},{j},{k}) \t");
                Console.Write($"{matrix[i, j, k]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}