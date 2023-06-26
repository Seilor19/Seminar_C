Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine()!);
if (number >= 100 && number < 1000)
{
int mid = ((number % 100 - number % 10) / 10);
Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
Console.WriteLine("Это число не трехзначное");