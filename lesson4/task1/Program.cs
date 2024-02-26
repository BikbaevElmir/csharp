int [] arr = new int [] {5, 6, 8, 3, 10};
int num = int.Parse(Console.ReadLine()!);
string f = "Нет";


for (int i = 0; i < arr.Length; i++)
{
    if (arr [i] == num)
    f = "Да";
}

Console.WriteLine(f);
