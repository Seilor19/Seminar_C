// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

string BinNum(int a)
{
    string number = string.Empty;
    for (; a != 0; a /= 2)
    {
        number = a % 2 + number;
    }
    return number;
}
Console.WriteLine(BinNum(a));
