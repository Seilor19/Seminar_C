Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int I = 1;
double result = 1;

if (N <= 0)
  Console.WriteLine("значение не может быть равно или меньше 0");
  else do
    {
        
        result = Math.Pow(I, 3);
        Console.WriteLine("Значения = " + result);
        I=I+1;
        
    }
    while (I <= N);
