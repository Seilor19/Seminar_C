Console.WriteLine("Введите 1ое число");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 2ое число");

int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 3ое число");

int c = int.Parse(Console.ReadLine()!);
int max = a;
if(b>max) max = b;
if(c>max) max = c ;  

 

Console.WriteLine("Максимальное значение = ");
Console.WriteLine(max);
