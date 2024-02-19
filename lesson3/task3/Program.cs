//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если первое число некратно
//второму, то программа выводит остаток от деления.
Console.Write("num1: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("num2: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 % num2 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет, " + num1 % num2);
