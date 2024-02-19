//Напишите программу, которая выводит третью с
//конца цифру заданного числа или сообщает, что
//третьей цифры нет.
Console.Write("num: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 100)
    Console.WriteLine("Третьей цифры нет");
else

    Console.WriteLine((num / 100) % 10);