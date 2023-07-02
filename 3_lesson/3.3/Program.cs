Console.WriteLine("Введите A1");
double A1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите A2");
double A2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B2");
double b2 = double.Parse(Console.ReadLine()!);

double VectorLenght(double A1, double A2, double b1, double b2)
{
    return Math.Sqrt(Math.Pow(A1-b1, 2) + Math.Pow(A2-b2, 2));
}
double result = VectorLenght(A1, A2, b1, b2);
Console.WriteLine("Расстояние между точками =" + result);