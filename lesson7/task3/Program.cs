// Задайте двумерный массив из целых чисел. Сформируйте новый
//одномерный массив, состоящий из средних арифметических
//значений по строкам двумерного массива.

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

double[] RM(int[,] matrix) //  функция создания нового массива
{
    double[] arr = new double [matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i,j];
            }
            arr[i] = sum / matrix.GetLength(0);
    }
    return arr;
}

void ShowMatrix(int[,] matrix) // функция вывода двумерного массива
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

Console.WriteLine($"Новая матрица:");
foreach (double num in RM(matrix)) // функция вывода одномерного массива
{
    Console.Write($"{num} ");
}