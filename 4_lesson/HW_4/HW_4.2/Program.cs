//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int len = Length(A);


// Подсчет количества символов в числе
int Length(int A)
{
    int index = 0;
    while (A > 0)
    {
        A /= 10;
        index++;
    }
    return index;
}
// подсчет суммы
int Sum(int A, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + A % 10;
        A = A / 10;
    }
    return sum;
}

Console.Write($"Сумма цифр в числе равно: {Sum(A,len)}");