Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int N1 = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(N1 + ",");
        }
        else
        {
            Console.WriteLine(N1);
        }
    }
}
