//Задайте одномерный массив, заполненный случайными
//числами. Определите количество простых чисел в этом
//массиве.

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

bool SearchSimpleNumber(int num)
{
    if (num < 2) return false;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

int CountNum(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (SearchSimpleNumber(num))
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите нижнюю границу :");
int down = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу :");
int up = int.Parse(Console.ReadLine()!);
Console.WriteLine("Размер массива :");
int size = int.Parse(Console.ReadLine()!);

int[] result = CreateArray(up, down, size);
Console.WriteLine(string.Join(", ", result));
Console.WriteLine(CountNum(result));