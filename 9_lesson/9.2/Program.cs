Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine()!);

void Rec(int N, int M)
{   
    if (N-1 == M)
    {
        return;
    }
    
    Rec(N, M-1);
    Console.WriteLine($"{M}");
}

Rec(N, M);