//Задача 2: Задайте массив заполненный случайными
//трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в
//массиве.

int CountingNumberEven(int[] array)
{
    int sum = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0)
        {
            sum++;
        }
    }
    return sum;


}

int[] CreateArray(int up, int down, int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(down, up);
    }
    return array;
}

Console.WriteLine("Введите размер массива :");
int size = int.Parse(Console.ReadLine()!);
int[] result = CreateArray(999, 100, size);
int cou = CountingNumberEven(result);
Console.WriteLine($"В массиве ({string.Join(", ", result)}) {cou} четных чисел");