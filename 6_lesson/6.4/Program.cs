// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
void FirstNumbers(int N)
{
    int temp = 0;
    int temp_s = 1;
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine(temp);
        (temp, temp_s) = (temp_s, temp + temp_s);
    }
}
FirstNumbers(N);
