//Задача 1: 
//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

bool ChVl(string Chv)
{
    int sum = 0;
    int n = int.Parse(Chv);
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void RqVl()
{
    bool flag = true;
    while (flag == true)
    {
        Console.WriteLine("Введите целое число или введите q чтобы остановить программу:");
        string val = Console.ReadLine()!;
        if (ChVl(val) == true ^ val != "q")
        {
            flag = true;
        }
        else
        {
            flag = false;
            Console.WriteLine("Программа завершена");
        }
    }
}

RqVl();
