Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int sum =0;
for (int i = 0;i<=A;i++)
{
    sum=sum+i;
}
Console.WriteLine("Sum= " + sum);
//int SumNum(int num)
//{
//    int all_sum = 0;
//    for (int i = 1; i <= num; i++)
//        all_sum += i;
//
//    return all_sum;
//}

//int A = int.Parse(Console.ReadLine()!);
//int result = SumNum(A);
//Console.WriteLine(result);
