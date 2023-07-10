// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.
Console.WriteLine("Введите длинну 1 стороны");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длинну 1 стороны");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длинну 1 стороны");
int c = int.Parse(Console.ReadLine()!);

bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < c + a && c < a + b)
    return true;
    else 
    return false;
}



Console.WriteLine(Triangle(a, b, c));