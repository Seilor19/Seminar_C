Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine()!);

int sum(int N, int M)
{
if (N==M)
return N;
else return N + sum(N + 1, M);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {sum(N,M)}");