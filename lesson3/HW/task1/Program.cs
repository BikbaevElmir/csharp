Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Число " + num + " Кратное 7 и 23 одновременно");
}
else
{
    Console.Write("Число " + num + " Не кратное 7 и 23 одновременно");
}
