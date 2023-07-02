Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y");
int y = int.Parse(Console.ReadLine()!);

void Quaters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x == 0 or y == 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (y < 0 && x > 0)
        Console.WriteLine("III");
}
Quaters(x, y);