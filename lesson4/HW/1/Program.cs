// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
      int count=0;
      for(var i = 0; i < numbers.Length;i++)
      {
        if(numbers[i] >= minRange && numbers[i] <= maxRange)
        {
          count++;
        }
      }
      return(count);
    }
    
    public static void PrintResult(int[] array)
    {
        
          //Введите сюда свое решение
      array = new int [] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
      Console.WriteLine(UserInputToCompileForTest.CountItemsRange(array,10,90));
    }

}
