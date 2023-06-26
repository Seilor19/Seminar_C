

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}
int th_m = new Random().Next(100, 999);
int result =TakeNum(th_m);
Console.WriteLine(result);