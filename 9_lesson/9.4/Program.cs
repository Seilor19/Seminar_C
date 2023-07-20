Console.Write("Введите A ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите B ");
int B = int.Parse(Console.ReadLine()!);

int Rec(int A, int B)
{       
    if (B==0) return 1;
       
    return Rec(A,B-1)*A;
   
    
}

Rec(A,B);
Console.WriteLine($"{Rec(A,B)}");