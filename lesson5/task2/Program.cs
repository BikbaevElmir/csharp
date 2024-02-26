//Задайте массив из N случайных целых чисел (N вводится с
//клавиатуры).
//Найдите количество чисел, которые оканчиваются на 1 и
//делятся нацело на 7.
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


int CountNum(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 10 == 1 && num % 7 == 0)
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