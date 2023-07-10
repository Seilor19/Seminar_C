// 1. Напишите программу, которая перевернёт одномерный массив
//    (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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
void RevMas(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
}
MassConf(arr);
PrintArray(arr);
RevMas(arr);
Console.WriteLine(" ");
PrintArray(arr);