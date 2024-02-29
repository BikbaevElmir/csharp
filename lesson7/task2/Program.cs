// Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и
//т.д.

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

int RM(int[,] matrix) //  функция подсчета 
{ 
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         sum += matrix[i,i];  
    }
    return sum;
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
int sum = RM(matrix);
Console.WriteLine($"Сумма диагонали равна: {sum}");



