Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int t_number(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра числа {number} является {t_number(number)}");