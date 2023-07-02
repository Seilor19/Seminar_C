Console.WriteLine("Введите AX");
double AX = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите AY");
double AY = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите AZ");
double AZ = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите BX");
double BX = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите BY");
double BY = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите BZ");
double BZ = double.Parse(Console.ReadLine()!);

double VectorLenght(double AX, double AY, double AZ, double BX, double BY, double BZ)
{
    return Math.Sqrt(Math.Pow(AX-BX, 2) + Math.Pow(AY-BY, 2) + Math.Pow(AZ-BZ, 2) );
}
double result = Math.Round(VectorLenght(AX, AY, AZ, BX, BY, BZ), 2);
Console.WriteLine("Расстояние между точками =" + result);