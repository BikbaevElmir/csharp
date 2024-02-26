int[] arr = new int[3];
int num = int.Parse(Console.ReadLine()!);

for (int i = 0; i < 3; i++)
{
    arr[i] = num % 10;
    num = num / 10;   
    Console.Write(arr[i] + " ");
}