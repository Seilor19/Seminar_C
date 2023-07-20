Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine()!);


int Rec(int N)
{   
    
    if (N/10 == 0) return N;
       
    return Rec(N/10)+N%10;
   
    
}

Rec(N);
Console.WriteLine($"{Rec(N)}");