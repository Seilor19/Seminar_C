//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное: ");
int to = int.Parse(Console.ReadLine()!);
double[] arr = new double[a];

void mass(int a)
{
   
    for (int i = 0; i < a; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble()*(to-from)+from, 2);
        Console.Write(arr[i] + " ");
    }

}
double raznitca(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    int i = 1;
    while (i < arr.Length)
    {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
        i = i + 1;
    }
    return Math.Round(max - min, 2);
}
mass(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raznitca(arr)}");