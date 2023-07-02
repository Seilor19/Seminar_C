Console.WriteLine("Введите №");
int number = int.Parse(Console.ReadLine()!);


void Quaters(int number)
{
    if (number > 4  || number < 1)
        Console.WriteLine("Не верно введены данные");
    else if (number == 1)
        Console.WriteLine("x>0 & y>0");
    else if (number == 2)
        Console.WriteLine("x<0 & y>0");
    else if (number == 3)
        Console.WriteLine("x<0 & y<0");
    else if (number == 4)
        Console.WriteLine("x>0 & y<0");
}
Quaters(number);