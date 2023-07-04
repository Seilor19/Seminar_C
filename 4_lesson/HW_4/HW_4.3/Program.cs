//Массив с произвольными значениями и заданной длиной
Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine()!);
int[] arr = new int[length];

void MassConf(int[] arr)
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next();
    }
}
void PrintArray(int[] arr)
{
    var str = string.Join(" ", arr);
    Console.Write($"{str} ");
}
MassConf(arr);
PrintArray(arr);
