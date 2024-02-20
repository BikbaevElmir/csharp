Console.Write("Введите число отрезка [10 по 99]: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 9 && num < 100)
{
    int num1 = num / 10;
    int num2 = num % 10;
    Console.WriteLine(num1 > num2 ? num1 : num2);
}
else
{
    Console.WriteLine("Точка не находится в отрезке");
}
