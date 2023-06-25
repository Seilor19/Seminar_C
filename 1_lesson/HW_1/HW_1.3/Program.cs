Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine()!);
int i =1 ;

do
{
    if (i % 2 == 0) 
    {
    Console.WriteLine(i);
    i=i+1;
    }
    else i=i+1;
}
while (i<=N);

    
