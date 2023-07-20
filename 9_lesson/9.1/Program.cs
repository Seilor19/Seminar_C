Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine()!);

void Rec(int N)
{
    if (N == 0)
    {
       return;
    }

    Rec(N-1);
    Console.WriteLine($"{N}");
}

Rec(N);
