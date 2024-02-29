// Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rowCount, int columsCount) // функция создания массива
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

int[,] RM(int[,] matrix) //  функция замены значений четных индексов
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    matrix[i, j] *= matrix[i, j];
                }
            }
        }

    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // функция вывода результатов
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

// стартуем
int[,] matrix = CreateMatrix(4, 5);
Console.WriteLine($"Начальная матрица");
ShowMatrix(matrix);
int[,] matrix1 = RM(matrix);
Console.WriteLine($"Измененная матрица");
ShowMatrix(matrix1);
