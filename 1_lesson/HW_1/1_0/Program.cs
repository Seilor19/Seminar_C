
Console.WriteLine("Введите 1ое число");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 2ое число");

int b = int.Parse(Console.ReadLine()!);
int max;
int min;
if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
