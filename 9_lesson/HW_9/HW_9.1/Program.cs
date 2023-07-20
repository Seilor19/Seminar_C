// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine()!);

int che(int N, int M)
{
    if (N <= M && N % 2 == 0) Console.WriteLine($"{N}");

    return che(N + 1, M);
}
che(N, M);

