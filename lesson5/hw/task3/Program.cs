//Задача 3: 
//Напишите программу, которая перевернёт
//одномерный массив (первый элемент станет
//последним, второй – предпоследним и т.д.)
int[] ReversArr(int[] array)
{
    int[] arr = new int [array.Length];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arr[i] = array[array.Length - i - 1];
        arr[array.Length - i - 1] = array[i];
    }
    if (array.Length%2 != 0) 
    {
        arr[array.Length/2] = array[array.Length/2];
    }
    return arr;
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

Console.WriteLine("Введите нижнюю границу :");
int down = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу :");
int up = int.Parse(Console.ReadLine()!);
Console.WriteLine("Размер массива :");
int size = int.Parse(Console.ReadLine()!);
int[] result = CreateArray(up, down, size);
int[] result1 = ReversArr(result);
Console.WriteLine($"Начальный массив ({string.Join(", ", result)})");
Console.WriteLine($"Зеркальный массив ({string.Join(", ", result1)})");