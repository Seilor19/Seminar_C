// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.



int[] NewArray(int[] arr)
{
    int Length = arr.Length;
    int[] arr_2;

    if (Length % 2 == 0) arr_2 = new int[Length / 2];
    else arr_2 = new int[Length / 2 + 1];
    for (int i = 0; i < arr_2.Length; i++)
    {
        if (arr[i] != arr[Length - i - 1]) arr_2[i] = arr[i] * arr[Length - i - 1];
        else arr_2[arr_2.Length - 1] = arr[i];
    }
    return arr_2;

    // int index = 0;
    // while (A > 0)
    // {
    //     A /= 10;
    //     index++;
    // }
    // return index;
}
void PrintArray(int[] arr)
{
    var str = string.Join(" ", arr);
    Console.Write($"{str} ");
}

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine(arr[i]);
//     }
// }

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(a, b, c);
PrintArray(mass);
System.Console.WriteLine();
int[] mass_2 = NewArray(mass);
PrintArray(mass_2);