//Заполните массив на N (вводится с консоли, не более 8)
//случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из
//массива. Старший разряд числа находится на 0-м индексе,
//младший – на последнем.

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
    string count = "";
    foreach (int num in array)
    {

        count = count + num;

    }
    return int.Parse(count);
}



int down = 0;
int up = 8;
Console.WriteLine("Введите размер массива :");
int size = int.Parse(Console.ReadLine()!);
if (9 > size)
{
    int[] result = CreateArray(up, down, size);
    Console.WriteLine(string.Join(", ", result));
    Console.WriteLine(CountNum(result));
}
else
{
    Console.WriteLine("Размер массива не должен превышать 8!");
}


