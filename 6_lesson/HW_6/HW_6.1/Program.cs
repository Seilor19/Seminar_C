//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.Если пользователь вводит 0 цикл прерывается

Console.Write("Сколько чисел?");
int M = int.Parse(Console.ReadLine()!);
int res=0;

for (int i = 1; i <= M; i++)
{
    Console.WriteLine($"Введите {i} число ");
    int a = int.Parse(Console.ReadLine()!);
  
    if (a==0)
    {           
                Console.WriteLine("Введеное число равно 0");
                break;
    } 
    
    else if (a>0) res=res+1;
}          
    


Console.WriteLine($"Количество положительных чисел = {res} ");