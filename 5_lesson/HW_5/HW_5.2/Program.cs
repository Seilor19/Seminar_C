Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];

void mass(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(-10, 11);
        Console.Write(randomArray[i] + " ");
    }

}
int Sum(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}
mass(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {Sum(randomArray)}");